using RegistrationSystem.Controller;
using RegistrationSystem.Model;
using RegistrationSystem.SaveModule.Serialization.Format;
using RegistrationSystem.View;
using System;
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

			var serializationSystem = new JsonSerializationSystem();
			var applicationModel = new ApplicationModel(serializationSystem);
			var mainMenuView = new MainMenuView(applicationModel);
			var addMenu = new AddMenuView(applicationModel);

			var addMenuController = new AddMenuController(applicationModel, addMenu);
			var mainMenuController = new MainMenuController(applicationModel, mainMenuView, addMenu);
			Application.Run(mainMenuView);
		}
	}
}
