using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Functions
{
	internal class ShowUsers
	{
		public static void ShowUserList()
		{
			Console.Clear();

			foreach (var UserModel in Program.users)
			{
				Console.WriteLine($"Username: {UserModel.username} ");
				Console.WriteLine($"Password: {UserModel.password}");
				Console.WriteLine("");
			}
		
			Console.WriteLine("Press any key to return to menu...");
			Console.ReadKey();
		}
	}
}
