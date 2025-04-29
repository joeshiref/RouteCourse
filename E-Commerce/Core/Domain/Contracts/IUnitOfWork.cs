using Domain.Entities;

namespace Domain.Contracts
{
    public interface IUnitOfWork
    {
        // Save Changes
        Task<int> SaveChangesAsync();
        // Signuture for function returns an instance of a class that implement IGenericRepo
        // new GenericRepo<Product,int>
        // new GenericRepo<ProductBrand,int>
        // new GenericRepo<ProductType,int>
        IGenericRepo<TEntity, Tkey> GetGenericRepo<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>;
    }
}
