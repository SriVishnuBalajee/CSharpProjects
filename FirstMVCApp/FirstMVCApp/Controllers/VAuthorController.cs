using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class VAuthorController : Controller
    {
        // GET: VAuthorController
        public ActionResult Index()
        {
            Dictionary<int, Author> list = VAuthorRepository.GetAuthorDictionary();

            if (list.Count != 0)
            {
                return View("AuthorList", list.Values.ToList());
            }
            
            return View();
            
        }

        // GET: VAuthorController/Details/5
        public ActionResult Details(int id)
        {

            Author author = VAuthorRepository.FindAuthorId(id);
            if (author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }
        // GET: VAuthorController/Create
        public ActionResult Create()
        {
            Author author=new Author();
            return View(author);
        }

        // POST: VAuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pAuthor)
        {
            try
            {
                VAuthorRepository.SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VAuthorController/Edit/5
        public ActionResult Edit(int id)
        {

            Author author = VAuthorRepository.FindAuthorId(id);

            if (author != null)
            {
                return View(author);
            }
            return View(author);
            
        }

        // POST: VAuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author pauthor)
        {
            try
            {
                VAuthorRepository.UpdateAuthorToFile(pauthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VAuthorController/Delete/5
        public ActionResult Delete(int id)
        {
           Author author=VAuthorRepository.FindAuthorId(id);
            if (author != null)
            {
                return View(author);
            }
            return View(author);
        }

        // POST: VAuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                VAuthorRepository.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
