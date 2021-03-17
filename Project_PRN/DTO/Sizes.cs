using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Sizes
    {
        int sizeId;
        string sizeName;

        public Sizes()
        {
        }

        public Sizes(int sizeId, string sizeName)
        {
            this.SizeId = sizeId;
            this.SizeName = sizeName;
        }

        public int SizeId { get => sizeId; set => sizeId = value; }
        public string SizeName { get => sizeName; set => sizeName = value; }
    }
}
