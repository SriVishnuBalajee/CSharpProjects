using Microsoft.AspNetCore.Mvc;

namespace Taghelper.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x,int y) 
        {
            return x + y;
        }
    }
}
