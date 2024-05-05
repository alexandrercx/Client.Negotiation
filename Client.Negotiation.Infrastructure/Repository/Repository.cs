using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Client.Negotiation.Domain.Interface.Repository;

namespace Client.Negotiation.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly Context.AppContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(Context.AppContext appContext)
        {
            Db = appContext;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            DbSet.Update(entity);
            return entity;
        }

        public IDbContextTransaction BeginTransaction()
        {
            return Db.Database.BeginTransaction();
        }

        public bool Commit()
        {
            return Db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            Db.Dispose();
        }

      
    }
}
