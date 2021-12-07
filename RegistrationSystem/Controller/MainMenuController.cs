using RegistrationSystem.Model;
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
			throw new NotImplementedException();
		}
	}
}
