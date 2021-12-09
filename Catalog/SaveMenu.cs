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
    public partial class SaveMenu : Form
    {
        public DataBase Data { get; private set; }
        public bool CancelAct { get; private set; }
        public bool IsSave { get; private set; }

        public SaveMenu(DataBase data)
        {
            InitializeComponent();
            Data = data;
            CancelAct = false;          // по умолчанию не отменяем операцию следующую за текущей
            IsSave = false;             // по умолчанию не сохраняем
            if(Data.FileName == "")     // если текущий файл сохранения отсутсвует
            {
                Message.Text += "?";    // просто спрашиваем о сохранении текщих изменений
            }
            else
            {
                Message.Text += "\nв файле ?";    // иначе спрашиваем о сохранении текщего файла
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // сохраняем и выходим

            if (Data.FileName == "" || !File.Exists(Data.FileName))        // если текущий файл сохранения отсутсвует в базе или на диске
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)    // выбираем новый
                {
                    Data.FileName = saveFileDialog1.FileName;       // устанавливаем рабочий файл

                    Data.RecordToFile(Data.FileName);               // сохраняем базу в файл
                    IsSave = true;                                  // помечаем сохранение
                }
                else                                                // если всё же не выбрали файл для созранения
                {
                    CancelAct = true;                               // то отменяем операцию
                }
            }
            else
            {
                Data.RecordToFile(Data.FileName);                   // сохраняем базу в файл
                IsSave = true;                                      // помечаем сохранение
            }

            Hide();
        }

        private void NotSave_Click(object sender, EventArgs e)
        {
            // не сохраняем
            Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelAct = true;   // не сохраняем и отменяем операцию
            Hide();
        }
    }
}
