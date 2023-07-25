using KalleSoft.WorldData.Domain.Models.Entities;
using MongoDB.Driver;

namespace KalleSoft.WorldData.Infrastructure
{
    public class DataContext
    {

        public IMongoDatabase Database { get; }
        public DataContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            Database = client.GetDatabase("WorldData");
        }
    }
}