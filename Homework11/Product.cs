using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    internal class Product
    {
        static int TotalCount;
        public Product()
        {
            TotalCount++;
            No = TotalCount;
        }

        public int No;
        public string Category;
        public double Price;
    }
}
