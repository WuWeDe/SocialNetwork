namespace SocialNetwork.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateAt{ get; set; } = DateTime.Now;
        public DateTime UpdateAt{ get; set; } = DateTime.Now;   
    }
}
