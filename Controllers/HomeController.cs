using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05.Models;
/* RevisionJulian 10/7
1- El tp esta bien estructurado y muy prolijo
2- Flow del juego: al sacar el menu, nos quedamos sin algunos botones que necesitamos. LISTO
   2.1 En tutorial agregar boton de comenzar o volver YA ESTA
   2.2 Durante el juego en algun lugar tener el reiniciar o ir a home o algo YA ESTA
   2,3 importante: ver la importancia de los botones YA ESTA
3- Extras mas dificiles! ÑAO ÑAO POR AHORA
  2.1 Usar Alertable o similar para las pistas : https://www.jqueryscript.net/other/Nice-Clean-jQuery-Alert-Confirm-Dialog-Plugin-alertable-js.html
   
*/
namespace TP05.Controllers;

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

    public IActionResult Tutorial()
    {
        
        return View();
    }

    public IActionResult Comenzar()
    {
        return View("Habitacion" + Escape.GetEstadoJuego().ToString());
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        Console.WriteLine("Entre al habitacion controller");
        if (sala==Escape.GetEstadoJuego())
        {
            if (Escape.ResolverSala(sala, clave))
            {
                if(6==Escape.GetEstadoJuego())
                {
                    return View("Victoria");
                }
                return View("Habitacion" + Escape.GetEstadoJuego().ToString());
                
            }else
            {
                ViewBag.Error = "Error";
                return View("Habitacion" + Escape.GetEstadoJuego().ToString());
            }
        }else
        {
            return View("Habitacion" + Escape.GetEstadoJuego().ToString());
        }
        
    }
    public IActionResult Victoria()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
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
