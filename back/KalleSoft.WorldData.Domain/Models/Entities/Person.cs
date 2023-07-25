using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KalleSoft.WorldData.Domain.Models.Entities
{
    public class Person : Entity<string>
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}