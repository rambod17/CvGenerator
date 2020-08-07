using CG.Core.Person.DTOs;
using MediatR;

namespace CG.Core.Person.Queries
{
    public class GetPersonByIdQuery : IRequest<PersonDto>
    {
        public GetPersonByIdQuery(int personId)
        {
            PersonId = personId;
        }

        public int PersonId { get; set; }
    }
}
