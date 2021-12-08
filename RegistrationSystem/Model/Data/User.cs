using System;

namespace RegistrationSystem.Model.Data
{
	[Serializable]
	public class User : IEquatable<User>
	{
		public string Surname;
		public string Name;
		public string Patronymic;

		public string Phone;
		public DateTime Date;

		public bool Equals(User other)
		{
			return Surname.Equals(other.Surname)
				&& Name.Equals(other.Name)
				&& Patronymic.Equals(other.Patronymic)
				&& Phone.Equals(other.Phone)
				&& Date.Equals(other.Date);
		}

		public override string ToString()
		{
			return $"{Surname} {Name} {Patronymic}";
		}
	}
}
