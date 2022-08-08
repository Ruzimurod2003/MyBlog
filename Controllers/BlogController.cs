using Microsoft.AspNetCore.Mvc;
using MyBlog.Interfaces;
using MyBlog.Models;
using MyBlog.Services;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUserServices userServices;
        public BlogController(IUserServices _userServices)
        {
            userServices = _userServices;
        }
        public IActionResult Index()
        {
            List<User> users = userServices.GetUsers();
            return View(users);
        }
    }
}
