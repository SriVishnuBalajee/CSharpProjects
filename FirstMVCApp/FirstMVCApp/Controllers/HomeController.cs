using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;//used to log the information.

        public HomeController(ILogger<HomeController> logger)//constructor based  dependency injection
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();//view() is a inbuild method which returns the corresponding html file
        }
        public IActionResult SayHello(String name)
        {
            if (String.IsNullOrEmpty(name))
                ViewData["v1"] = "Name is Empty";
            else
                ViewData["v1"] = name;
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["v1"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["v1"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["v1"] = result;
            return View("Add");
        }
        public IActionResult DoLogin(String txtUser, String txtPwd)

        {
            ViewData["userValue"] = $"{txtUser},{txtPwd}";

            return View();
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
        //Working with Book Object
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            string fName = @"C:\temp\temp1.txt";
            string lines =  $"{pBook.BookID},{pBook.Title},{pBook.Cost},{pBook.AuthorName}" ;
            using (StreamWriter sw = new StreamWriter(fName,true))
            {
                sw.WriteLine(lines);
            }
            return View(pBook);
        }
        public Book StringToBook(string[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title =data[1];
            book.Cost = int.Parse(data[2]);
            book.AuthorName = data[3];
            
            return book;
        }
        public IActionResult ListAllBook()
        {
            String fName = @"C:\temp\temp1.txt";
            List<Book> lines = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = sr.ReadLine().ToString();
                Console.Write(strBook);
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                lines.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = sr.ReadLine().ToString();
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    lines.Add(book);
                }
                return View(lines);
            }





        }


    }
}

 
