using AspNetMvcMonolithic.ApplicationService.Dtos;
using AspNetMvcMonolithic.ApplicationService.Services.Contracts;
using AspNetMvcMonolithic.Models.DomainModels.ProductAggregats;
using AspNetMvcMonolithic.Models.Services.Contracts;
using AspNetMvcMonolithic.Models.Services.Repositories;

namespace AspNetMvcMonolithic.ApplicationServices.Services
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductRepository _productRepository;

        public ProductApplicationService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        public async Task<List<ProductGetDtoList>> GetAllProductsListAsync()
        {
            var product = await _productRepository.SelectAll();
            var result = product.Select(product => new ProductGetDtoList()
            {
                Id = product.Id,
                Code = product.Code,
                Title = product.Title,
                UnitPrice = product.UnitPrice,
                Quantity = product.Quantity,
                RecordDescription = product.RecordDescription
            }).ToList();

            return result;
        }
        //    public async Task<List<ProductGetDtoList>> GetAllProductsListAsync()
        //    {
        //        var product = await _productRepository.SelectAll();
        //        if (product == null)
        //        {
        //            return new List<ProductGetDtoList>();
        //        }

        //        var productslist = new List<ProductGetDtoList>();

        //        foreach (var p in productslist)
        //        {
        //            var productlist = new ProductGetDtoList()
        //            {
        //                Id = p.Id,
        //                Code = p.Code,
        //                Title = p.Title,
        //                UnitPrice = p.UnitPrice,
        //                Quantity = p.Quantity,
        //                RecordDescription = p.RecordDescription,
        //                PersonId = p.PersonId,
        //                Person = p.Person


        //            };
        //            productslist.Add(productlist);
        //        }
        //        return productslist;
        //    }
    }



}
