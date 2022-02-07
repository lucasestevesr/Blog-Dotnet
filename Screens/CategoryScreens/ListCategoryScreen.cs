using System;
using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of Categories: ");
            Console.WriteLine("-------------- ");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();

            foreach (var category in categories)
                Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");            
        }
    }

}