using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a User: ");
            Console.WriteLine("-------------- ");
            Console.WriteLine("Whats the Id: ");
            var id = Console.ReadLine();
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("User was sucessfull deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to delete.");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

}