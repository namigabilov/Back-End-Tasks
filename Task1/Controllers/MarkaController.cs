using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class MarkaController : Controller
    {
        public IActionResult Index()
        {
            List<Marka> markas = new List<Marka>
            {
                new Marka {Name = "BMW" ,Id =1},
                new Marka {Name = "Mercedes" ,Id =2},
                new Marka {Name = "Tesla" ,Id =3}
            };
            return View(markas);
        }
    }
}
