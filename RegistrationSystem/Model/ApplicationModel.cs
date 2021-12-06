using RegistrationSystem.Model.Data;
using System.Collections.Generic;

namespace RegistrationSystem.Model
{
	public class ApplicationModel : IApplicationModel
	{
		public List<User> Users { get; } = new List<User>();

		public ApplicationModel()
		{

		}
	}
}
