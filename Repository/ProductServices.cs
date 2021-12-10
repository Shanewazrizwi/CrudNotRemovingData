using CrudWithDepInjec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDepInjec.Repository
{
    public class ProductServices : IProducts
    {
        private ApplicationContext context;
        public ProductServices(ApplicationContext _context)
        {
            context = _context;
        }
        public bool DeleteProduct(int id)
        {
            var proObj = context.products.SingleOrDefault(e => e.Id == id);
            if(proObj !=null)
            {
                proObj.IsActive = false;
                context.products.Update(proObj);
                context.SaveChanges();
                return true;

            }
            return false;
        }

        public Products GetProductById(int id)
        {
            var ProObj = context.products.SingleOrDefault(e => e.Id == id && e.IsActive == true);
            return ProObj;
        }

        public List<Products> GetProducts()
        {

            var ProObj = context.products.Where(e=>e.IsActive==true).ToList();
            return ProObj;
        }

        public Products PostProduct(Products pro)
        {
            pro.IsActive = true;
            context.products.Add(pro);
            context.SaveChanges();
            return pro;
        }

        public Products UpdateProduct(Products pro)
        {
            pro.IsActive = true;
            context.products.Update(pro);
            context.SaveChanges();
            return pro;
        }
    }
}
