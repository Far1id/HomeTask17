using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public Product[] GetProductByPrice(int minPrice, int maxPrice)
        {
            Product[] products2 = new Product[0];
            foreach (var item in products)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    Array.Resize(ref products2, products2.Length + 1);
                    products2[products2.Length - 1] = item;
                }
            }
            return products2;
        }
        public void GetInfo()
        {
            foreach (var item in products)
            {
                item.GetInfo();
            }
        }
    }
}
