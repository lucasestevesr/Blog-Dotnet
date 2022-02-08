using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.UserScreens
{
    public static class BindUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Bind Role to User: ");
            Console.WriteLine("-------------- ");

            Console.WriteLine("Type the user Id.");
            var userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the role Id.");
            var roleId = int.Parse(Console.ReadLine());

            

            BindUserRole(userId, roleId);
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void BindUserRole(int userId, int roleId)
        {
            try
            {
                var userRepository = new UserRepository(Database.Connection);
                userRepository.BindUserRole(userId,roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to bind.");
                Console.WriteLine($"{ex.Message}");
            }
        }

    }

}