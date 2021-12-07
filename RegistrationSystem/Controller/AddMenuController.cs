using RegistrationSystem.Model;
using RegistrationSystem.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationSystem.Controller
{
	public class AddMenuController : IAddMenuController
	{
		private const string PHONE_NUMBER_PATTERN = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";

		public event EventHandler<User> UserAdded;
		private IApplicationModel _applicationModel;

		public AddMenuController(IApplicationModel applicationModel)
		{
			_applicationModel = applicationModel;
		}

		public void AddUser(User user)
		{
			_applicationModel.Users.Add(user);
			UserAdded?.Invoke(this, user);
		}

		public bool IsValidPhone(string phone)
		{
			return Regex.IsMatch(phone, PHONE_NUMBER_PATTERN);
		}
	}
}
