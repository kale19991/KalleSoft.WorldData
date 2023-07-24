using KalleSoft.WorldData.Domain.Models.Entities;
using MongoDB.Driver;

namespace KalleSoft.WorldData.Infrastructure
{
    public class DataContext
    {

        public IMongoCollection<Person> People { get; set; }
        public DataContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var dataBase = client.GetDatabase("WorldData");

            this.People = dataBase.GetCollection<Person>("People");
        }
    }
}