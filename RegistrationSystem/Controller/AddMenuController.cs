using RegistrationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Controller
{
	public class AddMenuController : IAddMenuController
	{
		private IApplicationModel _applicationModel;

		public AddMenuController(IApplicationModel applicationModel)
		{
			_applicationModel = applicationModel;
		}
	}
}
