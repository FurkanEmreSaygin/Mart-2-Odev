using Mart_2_Odev.Models;
using Microsoft.AspNetCore.Mvc;
namespace Mart_2_Odev.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            var Seriler = new List<Series>(){
                new Series() {Id = 1, Name = "Breaking Bad", Description = "Breaking Bad, Vince Gilligan tarafından yaratılan Amerikan televizyon dizisidir. Dizi, kimya öğretmeni Walter White'ın, kanser olduğunu öğrenmesinin ardından ailesine maddi bir gelecek bırakabilmek için", Image = "1.jpg"},
                new Series() {Id = 2, Name = "Game of Thrones", Description = "Game of Thrones, George R. R. Martin'in Buz ve Ateşin Şarkısı adlı roman serisinden uyarlanan Amerikan yapımı fantastik televizyon dizisidir. Dizi, yedi soylu ailenin mücadelesini konu almaktadır.", Image = "2.jpg"},
                new Series() {Id = 3, Name = "John Wick", Description = "John Wick, Derek Kolstad tarafından yaratılan Amerikan yapımı bir film serisidir. Seri, John Wick adlı emekli bir tetikçinin intikam hikâyesini konu almaktadır.", Image = "3.jpg"},
                new Series() {Id = 4, Name = "How to Train Your Dragon", Description = "How to Train Your Dragon, Cressida Cowell tarafından yazılan aynı adlı kitap serisine dayanan Amerikan yapımı bir medya serisidir. Seri, Vikingler ve ejderhalar arasındaki ilişkiyi konu almaktadır.", Image = "4.jpg"},
            };
            return View(Seriler);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}