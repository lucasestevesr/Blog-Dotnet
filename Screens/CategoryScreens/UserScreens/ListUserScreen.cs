using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of Users: ");
            Console.WriteLine("-------------- ");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();

            foreach (var user in users)
                Console.WriteLine($"{user.Id} - {user.Name} ({user.Email})");            
        }
    }

}