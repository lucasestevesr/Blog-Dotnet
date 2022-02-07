using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Updating a Category: ");
            Console.WriteLine("-------------- ");  
                      
            Console.WriteLine("Whats the Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();           

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine(); 

            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,                              
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("User was sucessfull updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to update.");
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

}