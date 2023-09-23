using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FirstMVCApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<Employee> employees = EmpClassRepository.GetEmplist();
            return View(employees);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
           // Employee employee = EmpClassRepository.GetEmpbyId(id);
            if (id <=0 )
            {
                return RedirectToAction("Index");
            }
            Employee employee = EmpClassRepository.GetEmpbyId(id);
            return View(employee);
        }

        // GET: EmpController/Create
        public ActionResult Create(int id)
        {
            Employee employee = EmpClassRepository.GetEmpbyId(id);
            return View(employee);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employee pEmp)
        {
            try
            {
               if(ModelState.IsValid) 
                {
                    EmpClassRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
          
            
            return View();
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
           Employee employee= EmpClassRepository.GetEmpbyId(id);
            return View(employee);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpClassRepository.DeleteEmp(id);
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
