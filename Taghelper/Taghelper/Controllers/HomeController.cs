using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Taghelper.Models;

namespace Taghelper.Controllers
{
    public class HomeController : Controller
    {
		private readonly IConfiguration _configuration;
		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
           _configuration= configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int x,IFormCollection Collection)
        
        { StringBuilder data = new StringBuilder(500);
            data.Append(" x:");
            data.Append(x);
            data.Append(" ");
            data.Append("name:");
            data.Append(Collection["name"]);
            data.Append(" ");
            data.Append("Password:");
            data.Append(Collection["Password"]);

            ViewData["x"] = data.ToString();
            return View("IndexPost");

        }
        public IActionResult DoTask(int? id)
        {
            if (id.HasValue)
            {
                ViewData["id"]=id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View();

        }
        public IActionResult GetBook()
        {
            Book b1 = new Book() { AuthorName = "H Lee" };
            ViewData["book"]=b1;    
            return View();
        }
        [ResponseCache(Duration = 15)]
        public IActionResult GetTime()
        {
            string todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
            return View();
        }

        public IActionResult Menu()
        {
            String ConString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information, ConString );
            return View();
        }
		public IActionResult Echo(String name,String city)
		{
            String s1 = "User" + name + "from City=" + city;
            ViewData.Add("Data1", s1);
            return View();
		}
		public IActionResult SayHello(String name)
		{
            String s1 = ("Hello" + name);
            ViewData.Add("Data1" , s1);

            return View(Echo);
		}


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}