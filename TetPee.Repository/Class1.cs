namespace TetPee.Repository;

public class Class1
{
    //ORM: Object-Relational Mapping
    
    //Code Frist và Database First
    
    // Thông thường để mà ở trên code mà để có thể làm việc với database,
        // thì mình cần ánh sạ (mapping) các table từ database lên code dễ quản lí và làm việc
        
    // Database First:
    // - làm việc với database có sẵn, setup 1 Database
    // - vô tạo create Table, Create Database, Setup Field, Set các Relationship
    // - Sau đó ở trên code sử dụng các Driver hoặc ORM để kết nối xuống Database
    // - Ở trên code sẽ tạo những class tương ứng với các table trong database
    // - Thằng này sử dụng khi nào: khi mình có Database code có sẵn và đã sử dụng trong rất nhiều năm rồi.
    
    // Code First:
    // - Mình sẽ không setup Database thủ công bằng các Query
    // - Không vô tạo Create Table, Create Database, Setup Field, Set các Relationship
    // - Mình design Database bằng những class trên code luôn, trên code setup các Entity, các Field, các Relationship
    // - Sau đó ánh xạ từ các class xuống các table trong database
    // Vậy làm sao để ánh xạ được, từ các class trên code xuống database: ORM
    // thằng này sử dụng khi: Dự án mới, hiện tại, nhiều công cụ hỗ trợ
    
    // Tuyệt đỉnh ORM của .NET: entity Framwork. Không biết sử dụng thằng này sẽ mất 90% .Net
}