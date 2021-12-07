﻿using RegistrationSystem.Model;
using RegistrationSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Controller
{
	public class MainMenuController : IMainMenuController
	{
		private IApplicationModel _applicationModel;

		public MainMenuController(IApplicationModel applicationModel)
		{
			_applicationModel = applicationModel;
		}

		public void AddUser()
		{
			var addMenu = new AddMenu(new AddMenuController(_applicationModel));
			addMenu.ShowDialog();


		}
	}
}