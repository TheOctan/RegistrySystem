using RegistrationSystem.SaveModule.Serialization;
using RegistrationSystem.Event;
using RegistrationSystem.Model.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace RegistrationSystem.Model
{
	public class ApplicationModel : IApplicationModel
	{
		private const string PHONE_NUMBER_PATTERN = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";

		public event EventHandler<UserEventArgs> OnUserAdded;
		public event EventHandler<UserEventArgs> OnUserDeleted;
		public event EventHandler<IEnumerable<User>> OnUsersOpened;
		public event EventHandler OnUsersSaved;
		public event EventHandler OnUsersEdited;

		public IEnumerable<User> Users => users;
		public bool UsersMustSave => DataEdited || (!string.IsNullOrEmpty(LastSavePath) && !File.Exists(LastSavePath));
		public string LastSavePath { get; private set; }
		public bool DataEdited { get; private set; }
		private int LastIndex => users.Count - 1;


		private List<User> users = new List<User>();
		private readonly ISerializationFileSystem _serializationFileSystem;

		public ApplicationModel(ISerializationFileSystem serializationFileSystem)
		{
			_serializationFileSystem = serializationFileSystem;
		}

		public void AddUser(User user)
		{
			users.Add(user);
			var index = LastIndex;

			DataEdited = true;
			OnUsersEdited?.Invoke(this, EventArgs.Empty);
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

				DataEdited = true;
				OnUsersEdited?.Invoke(this, EventArgs.Empty);
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

				DataEdited = true;
				OnUsersEdited?.Invoke(this, EventArgs.Empty);
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

		public void SaveUsers(string path, Action<string> onError = null)
		{
			try
			{
				if (_serializationFileSystem.SerializeObject(users, path))
				{
					LastSavePath = path;
					DataEdited = false;
					OnUsersSaved?.Invoke(this, EventArgs.Empty);
				}
			}
			catch (Exception e)
			{
				onError?.Invoke(e.Message);
			}
		}

		public void LoadUsers(string path, Action<string> onError = null)
		{
			DataEdited = false;

			try
			{
				users = _serializationFileSystem.DeserializeObject<List<User>>(path);
				DataEdited = false;
				OnUsersOpened?.Invoke(this, users);
			}
			catch (InvalidCastException e)
			{
				onError?.Invoke(e.Message);
			}
			catch
			{
				onError?.Invoke($"Failed to load file from\n{path}");
			}
		}
	}
}
