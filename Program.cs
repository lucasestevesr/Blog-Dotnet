using System;
using BlogLucas.Models;
using BlogLucas.Repositories;
using BlogLucas.Screens.CategoryScreens;
using BlogLucas.Screens.RoleScreens;
using BlogLucas.Screens.TagScreens;
using BlogLucas.Screens.UserScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogLucas
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BlogLucas;User ID=sa;Password=Rkpzlx56!!;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("My Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("What option do you want?");
            Console.WriteLine();
            Console.WriteLine("1 - User management");
            Console.WriteLine("2 - Profile management");
            Console.WriteLine("3 - Category management");
            Console.WriteLine("4 - Tag management");
            Console.WriteLine("5 - Linker profile/user");
            Console.WriteLine("6 - Linker post/tag");
            Console.WriteLine("7 - Reports");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: 
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;                    
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }

        // public static void ReadUsersWithRoles(SqlConnection connection)
        // {
        //     var repository = new UserRepository(connection);
        //     var items = repository.GetWithRoles();

        //     foreach (var item in items)
        //     {
        //         Console.WriteLine(item.Name);
        //         foreach (var role in item.Roles)
        //         {
        //             Console.WriteLine($" - {role.Name}");
        //         }
        //     }

        // }

        // public static void ReadUsers(SqlConnection connection)
        // {
        //     var repository = new Repository<User>(connection);
        //     var users = repository.Get();

        //     foreach (var user in users)
        //     {
        //         Console.WriteLine(user.Name);
        //     }

        // }
        // public static void ReadRoles(SqlConnection connection)
        // {
        //     var repository = new Repository<Role>(connection);
        //     var roles = repository.Get();

        //     foreach (var role in roles)
        //         Console.WriteLine(role.Name);
        // }
        // public static void ReadTags(SqlConnection connection)
        // {
        //     var repository = new Repository<Tag>(connection);
        //     var tags = repository.Get();

        //     foreach (var tag in tags)
        //         Console.WriteLine(tag.Name);
        // }
        // public static void ReadCategorys(SqlConnection connection)
        // {
        //     var repository = new Repository<Category>(connection);
        //     var categories = repository.Get();

        //     foreach (var category in categories)
        //         Console.WriteLine(category.Name);
        // }
    }

}