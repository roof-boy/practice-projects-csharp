using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
	internal class UserModel
	{
		public string username {  get; set; }
		public string password { get; set; }

		public UserModel(string Username, string Password)
		{
			username = Username;
			password = Password;
		}
	}
}
