using System.Data.SqlTypes;
using AspNetMvcMonolithic.Models.DomainModels.PersonAggregats;

namespace AspNetMvcMonolithic.ApplicationService.Dtos
{
    public class ProductGetDtoList
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string RecordDescription { get; set; }

     
    }
}
