using AspNetMvcMonolithic.Models.DomainModels.ProductAggregats;
using AspNetMvcMonolithic.Models.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcMonolithic.Models.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProjectDbContext _context;

        public ProductRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> SelectAll()
        {
            try
            {
                var projectDbContext = _context.Product.Include(p => p.Person);
                return await projectDbContext.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
