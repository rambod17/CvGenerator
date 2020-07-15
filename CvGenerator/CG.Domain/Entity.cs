namespace CG.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            IsEnabled = true;
        }

        public int Id { get; set; }
        public bool IsEnabled { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
