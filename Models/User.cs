using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace BlogLucas.Models
{
    [Table("[User]")]
    public class User
    {
        public User() => Roles = new List<Role>(); //Relacionamento UserRoles

        [Key] 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? Bio { get; set; }
        public string? Image { get; set; }
        public string? Slug { get; set; }

        [Write(false)]  // Para não incluir os perfis na hora de salvar
        public List<Role> Roles { get; set; } //Relacionamento UserRoles
    }
}