using RegistrationSystem.Model.Data;
using System.Collections.Generic;

namespace RegistrationSystem.Model
{
	public interface IApplicationModel
	{
		List<User> Users { get; }
	}
}
