using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_Patejim_Feldman.Models;

namespace TP05_Patejim_Feldman.Controllers;

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

    public IActionResult Volver(){
        return View("Index");
    }

    public IActionResult Extra(){
        return View("Extra");
    }
    public IActionResult Tutorial(){
        return View("Tutorial");
    }
    public IActionResult Historia(){
        return View("Historia");
    }

    /* EMPIEZA EL JUEGO */

    public IActionResult Comienzo(){
        
        return View("Sala1");
    }

}
