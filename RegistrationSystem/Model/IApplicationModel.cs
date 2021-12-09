using RegistrationSystem.Model.Data;
using System;

namespace RegistrationSystem.Model
{
	public interface IApplicationModel : IReadableApplicationModel
	{
		void AddUser(User user);
		bool DeleteUser(int index);
		bool DeleteUser(User user);

		void SaveUsers(string path, Action<string> onError);
		void LoadUsers(string path, Action<string> onError);
	}
}
