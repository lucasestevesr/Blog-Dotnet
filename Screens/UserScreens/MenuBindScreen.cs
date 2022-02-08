namespace BlogLucas.Screens.UserScreens
{
    public static class MenuBindScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User management");
            Console.WriteLine("--------------");
            Console.WriteLine("Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - Bind User Role");
            Console.WriteLine("2 - Unbind User Role"); 
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BindUserRoleScreen.Load();
                    break;
                case 2:
                    UnbindUserRoleScreen.Load();
                    break;              
                default: Load(); break;
            }
        }
    }

}