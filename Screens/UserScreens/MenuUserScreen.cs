namespace BlogLucas.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User management");
            Console.WriteLine("--------------");
            Console.WriteLine("Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Users");
            Console.WriteLine("2 - Register User");
            Console.WriteLine("3 - Update User");
            Console.WriteLine("4 - Delete User");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }

}