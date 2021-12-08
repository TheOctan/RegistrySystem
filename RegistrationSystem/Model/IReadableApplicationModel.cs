using System;
using System.Collections.Generic;
using RegistrationSystem.Event;
using RegistrationSystem.Model.Data;

namespace RegistrationSystem.Model
{
	public interface IReadableApplicationModel
	{
		event EventHandler<UserEventArgs> OnUserAdded;
		event EventHandler<UserEventArgs> OnUserDeleted;

		IEnumerable<User> Users { get; }

		bool IsValidPhone(string phone);
	}
}
