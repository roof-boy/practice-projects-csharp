using LoginSystem.Functions;

namespace LoginSystem
{
	internal class Program
	{
		// Static list to store users
		public static List<UserModel> users = new List<UserModel>();
		static void Main(string[] args)
		{
			users = FileOperations.LoadUsers();

			Menu.ShowMenu();
		}
	}
}
