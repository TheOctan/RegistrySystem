using System;

namespace RegistrationSystem.Model.Data
{
	[Serializable]
	public class User
	{
		public string Surname;
		public string Name;
		public string Patronymic;

		public string Phone;
		public DateTime date;
	}
}
