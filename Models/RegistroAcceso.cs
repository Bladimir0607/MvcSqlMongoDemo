using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MvcSqlMongoDemo.Models
{
    public class RegistroAcceso
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        public string UsuarioEmail { get; set; } = string.Empty;

        public DateTime FechaAcceso { get; set; }
    }
}