using Microsoft.AspNetCore.Identity;
using System;

namespace CG.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
    }
}
