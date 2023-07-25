using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Application.Interfaces;
using KalleSoft.WorldData.Application.Services;
using KalleSoft.WorldData.Infrastructure;
using KalleSoft.WorldData.Infrastructure.Interfeces;
using KalleSoft.WorldData.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace KalleSoft.WorldData.Core.Dependencys
{
    public static class MainConfiguration
    {
        public static void AddProject(this IServiceCollection service)
        {
            #region Application
            service.AddScoped<IPeopleService, PeopleService>();
            #endregion
            #region Infrastructure
            service.AddSingleton(new DataContext("mongodb://localhost:27017", "WorldData"));
            service.AddScoped<IPeopleRepository, PeopleRepository>();
            #endregion
        }
    }
}