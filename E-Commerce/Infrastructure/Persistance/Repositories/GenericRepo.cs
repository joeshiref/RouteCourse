using Domain.Contracts;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class GenericRepo<TEntity, Tkey> : IGenericRepo<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        private readonly AppDbContext _dbContext;

        public GenericRepo(AppDbContext dbContext )
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(TEntity entity) => await _dbContext.Set<TEntity>().AddAsync(entity);

        public void Delete(TEntity entity) => _dbContext.Set<TEntity>().Remove(entity);
        public void Update(TEntity entity) => _dbContext.Set<TEntity>().Update(entity);

        public async Task<TEntity?> GetByIdAsync(Tkey id) => await _dbContext.Set<TEntity>().FindAsync(id);
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking) => !asNoTracking ?
            await _dbContext.Set<TEntity>().ToListAsync() : await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(Specifications<TEntity> specifications) => await ApplySpecifications(specifications).FirstOrDefaultAsync();
        public async Task<IEnumerable<TEntity>> GetAllAsync(Specifications<TEntity> specifications) => await ApplySpecifications(specifications).ToListAsync();

        private IQueryable<TEntity> ApplySpecifications(Specifications<TEntity> specifications) => SpecificationEvalutor.GetQuery<TEntity>(_dbContext.Set<TEntity>(), specifications);

        public async Task<int> CountAsync(Specifications<TEntity> specifications) => await ApplySpecifications(specifications).CountAsync();
    }
}
