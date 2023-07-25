using KalleSoft.WorldData.Domain.Models.Entities;
using KalleSoft.WorldData.Infrastructure.Interfeces;
using MongoDB.Driver;

namespace KalleSoft.WorldData.Infrastructure.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : Entity<TKey>
        where TKey : IComparable
    {
        public IMongoCollection<TEntity> Collection { get; set; }

        public Repository(DataContext context)
        {
            this.Collection = context.Database.GetCollection<TEntity>(typeof(TEntity).Name);


        }
        public virtual async Task<bool> DeleteAsync(TKey id)
        {
            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter
                .Eq(x => x.Id, id);

            var result = await this.Collection.DeleteOneAsync(
                filter: filter
            );

            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await this.Collection.Find(x => true).ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(TEntity entity, TKey id)
        {
            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter
                .Eq(x => x.Id, id);
            return await this.Collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            await this.Collection.InsertOneAsync(entity);
            return entity;

        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, TKey id)
        {
            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter
                .Eq(x => x.Id, id);

            var result = await this.Collection.ReplaceOneAsync(
                filter: filter, replacement: entity
            );

            if (result.IsAcknowledged && result.ModifiedCount > 0)
                return entity;
            else
                throw new Exception("Error: not found");
        }
    }
}