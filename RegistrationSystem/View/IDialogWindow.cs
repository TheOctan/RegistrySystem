using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public interface IDialogWindow
	{
		DialogResult ShowDialog();
		DialogResult ShowDialog(IWin32Window window);
	}
}
