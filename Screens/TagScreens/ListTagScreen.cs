using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Tags: ");
            Console.WriteLine("-------------- ");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();

            foreach (var tag in tags)
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");            
        }
    }

}