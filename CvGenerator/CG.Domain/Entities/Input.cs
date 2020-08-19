
namespace CG.Domain.Entities
{
   public class Input:Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public InputType InputType { get; set; }
    }
}
