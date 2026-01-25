namespace TetPee.Repository.Entity;

public class Cart
{
    public Guid  Id { get; set; }

    public bool IsDeleted { get; set; } = false; // Soft Delete: thay vì xóa dữ liệu database thì mình thay đổi n // Tránh xung đột kháo ngoại (Foreign Key Contraint)
    public DateTimeOffset CreatedAt { get; set; } // dòng dữ liệu này được rạo ra khi nào
    public DateTimeOffset? UpdateAt { get; set; } // dòng dữ liệu này được cập nhật lần cuối khi nào
}