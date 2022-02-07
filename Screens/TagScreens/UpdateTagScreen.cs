using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Updating a Tag: ");
            Console.WriteLine("-------------- ");            
            Console.WriteLine("Whats the Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();
            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug,
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag was sucessfull updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to update.");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

}