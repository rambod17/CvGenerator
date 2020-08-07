using CG.Core.Person.DTOs;
using CG.Core.Person.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CG.Core.Person.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonDto>
    {
        private readonly IRepository<Domain.Entities.Person> _personRepository;

        public GetPersonByIdHandler(IRepository<Domain.Entities.Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<PersonDto> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetById(request.PersonId);

            return new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Birthdate = person.Birthdate,
                PhoneNumber = person.PhoneNumber,
                CellNumber = person.CellNumber,
                Email = person.Email,
                Photo = person.Photo,
                Country = person.Country.Name,
                IsEnabled = person.IsEnabled,
                CreationDate = person.CreationDate,
                LastUpdate = person.LastUpdate
            };
        }
    }
}
