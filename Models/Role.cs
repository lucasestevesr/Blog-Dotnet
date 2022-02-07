using Dapper.Contrib.Extensions;

namespace BlogLucas.Models
{
    [Table("[Role]")]
    public class Role
    {        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? slug { get; set; }
        
    }
}