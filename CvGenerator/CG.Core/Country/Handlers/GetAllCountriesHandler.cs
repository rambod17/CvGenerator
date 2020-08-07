using CG.Core.Country.DTOs;
using CG.Core.Country.Queries;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CG.Core.Country.Handlers
{
    public class GetAllCountriesHandler : IRequestHandler<GetAllCountriesQuery, IEnumerable<CountryDto>>
    {
        private readonly IRepository<Domain.Entities.Country> _countryRepository;

        public GetAllCountriesHandler(IRepository<Domain.Entities.Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IEnumerable<CountryDto>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _countryRepository.GetAll();

            return countries.Select(x => new CountryDto
            {
                Id = x.Id,
                Name = x.Name,
                IsEnabled = x.IsEnabled,
                CreationDate = x.CreationDate,
                LastUpdate = x.LastUpdate
            }).ToList();
        }
    }
}
