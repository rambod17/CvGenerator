using CG.Core.Country.DTOs;
using MediatR;
using System.Collections.Generic;

namespace CG.Core.Country.Queries
{
    public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDto>>
    {
    }
}
