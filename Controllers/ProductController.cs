using CrudWithDepInjec.Models;
using CrudWithDepInjec.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDepInjec.Controllers
{
    public class ProductController : Controller
    {
        private IProducts IPro;
        public ProductController(IProducts _IPro)
        {
            IPro = _IPro;
        }
        public IActionResult Index()
        {
            var PObj = IPro.GetProducts();
            return View(PObj);

        }

        public IActionResult Create()
        {
            
            return View();

        }
        [HttpPost]
        public IActionResult Create(Products products)
        {
            IPro.PostProduct(products);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            IPro.DeleteProduct(id);
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            return View(IPro.GetProductById(id));

        }
        [HttpPost]
        public IActionResult Update(Products products1)
        {
            IPro.UpdateProduct(products1);
            return RedirectToAction("Index");

        }
       
    }
}
