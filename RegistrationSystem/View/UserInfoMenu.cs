using RegistrationSystem.Model.Data;
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
	public partial class UserInfoMenu : Form
	{
		public UserInfoMenu(User user)
		{
			InitializeComponent();

			surenameLabel.Text = user.Surname;
			nameLabel.Text = user.Name;
			patronymicLabel.Text = user.Patronymic;
			phoneLabel.Text = user.Phone;
			dateLabel.Text = user.Date.ToShortDateString();
		}
	}
}
