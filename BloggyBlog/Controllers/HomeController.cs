using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BloggyBlog.Models;
using BloggyBlog.ViewModels;

namespace BloggyBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly List<Article> _articles = new()
    {
        new()
        {
            Id = 1,
            Blogger = "Name blogger",
            Content = "Content",
            PublishedDate = DateTime.Now,
            Title = "Title"
        }
    };

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ArticleViewData vm = new ArticleViewData();
        vm.Articles = _articles;
        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}