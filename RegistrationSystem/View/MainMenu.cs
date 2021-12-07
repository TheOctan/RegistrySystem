using RegistrationSystem.Controller;
using RegistrationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
	public partial class MainMenu : Form
	{
		private readonly IMainMenuController _mainMenuController;

		public MainMenu(IMainMenuController mainMenuController)
		{
			InitializeComponent();

			_mainMenuController = mainMenuController;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			_mainMenuController.AddUser();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			//_mainMenuController.DeleteUser();
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			// _mainMenuController.EditItem();
		}

		private void Find_Click(object sender, EventArgs e)
		{
			
		}

		private void Open_Click(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{

		}
	}
}
