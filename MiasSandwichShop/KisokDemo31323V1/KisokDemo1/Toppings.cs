using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisokDemo1
{
    public class Toppings : Product
    {
        public Toppings(int _id, string _name, decimal _price) : base(_id, _name, _price)
        {
        }

        public Toppings(int _id, string _name, decimal _price, string imagePath) : base(_id, _name, _price, imagePath)
        {
        }
    }
}
