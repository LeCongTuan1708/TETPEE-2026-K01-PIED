using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class ProductStorage: BaseEntity<Guid>, IAuditableEntity
{
    public decimal Price { get; set; }
    public required string Type { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}