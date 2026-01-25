using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Category: BaseEntity<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    
    public Guid? ParentId { get; set; } 
    public Category? Parent { get; set; }
    // nếu mà là null, thì nó là thằng cha cao nhất
    // nếu mà có giá trị, thì nó là thằng con của ParentId
    
    public  ICollection<Category> Children { get; set; } = new HashSet<Category>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}