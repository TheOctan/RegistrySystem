using RegistrationSystem.Event;
using RegistrationSystem.Model;
using RegistrationSystem.View;

namespace RegistrationSystem.Controller
{
	public class AddMenuController : IAddMenuController
	{
		private readonly IApplicationModel _applicationModel;
		private readonly IAddMenuView _addMenuView;

		public AddMenuController(IApplicationModel applicationModel, IAddMenuView addMenuView)
		{
			_applicationModel = applicationModel;
			_addMenuView = addMenuView;

			_addMenuView.OnAddButtonClicked += OnUserAdded;
		}

		private void OnUserAdded(object sender, UserEventArgs e)
		{
			_applicationModel.AddUser(e.User);
		}
	}
}
