namespace BlogLucas.Screens.TagScreens
{
    public static class MenuBindPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag management");
            Console.WriteLine("--------------");
            Console.WriteLine("Options: ");
            Console.WriteLine();
            Console.WriteLine("1 - Bind Post Tag");
            Console.WriteLine("2 - Unbind Post Tag"); 
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BindPostTagScreen.Load();
                    break;
                case 2:
                    UnbindUserRoleScreen.Load();
                    break;              
                default: Load(); break;
            }
        }
    }

}