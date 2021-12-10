using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDepInjec.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public bool IsActive { get; set; }
    }
}
