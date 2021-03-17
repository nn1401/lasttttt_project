using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Colors
    {
        int colorId;
        string colorName;

        public Colors()
        {
        }

        public Colors(string colorName)
        {
            ColorName = colorName;
        }

        public Colors(int colorId, string colorName)
        {
            this.ColorId = colorId;
            this.ColorName = colorName;
        }

        public int ColorId { get => colorId; set => colorId = value; }
        public string ColorName { get => colorName; set => colorName = value; }

        public override string ToString()
        {
            return "colorId = " + colorId + " and colorName = " + colorName;
        }
    }
}
