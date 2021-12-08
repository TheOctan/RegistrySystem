using RegistrationSystem.Event;
using RegistrationSystem.Model.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegistrationSystem.Model
{
	public class ApplicationModel : IApplicationModel
	{
		private const string PHONE_NUMBER_PATTERN = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";

		public event EventHandler<UserEventArgs> OnUserAdded;
		public event EventHandler<UserEventArgs> OnUserDeleted;
		public IEnumerable<User> Users => users;
		private int LastIndex => users.Count - 1;

		private readonly List<User> users = new List<User>();

		public void AddUser(User user)
		{
			users.Add(user);
			var index = LastIndex;

			OnUserAdded?.Invoke(this, new UserEventArgs()
			{
				User = user,
				Index = index
			});
		}

		public bool DeleteUser(int index)
		{
			if (IsValidRange(index))
			{
				var user = users[index];
				users.RemoveAt(index);

				OnUserDeleted?.Invoke(this, new UserEventArgs()
				{
					User = user,
					Index = index
				});

				return true;
			}

			return false;
		}

		public bool DeleteUser(User user)
		{
			if (HasUser(user))
			{
				var index = LastIndex;
				users.Remove(user);

				OnUserDeleted?.Invoke(this, new UserEventArgs()
				{
					User = user,
					Index = index
				});

				return true;
			}
			else
			{
				return false;
			}
		}

		public User GetUserByIndex(int index)
		{
			if (IsValidRange(index))
			{
				return users[index];
			}

			return null;
		}

		public bool HasUser(User user)
		{
			return users.Contains(user);
		}

		public bool IsValidPhone(string phone)
		{
			return Regex.IsMatch(phone, PHONE_NUMBER_PATTERN);
		}

		private bool IsValidRange(int index)
		{
			return index >= 0 && index <= LastIndex;
		}
	}
}
