using System;

namespace RegistrationSystem.Model.Data
{
	[Serializable]
	public struct User
	{
		public string Surname;
		public string Name;
		public string Patronymic;

		public string Phone;
		public DateTime date;
	}
}
