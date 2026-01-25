using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Seller: BaseEntity<Guid>, IAuditableEntity
{
    public string TaxCode { get; set; }
    public string CompanyName { get; set; }
    public string CompanyAddress { get; set; }
    
    public Guid UserId { get; set; }//1 user có thể là 1 seller
    public User User { get; set; } // để ORM biết có mối quan hệ với nhau, sau đó xuống database 
    
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}