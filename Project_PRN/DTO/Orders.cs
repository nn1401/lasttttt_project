using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Orders
    {
        int orderId;
        Users user;
        DateTime dateCreated;
        bool status;
        float totalPrice;

        public Orders()
        {
        }

        public Orders(int orderId, Users user, DateTime dateCreated, bool status, float totalPrice)
        {
            this.OrderId = orderId;
            this.User = user;
            this.DateCreated = dateCreated;
            this.Status = status;
            this.TotalPrice = totalPrice;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public bool Status { get => status; set => status = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        internal Users User { get => user; set => user = value; }
    }
}
