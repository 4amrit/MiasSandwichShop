using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KisokDemo1
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public Image image { get; set; }

        public Product()
        {
        }
        //Constructor used to initialise the Product object
        public Product(int _id, string _name, decimal _price)
        {
            id = _id;
            name = _name;
            price = _price; 
        }
        public Product(int _id, string _name, decimal _price, string imagePath)
        {
            id = _id;
            name = _name;
            price = _price;
            image = Image.FromFile(imagePath);
        }

        public override string ToString()
        {
            return $"{name}:  {price.ToString()}";
        }
    }
}
