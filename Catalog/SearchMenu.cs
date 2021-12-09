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
    public partial class SearchMenu : Form
    {
        public bool IsSearch { get; private set; }
        public DataBase Data { get; private set; }
        public List<Medicament> CurrentList { get; private set; }

        public SearchMenu(DataBase data)
        {
            InitializeComponent();

            Data = data;

            Category.Items.Add(DataBase.AllCategory);   // в самом начале добавляем надпись "Все"
            foreach (var category in Data.Category)
            {
                Category.Items.Add(category);
            }

            IsSearch = false;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            CurrentList = Data.Medicaments.Where(
                medicament =>
                (MedicamentName.Text == "" ? true : medicament.Name.Contains(MedicamentName.Text)) &&
                ((Category.Text == "" || Category.Text == DataBase.AllCategory) ? true : medicament.Category == Category.Text) &&
                (Dosage.Value == 0 ? true : medicament.Dosage == Dosage.Value) &&
                (!ShelfLife.Enabled ? true : medicament.ShelfLife <= ShelfLife.Value)
                ).ToList();

            IsSearch = true;
            Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShelfLife.Enabled = checkBox1.Checked;
        }
    }
}
