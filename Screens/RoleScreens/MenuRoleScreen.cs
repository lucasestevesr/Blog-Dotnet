using System;

namespace BlogLucas.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User management");
            Console.WriteLine("--------------");
            Console.WriteLine("Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Role");
            Console.WriteLine("2 - Register Role");
            Console.WriteLine("3 - Update Role");
            Console.WriteLine("4 - Delete Role");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }

}