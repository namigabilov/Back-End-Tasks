using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _car ;

        public CarController()
        {
            _car = new List<Car>
            {
                new Car{ Id = 1,Model ="X5",Marka = "BMW" ,Year =2000 ,Yurus =1923,IdForModel = 1 },
                new Car{ Id = 1,Model ="X7",Marka = "BMW" ,Year =2000 ,Yurus =1923 ,IdForModel = 2},
                new Car{ Id = 1,Model ="M5",Marka = "BMW" ,Year =2000 ,Yurus =1923,IdForModel = 3},
                new Car{ Id = 2,Model ="S500",Marka = "Mercedes" ,Year =2000 ,Yurus =1923 ,IdForModel = 4},
                new Car{ Id = 2,Model ="S400",Marka = "Mercedes" ,Year =2000 ,Yurus =1923 ,IdForModel = 5},
                new Car{ Id = 2,Model ="Sl500",Marka = "Mercedes" ,Year =2000 ,Yurus =1923 , IdForModel = 6 },
                new Car{ Id = 2,Model ="C200",Marka = "Mercedes" ,Year =2000 ,Yurus =1923,IdForModel = 7},
                new Car{ Id = 3,Model ="Model-S",Marka = "Tesla" ,Year =2000 ,Yurus =1923 ,IdForModel = 8},
                new Car{ Id = 3,Model ="Model-Y",Marka = "Tesla" ,Year =2000 ,Yurus =1923 , IdForModel =9},
                new Car{ Id = 3,Model ="Model-X",Marka = "Tesla" ,Year =2000 ,Yurus =1923,IdForModel = 10},
            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (_car.Exists(x=>x.IdForModel == id))
            {
                return View(_car.FindAll(x=>x.IdForModel == id));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
