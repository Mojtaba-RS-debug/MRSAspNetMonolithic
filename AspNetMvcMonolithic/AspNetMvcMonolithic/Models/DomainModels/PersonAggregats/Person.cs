using AspNetMvcMonolithic.Models.DomainModels.ProductAggregats;

namespace AspNetMvcMonolithic.Models.DomainModels.PersonAggregats
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Product> Products { get; set; }



    }
}
