using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System_Application_Hotel_Hits.DataContext;
using System_Application_Hotel_Hits.Models;

namespace System_Application_Hotel_Hits.Controllers
{
       public class HospedeController : Controller
    {
        private HotelDB db = new HotelDB();
        // GET: Hospede
        public ActionResult Index()
        {
            List<Hospede> CadHospedes = new List<Hospede>();
            CadHospedes.Add(new Hospede()
            {
                Id = 1,
                Nome = "Robson ",
                Sobrenome = "Pereira",
                TelefoneFixo = "11-4444-0000",
                Celular = "11-99999-8888",
                Email = "robson@teste.com.br",

            });

            return View(CadHospedes);
            
        }

        // GET: Hospede/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hospede/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospede/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospede/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hospede/Edit/5
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

        // GET: Hospede/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hospede/Delete/5
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
