using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC___EF_App.Models;
using MVCEFApp.Models;

namespace MVC___EF_App.Controllers
{
    public class DoctorControll : Controller
    {
        // GET: DoctorControll
        public ActionResult Index()
        {
            List<Doctor> doctor = RepositoryDoctor.GetDoctors(); 
            if(doctor != null && doctor.Count>0)
                return View(doctor);
            else 
                return RedirectToAction("Create");
        }

        // GET: DoctorControll/Details/5
        public ActionResult Details(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // GET: DoctorControll/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: DoctorControll/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Doctor pDoctor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryDoctor.AddNewDoctor(pDoctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception error)
            {
                return View(error);
            }
        }

        // GET: DoctorControll/Edit/5
        public ActionResult Edit(int id)
        {
            Doctor doctor=RepositoryDoctor.GetDoctorById(id);

            return View();
        }

        // POST: DoctorControll/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Doctor pdoctor)
        {
            try
            {   if (ModelState.IsValid)
                {
                    RepositoryDoctor.ModifyDoctor(pdoctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorControll/Delete/5
        public ActionResult Delete(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);

            return View(doctor);
        }

        // POST: DoctorControll/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Doctor doctor)
        {
            try
            {   if(!ModelState.IsValid)
                {
                    RepositoryDoctor.RemoveDoctor(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
