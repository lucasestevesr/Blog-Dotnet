using Dapper.Contrib.Extensions;

namespace BlogLucas.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category(List<Post> posts) => Posts = posts;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }
       
    }
}