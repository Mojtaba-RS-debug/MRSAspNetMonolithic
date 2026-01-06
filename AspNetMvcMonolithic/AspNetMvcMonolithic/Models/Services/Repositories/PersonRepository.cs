using AspNetMvcMonolithic.Models.DomainModels.PersonAggregats;
using AspNetMvcMonolithic.Models.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcMonolithic.Models.Services.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ProjectDbContext _context;

        public PersonRepository(ProjectDbContext context)
        {
            _context=context;   
        }
        public async Task<IEnumerable<Person>> SelectAll()
        {
            //try
            //{
            //    return await _context.Persons.ToListAsync();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            return await _context.Persons.ToListAsync();
        }
    }
}
