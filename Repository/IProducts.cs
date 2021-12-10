using CrudWithDepInjec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDepInjec
{
   public interface IProducts
    {
        List<Products> GetProducts();

        Products PostProduct(Products pro);

        Products GetProductById(int id);

        Products UpdateProduct(Products pro);
        bool DeleteProduct(int id);
    }
}
