using AspNetMvcMonolithic.ApplicationService.Dtos;

namespace AspNetMvcMonolithic.ApplicationService.Services.Contracts
{
    public interface IPersonApplicationService
    {
        Task<List<PersonGetDtoList>> GetAllPersonListAsync();
    }
}
