using AspNetMvcMonolithic.Models.DomainModels.PersonAggregats;

namespace AspNetMvcMonolithic.Models.Services.Contracts
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> SelectAll();
    }
}
