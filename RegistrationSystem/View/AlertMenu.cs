using System;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class AlertMenu : Form
    {
        public AlertMenu(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
