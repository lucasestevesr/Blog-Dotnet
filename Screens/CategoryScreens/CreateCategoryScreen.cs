using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Create new Category: ");
            Console.WriteLine("-------------- ");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
          
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine(); 

            Create(new Category
            {
                Name = name,                             
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Category was sucessfull created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to Create.");
                Console.WriteLine($"{ex.Message}");
            }
        }

    }

}