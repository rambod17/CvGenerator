using CG.Core.Person.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CG.Core.Person.Handlers
{
    public class AddNewPersonHandler : IRequestHandler<AddNewPersonCommand>
    {
        private readonly IRepository<Domain.Entities.Person> _personRepository;
        private readonly IRepository<Domain.Entities.Country> _countryRepository;

        public AddNewPersonHandler(IRepository<Domain.Entities.Person> personRepository, IRepository<Domain.Entities.Country> countryRepository)
        {
            _personRepository = personRepository;
            _countryRepository = countryRepository;
        }

        public async Task<Unit> Handle(AddNewPersonCommand request, CancellationToken cancellationToken)
        {
            var country = await _countryRepository.GetById((int)request.CountryId);

            var person = new Domain.Entities.Person
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Birthdate = request.Birthdate,
                PhoneNumber = request.PhoneNumber,
                CellNumber = request.CellNumber,
                Email = request.Email,
                Photo = request.Photo,
                Country = country
            };

            await _personRepository.Add(person);
            await _personRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
