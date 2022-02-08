using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Create new User: ");
            Console.WriteLine("-------------- ");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine(); 

            Console.WriteLine("Password: ");
            var passwordHash = Console.ReadLine(); 

            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine(); 

            Console.WriteLine("Image link: ");
            var img = Console.ReadLine(); 

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine(); 

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = img,                
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("User was sucessfull created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to Create.");
                Console.WriteLine($"{ex.Message}");
            }
        }

    }

}