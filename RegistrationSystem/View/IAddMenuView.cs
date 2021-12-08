using RegistrationSystem.Event;
using System;

namespace RegistrationSystem.View
{
	public interface IAddMenuView : IDialogWindow
	{
		event EventHandler<UserEventArgs> OnAddButtonClicked;
	}
}