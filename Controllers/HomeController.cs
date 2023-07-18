using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstAspProj.Models;

namespace FirstAspProj.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var home =  new HomeModel();

        home.Nome = "Caio Marinho";
        home.Email = "caio.marinho@gmail.com";

        return View(home);
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
