using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Domain.Models.Entities;
using KalleSoft.WorldData.Infrastructure.Interfeces;
using MongoDB.Driver;

namespace KalleSoft.WorldData.Infrastructure.Repository
{
    public class PeopleRepository : Repository<Person, string>, IPeopleRepository
    {
        public PeopleRepository(DataContext context) : base(context)
        {
        }
    }
}