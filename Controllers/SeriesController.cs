using Mart_2_Odev.Models;
using Microsoft.AspNetCore.Mvc;
namespace Mart_2_Odev.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            var Seriler = new List<Series>(){
                new Series() {Id = 1, Name = "Breaking Bad", Description = "Breaking Bad, Vince Gilligan tarafından yaratılan Amerikan televizyon dizisidir. Dizi, kimya öğretmeni Walter White'ın, kanser olduğunu öğrenmesinin ardından ailesine maddi bir gelecek bırakabilmek için"},
            };
            return View(Seriler);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}