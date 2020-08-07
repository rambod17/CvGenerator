using MediatR;
using System;

namespace CG.Core.Person.Commands
{
    public class AddNewPersonCommand : IRequest<Unit>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public byte[]? Photo { get; set; }
        public int? CountryId { get; set; }
    }
}
