using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System_Application_Hotel_Hits.DataContext;
using System_Application_Hotel_Hits.Models;

namespace System_Application_Hotel_Hits.Controllers
{
    public class FornecedorController : Controller
    {
        public HotelDB db = new HotelDB();
        // GET: Fornecedor
        public ActionResult Index()
        {
            List<Fornecedores> _Fornecedores = new List<Fornecedores>();
            _Fornecedores.Add(new Fornecedores()
            {
                Id = 1,
                NomeEmpresa = "Alimentos LTDA",
                CNPJ = "33.020.316/0001-25",
                Categoria = "Alimentação",
                TipoCategoria = "Horti-Fruti",
                InscricaoEstatual = "0713382000205",
                           
            }); 

            return View(_Fornecedores);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
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

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fornecedor/Edit/5
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

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fornecedor/Delete/5
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
