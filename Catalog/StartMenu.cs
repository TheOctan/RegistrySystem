using Catalog.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class StartMenu : Form
    {
        public DataBase Data { get; private set; }
        public List<Medicament> CurrentList { get; private set; }

        public StartMenu()
        {
            InitializeComponent();

            Data = new DataBase();
            CurrentList = new List<Medicament>();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            bool cancel = false;

            if (Save.Enabled || (Data.FileName != "" && !File.Exists(Data.FileName)))   // если активна кнопка "сохранить"(а это значит есть несозранённые данные) или файл сохранения отсутствует(случайно удалили) при условии, что это не пустая строка
            {
                SaveMenu menu = new SaveMenu(Data);     // вызываем окно сохранения
                menu.ShowDialog(this);
                cancel = menu.CancelAct;                // получаем информацию об операции

                if (menu.IsSave)                        // если было произвдено сохранение
                    Save.Enabled = false;
            }


            if (!cancel)        // если не было операции отмены(то есть было произведено созранение или несозранение)
            {
                openFileDialog1.FileName = "";              // сбрасываем имя файла

                if (openFileDialog1.ShowDialog() == DialogResult.OK)    // если выбрали файл
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    if(fileInfo.Extension == ".txt")                 // если расширение файла txt
                    {
                        Data.FileName = openFileDialog1.FileName;   // устанавливаем рабочий файл

                        Save.Enabled = false;    // отключаем кнопку сохранить(то есть сохранять нечего)
                        Edit.Enabled = false;    // редактировать 
                        Delete.Enabled = false;    // и удалять не можем, так как ещё не выбран медикамент

                        ResetMedicamentInformation();           // сбрасываем дисплей информации
                        SetActiveMedicamentInformation(false);  // делаем неактивным

                        // загружаем данные из файла в базу
                        if (Data.LoadFromFile(Data.FileName))     // если данные загрузились
                        {
                            RestartMedicamentList();               // обновляем окно списка медикаментов
                        }
                    }
                    else
                    {
                        AlertMenu menu = new AlertMenu("Файл должен быть расширения txt");
                        menu.ShowDialog(this);
                    }
                }
            }
        }

        private void MedicamentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MedicamentsList.SelectedIndex;          // индекс выбранного лекарства из списка
            if(index >= 0 && index < Data.Medicaments.Count)    // проверка границ с базой
            {
                SetActiveMedicamentInformation(true);       // делаем активным дисплеи вывода информации

                Edit.Enabled    = true; // разрешаем редактирование
                Delete.Enabled  = true; // и удаление путём включения соответсвующи кнопок

                Medicament medicament = Data.Medicaments[index];    // берём текущее лекарство

                // выводим данные о полях
                MedicamentName.Text = medicament.Name;
                //Category.Text       = medicament.Category;
                Dosage.Text         = medicament.Dosage.ToString();
                CountOfDoses.Text   = medicament.CountOfDoses.ToString();
                DateOfIssue.Text    = medicament.DateOfIssue.ToLongDateString();
                ShelfLife.Text      = medicament.ShelfLife.ToLongDateString();
                Purpose.Text        = medicament.Purpose;

                if(medicament.ShelfLife < DateTime.Now) ShelfLife.BackColor = Color.Red;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddMenu menu = new AddMenu(Data);   // открываем меню добавления
            menu.ShowDialog(this);

            if(menu.IsAdd)  // если было произведено добавление
            {
                ResetMedicamentInformation();           // сбрасываем дисплей информации
                SetActiveMedicamentInformation(false);  // делаем неактивным

                // производим сброс
                Edit.Enabled    = false;
                Delete.Enabled  = false;
                Save.Enabled    = true;     // делаем активной кнопку сохранения(то есть появились несохранённые данные)

                CurrentList = Data.Medicaments.ToList();        // обновляем текущий список

                MedicamentsList.Enabled = true;     // делаем окно списка лекарств активным
                RestartMedicamentList();             // обновляем окно списка лекарств

                UpdateCategoryList();                   // обновляем список категорий
                Category.Text = DataBase.AllCategory;   // отображаем все категории

                Search.Enabled = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int index = MedicamentsList.SelectedIndex;              // индекс выбранного лекарства из списка
            if (index >= 0 && index < Data.Medicaments.Count)       // проверка границ с базой
            {
                EditMenu menu = new EditMenu(Data.Category, CurrentList[index]);   // открываем меню редактирования и передаём редактируемый медикамент
                menu.ShowDialog(this);

                if (menu.IsEdit)        // если было произведено редактирование
                {
                    ResetMedicamentInformation();           // сбрасываем дисплей информации
                    SetActiveMedicamentInformation(false);  // делаем неактивным

                    // производим сброс
                    Edit.Enabled    = false;
                    Delete.Enabled  = false;
                    Save.Enabled    = true;     // делаем активной кнопку сохранения(то есть появились несохранённые данные)

                    RestartMedicamentList();     // обновляем окно списка лекарств
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SelectionMenu menu = new SelectionMenu("Хотите удалить лекарство?");
            menu.ShowDialog(this);

            if(!menu.CancelAct)
            {
                int index = MedicamentsList.SelectedIndex;          // индекс выбранного лекарства из списка
                if (index >= 0 && index < Data.Medicaments.Count)   // проверка границ с базой
                {
                    ResetMedicamentInformation();           // сбрасываем дисплей информации
                    SetActiveMedicamentInformation(false);  // делаем неактивным

                    // производим сброс
                    Edit.Enabled = false;
                    Delete.Enabled = false;
                    Save.Enabled = true;     // делаем активной кнопку сохранения(то есть появились несохранённые данные)

                    Medicament medicament = CurrentList[index]; // удаляемое лекарство

                    Data.Medicaments.Remove(medicament);        // удаляем медикамент из базы
                    CurrentList.Remove(medicament);             // удаляем медикамент из текущего списка
                    MedicamentsList.Items.RemoveAt(index);      // удаляем медикамент из окна списка лекарств

                    if (Data.Medicaments.Count == 0)            // если база пуста
                    {
                        MedicamentsList.Enabled = false;                // делаем окно списка лекарств неактивным
                        MedicamentsList.Items.Add(DataBase.Empty);      // и добавляем надпись "пусто"

                        Search.Enabled = false;
                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Data.FileName == "" || !File.Exists(Data.FileName))        // если текущий файл сохранения отсутсвует в базе или на диске
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)    // выбираем новый
                {
                    Data.FileName = saveFileDialog1.FileName;       // устанавливаем рабочий файл

                    Data.RecordToFile(Data.FileName);       // сохраняем базу в файл
                    Save.Enabled = false;                   // отключаем кнопку сохранить(произведены сохранения)
                }
            }
            else
            {
                Data.RecordToFile(Data.FileName);       // сохраняем базу в файл
                Save.Enabled = false;                   // отключаем кнопку сохранить(произведены сохранения)
            }
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            MedicamentsList.Items.Clear();                      // очищаем список медикаментов

            if(Category.Text == DataBase.AllCategory)           // если стоит категория "все"
            {
                CurrentList = Data.Medicaments.ToList();        // то копируем все медикаменты из базы в текущий список
            }
            else
            {
                CurrentList = Data.Medicaments.Where(medecament => medecament.Category == Category.Text).ToList(); //иначе все медикаменты с указанной категорией
            }

            UpdateMedicamentList();                             // обновляем отображаемый список

            // производим сброс кнопок
            ResetMedicamentInformation();
            SetActiveMedicamentInformation(false);

            Delete.Enabled = false;
            Edit.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Search.Text == "Поиск")
            {
                SearchMenu menu = new SearchMenu(Data);
                menu.ShowDialog(this);

                if (menu.IsSearch)
                {
                    CurrentList = menu.CurrentList.ToList();

                    UpdateMedicamentList();

                    ResetMedicamentInformation();
                    SetActiveMedicamentInformation(false);

                    // производим сброс
                    Edit.Enabled = false;
                    Delete.Enabled = false;
                    Category.Enabled = false;

                    Search.Text = "Сброс";
                }
            }
            else
            {
                RestartMedicamentList();

                ResetMedicamentInformation();
                SetActiveMedicamentInformation(false);

                // производим сброс
                Edit.Enabled = false;
                Delete.Enabled = false;
                Category.Enabled = true;

                Search.Text = "Поиск";
            }
        }

        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // когда закрываем окно
            if(Save.Enabled || (Data.FileName != "" && !File.Exists(Data.FileName)))    // если активна кнопка "сохранить"(не сохранены данные) или файл сохранения отсутствует(случайно удалили) при условии, что это не пустая строка
            {
                SaveMenu menu = new SaveMenu(Data); // открываем окно сохранения
                menu.ShowDialog(this);
                e.Cancel = menu.CancelAct;      // в случае отмены, прерываем закрытие окна и остаёмся в базе
            }
        }

        private void UpdateMedicamentList()
        {
            MedicamentsList.Items.Clear();                  // очищаем список ларств

            foreach (var medicament in CurrentList)
            {
                MedicamentsList.Items.Add(medicament.Name); // переносим из базы в окно списка лекарств
            }
        }

        private void RestartMedicamentList()
        {
            MedicamentsList.Items.Clear();                  // очищаем список ларств

            if (Data.Medicaments.Count != 0)                 // если база не пуста
            {
                CurrentList = Data.Medicaments.ToList();    // копируем из базы в текущий список медикаментов

                MedicamentsList.Enabled = true;                 // делаем окно списка активным
                foreach (var medicament in CurrentList)
                {
                    MedicamentsList.Items.Add(medicament.Name); // переносим из базы в окно списка лекарств
                }

                UpdateCategoryList();           // обновляем список категорий

                Search.Enabled = true;          // становится доступна кнопка поиска
            }
            else
            {
                MedicamentsList.Enabled = false;            // иначе делаем окно списка лекарств неактивным
                MedicamentsList.Items.Add(DataBase.Empty);  // и добавляем надпись "пусто"

                Search.Enabled = false;          // становится недоступна кнопка поиска
            }
        }

        private void UpdateCategoryList()
        {
            Category.Enabled = true;                    // делаем окно категорий активным

            Category.Items.Clear();
            Category.Items.Add(DataBase.AllCategory);   // в самом начале добавляем надпись "Все"
            Category.Text = DataBase.AllCategory;       // и устанавливаем по умолчанию
            foreach (var category in Data.Category)
            {
                Category.Items.Add(category); // переносим из базы в окно списка категорий
            }
        }

        private void ResetMedicamentInformation()
        {
            // сброс дисплеев
            //Category.Text       = "";
            MedicamentName.Text = "";
            Dosage.Text         = "";
            CountOfDoses.Text   = "";
            DateOfIssue.Text    = "";
            ShelfLife.Text      = "";
            Purpose.Text        = "";
        }

        private void SetActiveMedicamentInformation(bool active)
        {
            // установка активности дисплеев
            //Category.Enabled        = active;
            MedicamentName.Enabled  = active;
            Dosage.Enabled          = active;
            CountOfDoses.Enabled    = active;
            DateOfIssue.Enabled     = active;
            ShelfLife.Enabled       = active;
            Purpose.Enabled         = active;
        }
    }
}
