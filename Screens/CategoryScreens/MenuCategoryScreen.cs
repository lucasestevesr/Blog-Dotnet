using System;

namespace BlogLucas.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category management");
            Console.WriteLine("--------------");
            Console.WriteLine("Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Categories");
            Console.WriteLine("2 - Register Category");
            Console.WriteLine("3 - Update Category");
            Console.WriteLine("4 - Delete Category");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }

}