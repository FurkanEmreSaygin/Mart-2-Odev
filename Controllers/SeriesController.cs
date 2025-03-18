using Mart_2_Odev.Models;
using Microsoft.AspNetCore.Mvc;
namespace Mart_2_Odev.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            var Seri = new Series();
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}