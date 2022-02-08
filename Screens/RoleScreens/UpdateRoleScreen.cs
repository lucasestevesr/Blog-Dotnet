using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.RoleScreens
{
    public static class UpdateRoleScreen
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
            Update(new Role
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug,
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
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