using Microsoft.AspNetCore.Mvc;
namespace Mart_2_Odev.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}