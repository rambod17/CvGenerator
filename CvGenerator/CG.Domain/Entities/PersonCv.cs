using System.Collections.Generic;

namespace CG.Domain.Entities
{
    public class PersonCv : Entity
    {
        public Person Person { get; set; }
        public Cv Cv { get; set; }

        // Navigation properties
        public IEnumerable<PersonCv> PersonCvs { get; set; }
    }
}
