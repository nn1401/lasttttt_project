using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class OrderDetails
    {
        int orderDetailId;
        Products product;
        Orders order;
        float price;

        public OrderDetails()
        {
        }

        public OrderDetails(int orderDetailId, Products product, Orders order, float price)
        {
            this.OrderDetailId = orderDetailId;
            this.Product = product;
            this.Order = order;
            this.Price = price;
        }

        public int OrderDetailId { get => orderDetailId; set => orderDetailId = value; }
        public float Price { get => price; set => price = value; }
        internal Products Product { get => product; set => product = value; }
        internal Orders Order { get => order; set => order = value; }
    }
}
