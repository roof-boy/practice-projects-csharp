using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LoginSystem.Functions
{
	internal class AddUser
	{
		// Regex check for only numbers or characters.
		static bool IsOnlyNumbersOrSpecialCharacters(string Password)
		{
			// Regular expression to match strings that contain only digits or special characters.
			string pattern = @"^[\d\W]+$";
			return Regex.IsMatch(Password, pattern);
		}

		public static void AddUserToList()
		{
			Console.Clear();

			string? Username = string.Empty; // Non nullable.
			string? Password = string.Empty; // Non nullable.

			bool validPass = false;

			while (string.IsNullOrEmpty(Username))
			{
				// Get user input for the required Model fields.
				Console.Write("Enter username: ");
				Username = Console.ReadLine();
				// Check if username string is empty.
				if (string.IsNullOrEmpty(Username))
				{
					Console.Clear();
					Console.WriteLine("Username cannot be null.");
					Console.Clear();
				}
			}

			// Try to find the username in the current list of users.
			UserModel foundUser = Program.users.Find(UserModel => UserModel.username == Username);

			// If the username is found return to the user that this username already exists
			if (foundUser != null)
			{
				Console.WriteLine("Username already exists. Please pick another one.");
				Thread.Sleep(1000);
				Functions.AddUser.AddUserToList();
			}

			Console.Clear();
			while (string.IsNullOrEmpty(Password) || validPass == false)
			{
				Console.Write("Enter password: ");
				Password = Console.ReadLine();
				// Check if password string is empty
				if (string.IsNullOrEmpty(Password)) 
				{
					Console.Clear();
					Console.WriteLine("Password cannot be null.");
					Thread.Sleep(500);
					Console.Clear();
				}
				// Check for spaces in password or if password only contains numbers or special characters
				if (Password.Contains(" ") || IsOnlyNumbersOrSpecialCharacters(Password)) 
				{
					Console.Clear();
					Console.WriteLine("Password cannot contain spaces, numbers only or special characters only!");
					Thread.Sleep(500);
					Console.Clear();
					validPass = false;
				} else
				{
					validPass = true;
				}
			}
			

			// Create new user object
			UserModel newUser = new UserModel(Username, Password);

			// Add the new user to the list
			Program.users.Add(newUser);

			// Display a confirmation to the user that their account has been added to the list.
			Console.Clear();
			Console.Write("User has been successfully added to the user list.");

			Thread.Sleep(1000);
		}
	}
}
