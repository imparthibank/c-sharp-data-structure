using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }

        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }
    }

}
