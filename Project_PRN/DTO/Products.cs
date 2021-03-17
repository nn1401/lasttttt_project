using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Products
    {
        string productId;
        string productName;
        Categories category;
        float price;

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        internal Categories Category { get => category; set => category = value; }
        public float Price { get => price; set => price = value; }

        public Products(string productId, string productName, Categories category, float price)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Category = category;
            this.Price = price;
        }

        public Products()
        {
        }


    }
}
