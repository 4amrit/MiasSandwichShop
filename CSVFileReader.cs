using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KisokDemo1
{
    class CSVFileReader : FileReader
    {
        List<Product> products;
        string filePath;
        string [] items;

        public CSVFileReader(string _filepath)
        {
            filePath = _filepath;
            products = new List<Product>();
        }
        public override List<Product> GetAllProducts()
        {
            File.ReadAllLines(filePath);

            foreach (var item in File.ReadAllLines(filePath))
            {
                items = item.Split(',');
                products.Add(new Toppings(Convert.ToInt16(items[0]), items[1], Convert.ToDecimal(items[2]), items[3]));

            }

            return products;

        }
    }
}
