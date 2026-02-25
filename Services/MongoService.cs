using MongoDB.Driver;
using MvcSqlMongoDemo.Models;

namespace MvcSqlMongoDemo.Services
{
    public class MongoService
    {
        private readonly IMongoCollection<RegistroAcceso> _registros;

        public MongoService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["MongoDbSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["MongoDbSettings:DatabaseName"]);

            _registros = database.GetCollection<RegistroAcceso>("RegistrosAcceso");
        }

        public async Task<List<RegistroAcceso>> GetRegistrosAsync()
        {
            return await _registros.Find(_ => true).ToListAsync();
        }

        public async Task CrearRegistroAsync(RegistroAcceso registro)
        {
            await _registros.InsertOneAsync(registro);
        }
    }
}