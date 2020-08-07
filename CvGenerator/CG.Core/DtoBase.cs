using System;

namespace CG.Core
{
    public class DtoBase
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool IsEnabled { get; set; }
    }
}
