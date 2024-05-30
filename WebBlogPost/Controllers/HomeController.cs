using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebBlogPost.Models;

namespace WebBlogPost.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
