using LabHelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            Person person = new()
            {
                FirstName = "Gav",
                LastName = "MacDonald"
            };
            return View(person);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
