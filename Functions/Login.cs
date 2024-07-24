using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Functions
{
	internal class Login
	{
		public static void LoginUser()
		{
			Console.Clear();

			string? Username = string.Empty;
			string? Password = string.Empty;

			if (Program.users.Count == 0)
			{
				Console.Clear();
				Console.WriteLine("No available users to login into.");
				Thread.Sleep(1000);
				return;
			}

			while (string.IsNullOrEmpty(Username))
			{
				// Get user input for the required Model fields.
				Console.Write("Enter username: ");
				Username = Console.ReadLine();
				if (string.IsNullOrEmpty(Username))
				{
					Console.Clear();
					Console.WriteLine("Username cannot be null.");
					Console.Clear();
				}
			}

			while (string.IsNullOrEmpty(Password))
			{
				Console.Write("Enter password: ");
				Password = Console.ReadLine();
				if (string.IsNullOrEmpty(Password))
				{
					Console.Clear();
					Console.WriteLine("Password cannot be null.");
					Console.Clear();
				}
			}

			UserModel foundUser = Program.users.Find(UserModel => UserModel.username == Username);

			if (foundUser == null)
			{
				Console.Clear();
				Console.WriteLine("Username or password is invalid.");
				Thread.Sleep(1000);
				return;
			}
			else if (foundUser.password != Password)
			{
				Console.Clear();
				Console.WriteLine("Username or password is invalid.");
				Thread.Sleep(1000);
				return;
			} else
			{
				Console.Clear();
				Console.WriteLine("Login successful!");
				Thread.Sleep(1000);
				return;
			}
		}
	}
}