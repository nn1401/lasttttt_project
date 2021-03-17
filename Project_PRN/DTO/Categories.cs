using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Categories
    {
        string categoryId;
        string categoryName;

        public Categories()
        {
        }

        public Categories(string categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }

        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public override string ToString()
        {
            return "categoryId = " + categoryId + " and categoryName = " + categoryName;
        }
    }
}
