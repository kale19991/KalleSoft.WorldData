using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleSoft.WorldData.Domain.Models.Entities
{
    public class Address //: Entity<string>
    {
        public string Streep { get; set; }
        public string? Note { get; set; }
        public string PersonId { get; set; }
    }
}