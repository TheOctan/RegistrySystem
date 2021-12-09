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
    public partial class SelectionMenu : Form
    {
        public bool CancelAct { get; private set; }

        public SelectionMenu(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            CancelAct = false;
            Hide();
        }

        private void No_Click(object sender, EventArgs e)
        {
            CancelAct = true;
            Hide();
        }
    }
}
