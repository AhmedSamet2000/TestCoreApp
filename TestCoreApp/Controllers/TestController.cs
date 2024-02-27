using Microsoft.AspNetCore.Mvc;

namespace TestCoreApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
