namespace CG.Domain.Entities
{
   public class Section:Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Default { get; set; }
        public SectionType SectionType { get; set; }
    }
}
