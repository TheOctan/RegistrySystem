using RegistrationSystem.Model.Data;

namespace RegistrationSystem.Model
{
	public interface IApplicationModel : IReadableApplicationModel
	{
		void AddUser(User user);
		bool DeleteUser(User user);
		bool HasUser(User user);
		User GetUserByIndex(int index);
	}
}
