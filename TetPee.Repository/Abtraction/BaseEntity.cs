namespace TetPee.Repository.Abtraction;

public abstract class BaseEntity<TKey> //bạn muốn tạo PK trong table là kiểu gì thì truyền vô vd: int, string
{
    public TKey Id { get; set; }
    
    public bool isDeleted { get; set; }// Soft Delete: thay vì xóa dữ liệu database thì mình thay đổi nó
    // Tránh xung đột khóa ngoại (Foreign Key Contraint)
}