using System;
using System.Collections.Generic;

namespace CG.Domain.Entities
{
    public class Cv : Entity
    {
        public string Name { get; set; }
        public Language Language { get; set; }
        public CvOrigin CvOrigin { get; set; }

        // Navigation properties
        public IEnumerable<PersonCv> PersonCvs { get; set; }
    }
}
