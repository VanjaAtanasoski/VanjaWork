namespace TaxiManager9000.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        protected BaseEntity(int id)
        {
            Id = id;
        }
        protected BaseEntity()
        {
            Id = -1;
        }
    }
}
