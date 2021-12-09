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
		event EventHandler<IEnumerable<User>> OnUsersOpened;
		event EventHandler OnUsersSaved;
		event EventHandler OnUsersEdited;

		IEnumerable<User> Users { get; }
		string LastSavePath { get; }
		bool UsersMustSave { get; }
		bool DataEdited { get; }

		bool IsValidPhone(string phone);
		bool HasUser(User user);
		User GetUserByIndex(int index);
	}
}
