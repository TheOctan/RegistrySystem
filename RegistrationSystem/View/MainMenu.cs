using RegistrationSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
	public partial class MainMenu : Form
	{
		private readonly IApplicationModel _applicationModel;

		public MainMenu(IApplicationModel applicationModel)
		{
			InitializeComponent();

			_applicationModel = applicationModel;
		}
	}
}
