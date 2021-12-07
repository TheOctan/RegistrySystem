﻿using RegistrationSystem.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Controller
{
	public interface IAddMenuController
	{
		event EventHandler<User> UserAdded;

		void AddUser(User user);
		bool IsValidPhone(string phone);
	}
}