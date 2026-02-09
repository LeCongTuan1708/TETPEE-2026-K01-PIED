using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee_1.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    private readonly AppDbContext _dbContext;
   //cái này nâng cao sẽ giải thích
    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //HTTP METHOD: GET, POST, DELETE, PUT, PATCH
    //PARAM: Query string, path Param, Body Param
    
    // Query string: http://localhost:5000/User?name=abc&age=20
        //name và age là query string
        //Query string nằm sau dấu ?
    // Path (Route) Param: http://localhost:5000/User/123
        //123 laf path param
        //Path param nằm trong đường dẫn
    // GET là không có body
    // POST, PUT PATCH có body
    
    // Tại sao phi dùng body: tránh để lộ những thông tin không mong muốn
    // ví dụ: Username, Pass
    // không thể http://localhost:5000/login?username=abc&password=123
      
    // Chuẩn REST FULL API
    // get all user: GET http://localhost:5000/User
    // create user: POST http://localhost:5000/User
    // get user by id: GET http://localhost:5000/User/{id}
    // update user by id: PUT http://localhost:5000/User/{id}
    // delete user by id: DELETE http://localhost:5000/User/{id}
    
    // update user by id: http://localhost:5000/User/{id}/update
    
    
    [HttpGet(template: "")]
    public IActionResult GetUsers([FromQuery]String? searchTerm)
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }

    [HttpGet(template: "{id}")]
    public IActionResult GetUsersById([FromRoute]Guid id)
    {
        //var users = _dbContext.Users.ToList();
        //return Ok(users);
        return Ok(id);
    }
    
    [HttpPut(template: "{id}")]
    public IActionResult UpdateUsers(Guid id,[FromBody] Request.UpdateUserRequest request)
    {
        //var users = _dbContext.Users.ToList();
        //return Ok(users);
        return Ok("Get all users");
    }
    
    [HttpDelete(template: "{id}")]
    public IActionResult DeleteUsers(Guid id)
    {
        //var users = _dbContext.Users.ToList();
        //return Ok(users);
        return Ok("Get all users");
    }
    
    [HttpPost(template: "")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)
    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password // chưa hash, chỉ demo
        };
        
        _dbContext.Users.Add(user);
        
        _dbContext.SaveChanges();
        
        return Ok("Create user successfully");
    }
}