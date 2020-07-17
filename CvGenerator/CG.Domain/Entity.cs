using System.ComponentModel.DataAnnotations;

namespace CG.Domain
{
    public abstract class Entity
    {
        protected Entity()
        {
            IsEnabled = true;
        }

        public int Id { get; set; }
        public bool IsEnabled { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
