using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a Role: ");
            Console.WriteLine("-------------- ");
            Console.WriteLine("Whats the Id: ");
            var id = Console.ReadLine();
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag was sucessfull deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to delete.");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

}