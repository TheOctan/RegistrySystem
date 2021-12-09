using System;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class SaveMenu : Form
    {
		public bool CancelAct { get; private set; }
		public bool IsSave { get; private set; }

		public SaveMenu()
		{
			InitializeComponent();

			CancelAct = false;
			IsSave = false;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			IsSave = true;

			Hide();
		}

		private void NotSave_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			CancelAct = true;
			Hide();
		}
	}
}
