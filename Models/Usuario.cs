using System.ComponentModel.DataAnnotations;

namespace MvcSqlMongoDemo.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}