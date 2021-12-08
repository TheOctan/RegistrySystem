using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.View
{
	public interface IMainMenuView : IDialogWindow
	{
		event EventHandler OnAddButtonCliked;
		event EventHandler OnDeleteButtonClicked;
	}
}
