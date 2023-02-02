using System;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Store store = new Store();

            Product product1 = new Product()
            {
                Category = "something",
                Price = 44
            };

            Product product2 = new Product()
            {
                Category = "anything",
                Price = 55
            };


            string operation;

            do
            {
                Console.WriteLine("1. Product elave et");
                Console.WriteLine("2. Butun productlara bax");
                Console.WriteLine("3. Verilmis nomreli producta bax");
                Console.WriteLine("0. Menudan cix");

                Console.Write("Operation: ");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        store.AddProduct(product1);
                        store.AddProduct(product2);
                        break;
                    case "2":
                        foreach (Product product in store.Products)
                        {
                            Console.WriteLine($"Product No: {product.No} | Product Category: {product.Category} | Product Price: {product.Price}");
                        }
                        break;
                    case "3":

                        for (int i = 0; i < store.Products.Length; i++)
                        {
                            if (store.GetProductByNo(1) == store.Products[i])
                            {
                                Console.WriteLine($"Product No: {store.Products[i].No} | Product Category: {store.Products[i].Category} | Product Price: {store.Products[i].Price}");
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Yanlish secim daxil etmisiniz");
                        break;
                }

            } while (operation != "0");
        }
    }
}
