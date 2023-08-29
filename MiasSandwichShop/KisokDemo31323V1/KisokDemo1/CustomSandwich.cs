using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisokDemo1
{
    class CustomSandwich : Product
    {

        public List<Toppings> Toppings { get; set; }

        internal CustomSandwich(Product baseSandwich, List<Toppings> Toppings, decimal price) : base(-1, "Customised " + baseSandwich.name, price)
        {
            this.Toppings = Toppings;
        }
    }
}
