using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleSoft.WorldData.Domain.Models.Entities
{
    public class Person : Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}