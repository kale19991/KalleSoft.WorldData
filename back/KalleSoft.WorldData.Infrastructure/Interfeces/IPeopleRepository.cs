using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Domain.Models.Entities;

namespace KalleSoft.WorldData.Infrastructure.Interfeces
{
    public interface IPeopleRepository : IRepository<Person, string>
    {

    }
}