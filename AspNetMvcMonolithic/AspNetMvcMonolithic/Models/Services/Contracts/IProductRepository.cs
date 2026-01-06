using AspNetMvcMonolithic.Models.DomainModels.ProductAggregats;

namespace AspNetMvcMonolithic.Models.Services.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> SelectAll();
    }
}
