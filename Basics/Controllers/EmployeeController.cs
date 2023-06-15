using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        //public string Index()
        public IActionResult Index1()
        {
            //return "Hello World.";
            string message = $"<a href=\"https://docs.microsoft.com/aspnet/core\">Hello World. {DateTime.Now.ToString()}</a>.</p>";
            return View("Index1",message);
        }

        public ViewResult Index2()//Defaut olarak bu method isminde bir view arar
        {
            var messages = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(messages);//farkli bir viewi vermek istiyorsak bu sekilde kullanabiliriz
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>(){
                new Employee(){Id=1, FirstName="Ahmet", LastName ="Can", Age=22},
                new Employee(){Id=2, FirstName="Mehmet", LastName ="Can", Age=22},
                new Employee(){Id=3, FirstName="Ali", LastName ="Demir", Age=42},
            };
            //return Content("Employee");
            return View("Index3",list);
        }
    }
}