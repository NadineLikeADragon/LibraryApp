using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
    {
         public String ProductCode { get; set; }
        public String Description { get; set; }
        public int OnHandQuantity { get; set; }

        public decimal UnitPrice { get; set; }

        public Product()
        {
        }

        public Product(string prodCode, string description, int quantity, decimal price)
        {
            this.ProductCode = prodCode;
            this.Description = description;
            this.OnHandQuantity = quantity;
            this.UnitPrice = price;
        }
    }
}
