using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC___EF_App.Models;
using MVCEFApp.Models;
using NuGet.Protocol.Core.Types;

namespace MVC___EF_App.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patient = RepositoryPatient.GetPatient();
            if(patient != null && patient.Count > 0)
            {
                return View(patient);
            }
           else 
            { 
                return RedirectToAction("Create"); 
            }
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id); 
            return View(patient);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Patient apatient)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(apatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Patient patient)
        {
            try
            {
                if(ModelState.IsValid) 
                {
                    RepositoryPatient.ModifyPaitient(patient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Patient patient)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    RepositoryPatient.RemovePatient(id);
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
