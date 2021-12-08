using RegistrationSystem.Controller;
using RegistrationSystem.Event;
using RegistrationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class MainMenuView : Form, IMainMenuView
	{
		public event EventHandler OnAddButtonCliked;
		public event EventHandler<int> OnDeleteButtonClicked;

		private readonly IReadableApplicationModel _applicationModel;

		public MainMenuView(IReadableApplicationModel applicationModel)
		{
			InitializeComponent();

			_applicationModel = applicationModel;
			_applicationModel.OnUserAdded += UserAdded;
			_applicationModel.OnUserDeleted += UserDeleted;
		}

		public void ShowSelectionMenu(string message, Action<bool> action)
		{
			var menu = new SelectionMenu(message);
			menu.ShowDialog(this);

			action?.Invoke(menu.CancelAct);
		}

		private void UserAdded(object sender, UserEventArgs e)
		{
			UserList.Items.Add(e.User);
			DeleteButton.Enabled = true;
		}

		private void UserDeleted(object sender, UserEventArgs e)
		{
			UserList.Items.RemoveAt(e.Index);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			OnAddButtonCliked?.Invoke(this, EventArgs.Empty);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			OnDeleteButtonClicked?.Invoke(this, UserList.SelectedIndex);
		}

		private void Open_Click(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{

		}

		private void UserList_SelectedIndexChanged(object sender, EventArgs e)
		{
			DeleteButton.Enabled = true;
		}
	}
}
