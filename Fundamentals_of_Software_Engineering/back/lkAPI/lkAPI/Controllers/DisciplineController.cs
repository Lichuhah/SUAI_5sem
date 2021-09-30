using lkAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace lkAPI.Controllers
{
    public class DisciplineController : Controller
    {
        DisciplineRepository rep = new DisciplineRepository();
        // GET: DisciplineController
        public ActionResult Index()
        {
            return View();
        }
        
        public string All()
        {
            try
            {
                return JsonConvert.SerializeObject(rep.All());
            } catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        public string AllForUser(int id)
        {
            try
            {
                StudentRepository studrep = new StudentRepository();
                var stud = studrep.Get(id);
                var list = rep.All().Where(x=>x.)
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        // GET: DisciplineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisciplineController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisciplineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DisciplineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisciplineController/Edit/5
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

        // GET: DisciplineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisciplineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
