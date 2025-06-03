using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_MVC_Practice.Controllers
{
    public class StudentInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
