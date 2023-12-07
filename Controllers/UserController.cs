// LoginController.cs
using Microsoft.AspNetCore.Mvc;
using NhanSu.Models;

public class LoginController : Controller
{
    private static readonly List<User> usersDatabase = new List<User>
    {
        new User { Username = "admin", Password = "admin" },
        // new User { Username = "user2", Password = "password2" }
    };

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Kiểm tra xem người dùng có tồn tại trong cơ sở dữ liệu không
        var user = usersDatabase.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            return RedirectToAction("Index", "Home"); // Chuyển hướng đến trang chủ sau khi đăng nhập thành công
        }

        return Content("Invalid username or password. Please try again.");
    }
}
