using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web1_Prueba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("¡Hola Mundo! Dennys Jimenez");
        }
    }
}
