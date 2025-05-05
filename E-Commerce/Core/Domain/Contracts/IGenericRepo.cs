using Domain.Entities;

namespace Domain.Contracts
{
    public interface IGenericRepo<TEntity,Tkey> where TEntity : BaseEntity<Tkey>
    {
        Task<TEntity?> GetByIdAsync(Tkey id);
        Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking=false);

        Task<TEntity?> GetByIdAsync(Specifications<TEntity>specifications);
        Task<IEnumerable<TEntity>> GetAllAsync(Specifications<TEntity> specifications);
        Task AddAsync(TEntity entity);

        void Update(TEntity entity);
        void Delete(TEntity entity);



    }
}
