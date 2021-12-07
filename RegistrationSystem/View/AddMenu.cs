using RegistrationSystem.Controller;
using RegistrationSystem.Model.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class AddMenu : Form
	{
		private const string ALERT_INVALID_PHONE_NUMBER = "Неверный формат номера\nтелефона в Беларуси";
		private const string ALERT_INVALID_DATE = "Дата записи не может быть\nраньше сегодняшнего дня";

		private IAddMenuController _addMenuController;

		public AddMenu(IAddMenuController addMenuController)
		{
			InitializeComponent();

			_addMenuController = addMenuController;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (ValidateUser(out var user))
			{
				_addMenuController.AddUser(user);
				Hide();
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private bool ValidateUser(out User user)
		{
			var surname = surnameTextBox.Text;
			var name = nameTextBox.Text;
			var patronymic = patronymicTextBox.Text;

			var phone = phoneTextBox.Text;
			var date = this.date.Value;

			bool isValidUser = true;

			if (surname.Length == 0)
			{
				surnameTextBox.BackColor = Color.Red;
				isValidUser = false;
			}
			if (name.Length == 0)
			{
				nameTextBox.BackColor = Color.Red;
				isValidUser = false;
			}
			if (patronymic.Length == 0)
			{
				patronymicTextBox.BackColor = Color.Red;
				isValidUser = false;
			}
			if (phone.Length == 0 || !_addMenuController.IsValidPhone(phone))
			{
				phoneTextBox.BackColor = Color.Red;
				isValidUser = false;

				ShowAlert(ALERT_INVALID_PHONE_NUMBER);
			}
			if (date < DateTime.Now)
			{
				ShowAlert(ALERT_INVALID_DATE);
			}

			if (isValidUser)
			{
				user = new User()
				{
					Surname = surname,
					Name = name,
					Patronymic = patronymic,
					Phone = phone,
					date = date
				};
			}
			else
			{
				user = null;
			}

			return isValidUser;
		}

		private void ShowAlert(string message)
		{
			AlertMenu alert = new AlertMenu(message);
			alert.Show(this);
		}

		private void SurnameTextBox_Click(object sender, EventArgs e)
		{
			(sender as TextBox).BackColor = Color.White;
		}

		private void NameTextBox_Click(object sender, EventArgs e)
		{
			(sender as TextBox).BackColor = Color.White;
		}

		private void PatronymicTextBox_Click(object sender, EventArgs e)
		{
			(sender as TextBox).BackColor = Color.White;
		}

		private void PhoneTextBox_Click(object sender, EventArgs e)
		{
			(sender as TextBox).BackColor = Color.White;
		}
	}
}
