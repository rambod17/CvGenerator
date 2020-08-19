using System;
using System.Collections.Generic;
using System.Text;

namespace CG.Domain.Entities
{
    public class CvSection : Entity
    {
        public Cv Cv { get; set; }
        public Section Section { get; set; }
        public string Value { get; set; }
        public Input Input { get; set; }
    }
}
