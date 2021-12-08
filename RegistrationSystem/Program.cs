using RegistrationSystem.Controller;
using RegistrationSystem.Model;
using RegistrationSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var applicationModel = new ApplicationModel();
			var mainMenuView = new MainMenuView(applicationModel);
			var addMenu = new AddMenuView(applicationModel);

			var addMenuController = new AddMenuController(applicationModel, addMenu);
			var mainMenuController = new MainMenuController(applicationModel, mainMenuView, addMenu);
			Application.Run(mainMenuView);
		}
	}
}
