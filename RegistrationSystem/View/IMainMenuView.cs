using System;

namespace RegistrationSystem.View
{
	public interface IMainMenuView : IDialogWindow
	{
		event EventHandler OnAddButtonCliked;
		event EventHandler<int> OnDeleteButtonClicked;
		event EventHandler<string> OnLoadUsers;
		event EventHandler<string> OnSaveUsers;

		void ShowSelectionMenu(string message, Action<bool> action);
		void ShowAlert(string message);
	}
}
