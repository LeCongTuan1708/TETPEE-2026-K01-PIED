namespace TetPee.Repository.Abtraction;

public interface IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; } // dòng dữ liệu này được rạo ra khi nào
    public DateTimeOffset? UpdateAt { get; set; } // dòng dữ liệu này được cập nhật lần cuối khi nào
}