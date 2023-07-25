using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Application.Interfaces;
using KalleSoft.WorldData.Domain.Models.Entities;
using KalleSoft.WorldData.Infrastructure.Interfeces;

namespace KalleSoft.WorldData.Application.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _repository;
        public PeopleService(IPeopleRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<Person> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> InsertAsync(Person entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public Task<Person> UpdateAsync(Person entity, string id)
        {
            throw new NotImplementedException();
        }
    }
}