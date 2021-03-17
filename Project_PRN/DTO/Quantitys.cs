using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Quantitys
    {
        string quantityId;
        Products product;
        Sizes size;
        Colors color;
        int quantitySize;

        public Quantitys()
        {
        }

        public Quantitys(string quantityId, Products product, Sizes size, Colors color, int quantitySize)
        {
            this.QuantityId = quantityId;
            this.Product = product;
            this.Size = size;
            this.Color = color;
            this.QuantitySize = quantitySize;
        }

        public string QuantityId { get => quantityId; set => quantityId = value; }
        public int QuantitySize { get => quantitySize; set => quantitySize = value; }
        internal Products Product { get => product; set => product = value; }
        internal Sizes Size { get => size; set => size = value; }
        internal Colors Color { get => color; set => color = value; }
    }
}
