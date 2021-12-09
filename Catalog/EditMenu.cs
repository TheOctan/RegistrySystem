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
    public partial class EditMenu : Form
    {
        public bool IsEdit { get; private set; }
        private Medicament medicament;
        private SortedSet<string> categoryList;

        public EditMenu(SortedSet<string> category, Medicament medicament)
        {
            InitializeComponent();
            this.medicament = medicament;
            categoryList = category;
            IsEdit = false;


            foreach (var item in categoryList)
            {
                Category.Items.Add(item);
            }

            MedicamentName.Text = this.medicament.Name;
            Category.Text       = this.medicament.Category;
            Dosage.Value        = this.medicament.Dosage;
            CountOfDoses.Value  = this.medicament.CountOfDoses;
            Purpose.Text        = this.medicament.Purpose;
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string category = Category.Text;

            if (category.Length != 0)   // если строка не пуста
            {
                if (!Category.Items.Contains(category)) // если данная категория отсутсвтует
                {
                    Category.Items.Add(category);   // добавить в список
                    categoryList.Add(category);    // добавить в базу
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

            if (categoryList.Count != 0)      // если строка не пуста
            {
                Category.Items.Remove(category);    // удаляем из списка
                categoryList.Remove(category);     // удаляем из базы

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

        private void Edit_Click(object sender, EventArgs e)
        {
            // чтение данных
            string name         = MedicamentName.Text;
            string category     = Category.Text;
            int dosage          = Convert.ToInt32(Dosage.Value);
            int countOfDoses    = Convert.ToInt32(CountOfDoses.Value);
            string purpose      = Purpose.Text;

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

            if(isValid)  // если корректно
            {
                // редактируем медикамент
                medicament.Name         = name;
                medicament.Category     = category;
                medicament.Dosage       = dosage;
                medicament.CountOfDoses = countOfDoses;
                medicament.Purpose      = purpose;

                if (!Category.Items.Contains(category))     // если не добавили
                    categoryList.Add(Category.Text);        // добавляем категорию

                IsEdit = true;
                Hide();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MedicamentName_Click(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = Color.White;
        }

        private void Dosage_Click(object sender, EventArgs e)
        {
            (sender as NumericUpDown).BackColor = Color.White;
        }
    }
}
