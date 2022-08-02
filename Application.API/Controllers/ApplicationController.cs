using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
