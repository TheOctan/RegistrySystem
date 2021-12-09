using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data
{
    public class DataBase
    {
        public List<Medicament> Medicaments { get; private set; }
        public SortedSet<string> Category { get; set; }
        public string FileName { get; set; }

        public static readonly string Empty = "Пусто";
        public static readonly string AllCategory = "Все";

        public DataBase()
        {
            Medicaments = new List<Medicament>();
            Category = new SortedSet<string>();
            FileName = "";
        }

        public bool LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName)) return false;   // если файл не существует выходим

            // сбрасываем базу
            Medicaments.Clear();
            Category.Clear();

            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))      // открываем файловый поток
            {
                using (StreamReader reader = new StreamReader(file))    // открываем поток чтения
                {
                    //int linesNumber = 1;

                    while (!reader.EndOfStream)     // пока не конец потока
                    {
                        string line = reader.ReadLine();    // считываем всю строку

                        string[] lines = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // разделяем на подстроки с помощью разделителя пробела

                        if (lines.Length == 6 || lines.Length == 7)
                        {
                            string name             = lines[0].Replace('_', ' ');
                            string category         = lines[1].Replace('_', ' ');
                            int dosage              = int.Parse(lines[2]);
                            int countOfDoses        = int.Parse(lines[3]);
                            DateTime dateOfIssue    = DateTime.Parse(lines[4].Replace('_', ' '));
                            DateTime shelfLife      = DateTime.Parse(lines[5].Replace('_', ' '));

                            string purpose = "";
                            if (lines.Length == 7) purpose = lines[6].Replace('_', ' ').Replace('+', '\n');

                            Medicament medicament = new Medicament(dateOfIssue, shelfLife)
                            {
                                Name            = name,
                                Category        = category,
                                Dosage          = dosage,
                                CountOfDoses    = countOfDoses,
                                Purpose         = purpose
                            };

                            Medicaments.Add(medicament);
                            Category.Add(category);
                        }

                        //linesNumber++;
                    }
                    reader.Close();
                }
                file.Close();
            }

            return true;
        }
        public bool RecordToFile(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write)) // открываем файловый поток
            {
                using (StreamWriter writer = new StreamWriter(file))    // открываем поток записи
                {
                    foreach (var medicament in Medicaments)     // перебираем все медикаменты
                    {
                        StringBuilder builder = new StringBuilder();

                        // склеиваем все поля в одну строку, заменяя пробелы в каждом поле на нижнее подчёркивание, раставляя пробелы между ними
                        builder.Append(medicament.Name.Replace(' ', '_')).Append(' ');
                        builder.Append(medicament.Category.Replace(' ', '_')).Append(' ');
                        builder.Append(medicament.Dosage.ToString()).Append(' ');
                        builder.Append(medicament.CountOfDoses.ToString()).Append(' ');
                        builder.Append(medicament.DateOfIssue.ToLongDateString().Replace(' ', '_')).Append(' ');
                        builder.Append(medicament.ShelfLife.ToLongDateString().Replace(' ', '_')).Append(' ');
                        builder.Append(medicament.Purpose.Replace(' ', '_').Replace('\n', '+'));

                        writer.WriteLine(builder.ToString());
                    }
                }
            }

            return true;
        }
    }
}
