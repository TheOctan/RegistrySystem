using RegistrationSystem.Model.Data;
using System;

namespace RegistrationSystem.Event
{
	public class UserEventArgs : EventArgs
	{
		public User User;
		public int Index;
	}
}
