using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Order: BaseEntity<Guid>, IAuditableEntity
{
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Pending"; // Pending, Processing, Completed, Cancelled
    public required string Address { get; set; }
    
    //1 order có 1 user
    public Guid UserId { get; set; }//1 user có thể là 1 seller
    public User User { get; set; } // để ORM biết có mối quan hệ với nau, sau đó xuống database 
    
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}