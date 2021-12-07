using RegistrationSystem.Controller;
using RegistrationSystem.Model;
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
			ApplicationModel applicationModel = new ApplicationModel();
			MainMenuController mainMenuController = new MainMenuController(applicationModel);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu(mainMenuController));
		}
	}
}
