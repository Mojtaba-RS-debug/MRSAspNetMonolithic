using AspNetMvcMonolithic.ApplicationService.Dtos;

namespace AspNetMvcMonolithic.ApplicationService.Services.Contracts
{
    public interface IProductApplicationService
    {
        Task<List<ProductGetDtoList>> GetAllProductsListAsync();
    }
}
