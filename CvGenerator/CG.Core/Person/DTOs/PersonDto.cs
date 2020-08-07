using System;

namespace CG.Core.Person.DTOs
{
    public class PersonDto : DtoBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public byte[]? Photo { get; set; }
        public string Country { get; set; }
    }
}
