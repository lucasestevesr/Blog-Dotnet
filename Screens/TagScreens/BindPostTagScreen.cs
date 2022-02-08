using BlogLucas.Models;
using BlogLucas.Repositories;

namespace BlogLucas.Screens.TagScreens
{
    public static class BindPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Bind Tag to Post: ");
            Console.WriteLine("-------------- ");

            Console.WriteLine("Type the Post Id.");
            var postId = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the Tag Id.");
            var tagId = int.Parse(Console.ReadLine());

            

            BindPostTag(postId, tagId);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void BindPostTag(int postId, int tagId)
        {
            try
            {
                var postRepository = new PostRepository(Database.Connection);
                postRepository.BindPostTag(postId,tagId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Not possible to bind.");
                Console.WriteLine($"{ex.Message}");
            }
        }

    }

}