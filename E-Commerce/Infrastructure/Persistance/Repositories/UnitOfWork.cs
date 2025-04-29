
namespace Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private ConcurrentDictionary<string,object> _repositories;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new();
        }
        public IGenericRepo<TEntity, Tkey> GetGenericRepo<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {
            return (GenericRepo<TEntity, Tkey>)_repositories.GetOrAdd(typeof(TEntity).Name, (_) => new GenericRepo<TEntity, Tkey>(_dbContext));
        }

        public async Task<int> SaveChangesAsync() // Complete the method
        {
            // Save changes to the database
            return await _dbContext.SaveChangesAsync();
        }
    }
}
