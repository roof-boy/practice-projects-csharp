using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginSystem.Functions
{
	internal class FileOperations
	{
		// Save the users to this file
		private static string filePath = "users.json";

		public static void SaveUsers(List<UserModel> users)
		{	
			// Serialize the list into a JSON file.
			string jsonString = JsonSerializer.Serialize(Program.users);
			File.WriteAllText(filePath, jsonString);
		}

		public static List<UserModel> LoadUsers()
		{
			if (!File.Exists(filePath))
			{
				return new List<UserModel>();
			}

			string jsonString = File.ReadAllText(filePath);
			return JsonSerializer.Deserialize<List<UserModel>>(jsonString);
		}

		public static void DeleteUsers()
		{
			File.Delete(filePath);
			Program.users.Clear();
			Console.Clear();
			Console.Write("User list has been deleted.");
		}
	}
}
