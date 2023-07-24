using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KalleSoft.WorldData.Domain.Models.Entities
{
    public class Entity<TKey> where TKey : IComparable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required TKey Id { get; set; }
    }
}