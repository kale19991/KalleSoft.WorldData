using KalleSoft.WorldData.Domain.Models.Entities;
using MongoDB.Driver;

namespace KalleSoft.WorldData.Infrastructure
{
    public class DataContext
    {

        public IMongoDatabase Database { get; }
        public DataContext(string connectionString, string dataBase)
        {
            var client = new MongoClient(connectionString);

            Database = client.GetDatabase(dataBase);
        }
    }
}