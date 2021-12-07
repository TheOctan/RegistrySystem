using RegistrationSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class AddMenu : Form
	{
		private IAddMenuController _addMenuController;

		public AddMenu(IAddMenuController addMenuController)
		{
			InitializeComponent();

			_addMenuController = addMenuController;
		}
	}
}
