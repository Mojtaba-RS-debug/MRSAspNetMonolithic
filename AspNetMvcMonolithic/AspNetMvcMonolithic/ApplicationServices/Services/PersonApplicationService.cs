using AspNetMvcMonolithic.ApplicationService.Dtos;
using AspNetMvcMonolithic.ApplicationService.Services.Contracts;
using AspNetMvcMonolithic.Models.Services.Contracts;
using AspNetMvcMonolithic.Models.Services.Repositories;

namespace AspNetMvcMonolithic.ApplicationService.Services
{
    public class PersonApplicationService : IPersonApplicationService
    {
        private readonly IPersonRepository _personRepository;

        public PersonApplicationService(IPersonRepository personRepository)
        {
            _personRepository=personRepository;
        }
        public async Task<List<PersonGetDtoList>> GetAllPersonListAsync()
        {
            var person = await _personRepository.SelectAll();

            if (person==null)
            {
                return new List<PersonGetDtoList>();
                
            }

            var personlist = new List<PersonGetDtoList>();

            foreach (var p in personlist)
            {
                var personslist = new PersonGetDtoList()
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName


                };
                personlist.Add(personslist);


            }
            return personlist;

        }
    }
}
