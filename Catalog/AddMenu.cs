using Catalog.Data; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class AddMenu : Form
    {
        public bool IsAdd { get; private set; }
        public DataBase Data { get; private set; }

        public AddMenu(DataBase data)
        {
            InitializeComponent();
            Data = data;
            IsAdd = false;

            foreach (var category in Data.Category)
            {
                Category.Items.Add(category);
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string category = Category.Text;

            if (category.Length != 0)   // если строка не пуста
            {
                if (!Category.Items.Contains(category)) // если данная категория отсутсвтует
                {
                    Category.Items.Add(category);   // добавить в список
                    Data.Category.Add(category);    // добавить в базу
                }
                else
                {
                    AlertMenu alert = new AlertMenu("Данная категория уже существует");
                    alert.ShowDialog(this);
                }
            }
            else
            {
                AlertMenu alert = new AlertMenu("Строка пуста");
                alert.ShowDialog(this);
            }
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            string category = Category.Text;

            if (Data.Category.Count != 0)      // если строка не пуста
            {
                Category.Items.Remove(category);    // удаляем из списка
                Data.Category.Remove(category);     // удаляем из базы

                if (Category.Items.Count != 0)                      // если количество категорий не равно нулю
                    Category.Text = Category.Items[0].ToString();   // ставим текущую категорию
                else
                    Category.Text = "";                             // иначе просто пустую строку
            }
            else
            {
                AlertMenu alert = new AlertMenu("Список пуст");
                alert.ShowDialog(this);
            }
        }

        private void AddMedicament_Click(object sender, EventArgs e)
        {
            // чтение данных
            string name             = MedicamentName.Text;
            string category         = Category.Text;
            int dosage              = Convert.ToInt32(Dosage.Value);
            int countOfDoses        = Convert.ToInt32(CountOfDoses.Value);
            DateTime dateOfIssue    = DateOfIssue.Value;
            DateTime shelfLife      = ShelfLife.Value;
            string purpose          = Purpose.Text;

            bool isValid = true;

            // проверка на корректность
            if (name.Length == 0)
            {
                MedicamentName.BackColor = Color.Red;
                isValid = false;
            }
            if (category.Length == 0)
            {
                Category.BackColor = Color.Red;
                isValid = false;
            }
            if (dosage == 0)
            {
                Dosage.BackColor = Color.Red;
                isValid = false;
            }
            if (dateOfIssue >= shelfLife)
            {
                AlertMenu alert = new AlertMenu("Дата выпуска не может быть\nбольше или равна\nдате срока годности");
                alert.ShowDialog(this);
                isValid = false;
            }

            if (isValid) // если корректно
            {
                Medicament medicament = new Medicament(dateOfIssue, shelfLife) // создаём объект лекарства
                {
                    Name            = name,
                    Category        = category,
                    Dosage          = dosage,
                    CountOfDoses    = countOfDoses,
                    Purpose         = purpose
                };

                Data.Medicaments.Add(medicament);   // добавляем в базу

                if (!Category.Items.Contains(category))     // если не добавили
                    Data.Category.Add(Category.Text);   // добавляем категорию
                
                IsAdd = true;   // если было добавление
                Hide();         // выходим
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Dosage_Click(object sender, EventArgs e)
        {
            (sender as NumericUpDown).BackColor = Color.White;
        }

        private void MedicamentName_Click(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = Color.White;
        }
    }
}
