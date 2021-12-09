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
    public partial class AlertMenu : Form
    {
        public AlertMenu(string message)
        {
            // меню уведомлений
            InitializeComponent();
            Message.Text = message;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
