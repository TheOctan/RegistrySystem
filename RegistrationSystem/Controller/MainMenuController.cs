using RegistrationSystem.Model;
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
		private const string DELETE_USER_ALERT = "Вы уверены,\nчто хотиту удалить запись?";

		private readonly IApplicationModel _applicationModel;
		private readonly IMainMenuView _mainMenuView;
		private readonly IAddMenuView _addMenuView;

		public MainMenuController(IApplicationModel applicationModel,
			IMainMenuView mainMenuView,
			IAddMenuView addMenuView)
		{
			_applicationModel = applicationModel;
			_mainMenuView = mainMenuView;
			_addMenuView = addMenuView;

			_mainMenuView.OnAddButtonCliked += OnUserAdded;
			_mainMenuView.OnDeleteButtonClicked += OnUserDeleted;
			_mainMenuView.OnLoadUsers += OnLoadUsers;
			_mainMenuView.OnSaveUsers += OnSaveUsers;
		}

		private void OnUserAdded(object sender, EventArgs e)
		{
			_addMenuView.ShowDialog();
		}

		private void OnUserDeleted(object sender, int index)
		{
			_mainMenuView.ShowSelectionMenu(DELETE_USER_ALERT, (cancel) =>
			{
				if (!cancel)
				{
					_applicationModel.DeleteUser(index);
				}
			});
		}
		private void OnLoadUsers(object sender, string path)
		{
			_applicationModel.LoadUsers(path, _mainMenuView.ShowAlert);
		}

		private void OnSaveUsers(object sender, string path)
		{
			_applicationModel.SaveUsers(path, _mainMenuView.ShowAlert);
		}
	}
}
