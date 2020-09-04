using AplicacionTenant2.Models;
using AplicacionTenant2.Models.App_data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionTenant2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        BaseModel MiModeloBase = new BaseModel(Constant.database);
        BaseModel MiModeloBase2 = new BaseModel(Constant.databaseSecondary);
        public ActionResult Index()
        {
            return View();
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(Persona model)
        {
            MiModeloBase.Entity.Persona.Add(model);
            MiModeloBase.Entity.SaveChanges();
            MiModeloBase2.Entity.Persona.Add(model);
            MiModeloBase2.Entity.SaveChanges();
                return View();
         }
        

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
