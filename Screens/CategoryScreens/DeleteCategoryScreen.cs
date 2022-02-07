using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a Category: ");
            Console.WriteLine("-------------- ");
            Console.WriteLine("Whats the Id: ");
            var id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
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