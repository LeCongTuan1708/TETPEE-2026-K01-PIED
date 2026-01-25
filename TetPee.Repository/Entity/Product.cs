using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Product: BaseEntity<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string UrlImage { get; set; } = string.Empty;
    public decimal Price { get; set; }
    
    public Guid UserId { get; set; }//1 user có thể là 1 seller
    public User User { get; set; } // để ORM biết có mối quan hệ với nhau, sau đó xuống database 
    
    public ICollection<OrderDetail>  OrderDetails { get; set; } = new List<OrderDetail>();
    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}