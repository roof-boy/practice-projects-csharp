using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Functions
{
	internal class Menu
	{
		public static void ShowMenu()
		{
			bool exit = false;
			int choice = 0;

			while (exit == false)
			{
				List<UserModel> users = new List<UserModel>();

				Console.Clear();

				Console.WriteLine("Please choose below:");
				Console.WriteLine("");
				Console.WriteLine("1. Register new user");
				Console.WriteLine("2. Login");
				Console.WriteLine("3. View users");
				Console.WriteLine("4. Delete User List");
				Console.WriteLine("5. Exit");
				Console.WriteLine("");
				Console.Write("Selection: ");

				// Try to parse the user input. If invalid, enter default case
				int.TryParse(Console.ReadLine(), out choice);

				switch (choice)
				{
					case 1:
						AddUser.AddUserToList();
						break;
					case 2:
						Login.LoginUser();
						break;
					case 3:
						ShowUsers.ShowUserList();
						break;
					case 4:
						FileOperations.DeleteUsers();
						break;
					case 5:
						exit = true;
						Console.Clear();
						Console.Write("Exiting...");
						FileOperations.SaveUsers(users);
						Thread.Sleep(1000);
						break;
					default:
						Console.Clear();
						Console.WriteLine("Invalid selection. Please try again.");
						Thread.Sleep(500);
						break;
				}
			}
		}
	}
}
