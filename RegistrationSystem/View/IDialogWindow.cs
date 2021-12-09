using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public interface IDialogWindow
	{
		DialogResult ShowDialog();
		DialogResult ShowDialog(IWin32Window window);
	}
}
