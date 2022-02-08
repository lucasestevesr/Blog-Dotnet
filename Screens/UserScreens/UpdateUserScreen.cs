using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.UserScreens
{
    public static class UpdateUserScreen
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

            Update(new User
            {
                Id = int.Parse(id),
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

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
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