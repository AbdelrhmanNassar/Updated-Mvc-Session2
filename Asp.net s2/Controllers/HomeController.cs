 using Microsoft.AspNetCore.Mvc;

namespace Asp.net_s2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] 
        //BaseUrl/Home/Index 
        //return view with name of Action so i need to create view with the name of action
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        } public IActionResult Privacy()
        {
            return View();
        } public IActionResult ContactUs()
        {
            return View();
        }
    }
}
