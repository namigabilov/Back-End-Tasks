using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model{ Id = 1,Name ="X5",Marka = "BMW" ,Year =2000 ,Yurus =1923 },
                new Model{ Id = 1,Name ="X7",Marka = "BMW" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 1,Name ="M5",Marka = "BMW" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 2,Name ="S500",Marka = "Mercedes" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 2,Name ="S400",Marka = "Mercedes" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 2,Name ="Sl500",Marka = "Mercedes" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 2,Name ="C200",Marka = "Mercedes" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 3,Name ="Model-S",Marka = "Tesla" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 3,Name ="Model-Y",Marka = "Tesla" ,Year =2000 ,Yurus =1923},
                new Model{ Id = 3,Name ="Model-X",Marka = "Tesla" ,Year =2000 ,Yurus =1923},
            };
        }
        public IActionResult Index(int? id)
        {

            if (id == null)
            {
                return View(_models);
            }
            if(_models.Exists(x=> x.Id == id)) {
                return View(_models.FindAll(x => x.Id == id));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
