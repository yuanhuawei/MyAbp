using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CardCloud.EntityFramework.Repositories
{
    public abstract class CardCloudRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CardCloudDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CardCloudRepositoryBase(IDbContextProvider<CardCloudDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CardCloudRepositoryBase<TEntity> : CardCloudRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CardCloudRepositoryBase(IDbContextProvider<CardCloudDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
