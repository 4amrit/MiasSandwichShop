using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisokDemo1
{
    abstract class FileReader
    {
        public abstract List<Product> GetAllProducts();
    }
}
