using Microsoft.AspNetCore.Mvc;

namespace Taghelper.Controllers
{
    public class PartialviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}
