namespace MvcSqlMongoDemo.Models
{
    public class UsuarioAccesoViewModel
    {
        public List<Usuario> Usuarios { get; set; } = new();
        public List<RegistroAcceso> Registros { get; set; } = new();
    }
}