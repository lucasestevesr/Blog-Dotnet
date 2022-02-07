using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a Tag: ");
            Console.WriteLine("-------------- ");
            Console.WriteLine("Whats the Id: ");
            var id = Console.ReadLine();
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
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