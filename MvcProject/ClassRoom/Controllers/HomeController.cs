using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClassRoom.Models;
using DataLayer.Models;
using Students.Models;
namespace ClassRoom.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
    

     public IActionResult Welcome(int sid,string name,string mail,string password)
    {    
        List<Student> stud=new List<Student>(DataStore.DeserializeIo());
        DataStore.CollectData(sid,name,mail,password,stud);
        return View();
    }
     public IActionResult Details()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
