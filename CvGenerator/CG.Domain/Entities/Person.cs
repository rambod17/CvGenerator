﻿using System;
using System.Collections.Generic;

namespace CG.Domain.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public Country Country { get; set; }

        // Navigation properties
        public IEnumerable<PersonCv> PersonCvs { get; set; }
    }
}
