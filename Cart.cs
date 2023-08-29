using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisokDemo1
{
    class Cart
    {

        private List<Product> products;
        private decimal total;

        public Cart()
        {
            products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            products.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public decimal Total()
        {
            total = 0.0m;

            foreach (var item in products)
            {
                total += item.price;
            }

            return total;
        }

        public string GetOrder()
        {
            List<string> output = new List<string>();
            foreach (var item in products)
            {
                if (item is CustomSandwich)
                {
                    CustomSandwich custom = (CustomSandwich)item;
                    List<string> output2 = new List<string>();
                    //custom.Toppings
                    foreach (var topping in custom.Toppings)
                    {
                        output.Add(topping.name + "," + item.price);
                    }
                    output.Add(item.name + "," + item.price + "," + string.Join(",", output2));
                }
                else
                {
                    output.Add(item.name + "," + item.price);
                }
            }
            output.Add("Total:" + Total());
            return string.Join("\r\n", output);
        }
    }
}
