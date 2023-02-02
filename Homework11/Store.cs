using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    internal class Store
    {
        public Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length - 1] = product;
        }

        public bool HasProductByNo(int no)
        {
            foreach (Product product in Products)
            {
                if (product.No == no)
                    return true;
            }
            return false;
        }

        public Product GetProductByNo(int no)
        {
            int count = 1;
            try
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (count == no)
                    {
                        return Products[i];
                    }
                    count++;

                }

                if (!HasProductByNo(no))
                {
                    throw new ProductNotFoundException();
                }

            }
            catch (ProductNotFoundException)
            {
                Console.WriteLine("This Product is not found");
            }
            return null;
        }

    }
}
