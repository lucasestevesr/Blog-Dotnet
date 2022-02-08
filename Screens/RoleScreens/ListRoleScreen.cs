using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of Roles: ");
            Console.WriteLine("-------------- ");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();

            foreach (var role in roles)
                Console.WriteLine($"{role.Id} - {role.Name} ({role.Slug})");            
        }
    }

}