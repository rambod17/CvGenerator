using Microsoft.AspNetCore.Identity;

namespace CG.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public Person Person { get; set; }
    }
}
