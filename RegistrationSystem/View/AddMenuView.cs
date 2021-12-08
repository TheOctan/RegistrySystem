using RegistrationSystem.Event;
using RegistrationSystem.Model;
using RegistrationSystem.Model.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class AddMenuView : Form, IAddMenuView
	{
		private const string ALERT_INVALID_PHONE_NUMBER = "Неверный формат номера\nтелефона в Беларуси";
		private const string ALERT_INVALID_DATE = "Дата записи не может быть\nраньше сегодняшнего дня";

		public event EventHandler<UserEventArgs> OnAddButtonClicked;

		private readonly IReadableApplicationModel _applicationModel;

		public AddMenuView(IReadableApplicationModel applicationModel)
		{
			InitializeComponent();

			_applicationModel = applicationModel;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			User user = GetUser();

			if (user != null)
			{
				OnAddButtonClicked?.Invoke(this, new UserEventArgs()
				{
					User = user
				});
				Hide();
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private bool IsValidInput()
		{
			bool isValidInput = true;

			if (surnameTextBox.Text.Length == 0)
			{
				surnameTextBox.BackColor = Color.Red;
				isValidInput = false;
			}
			if (nameTextBox.Text.Length == 0)
			{
				nameTextBox.BackColor = Color.Red;
				isValidInput = false;
			}
			if (patronymicTextBox.Text.Length == 0)
			{
				patronymicTextBox.BackColor = Color.Red;
				isValidInput = false;
			}

			var phone = phoneTextBox.Text;
			if (phone.Length == 0 || !_applicationModel.IsValidPhone(phone))
			{
				phoneTextBox.BackColor = Color.Red;
				isValidInput = false;

				ShowAlert(ALERT_INVALID_PHONE_NUMBER);
			}
			if (date.Value <= DateTime.Now)
			{
				ShowAlert(ALERT_INVALID_DATE);
			}

			return isValidInput;
		}

		private User GetUser()
		{
			if (IsValidInput())
			{
				return new User()
				{
					Surname = surnameTextBox.Text,
					Name = nameTextBox.Text,
					Patronymic = patronymicTextBox.Text,
					Phone = phoneTextBox.Text,
					Date = date.Value
				};
			}

			return null;
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
