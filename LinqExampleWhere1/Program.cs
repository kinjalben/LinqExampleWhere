using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExampleWhere1
{//where to find all the elements of an array less then 5
    class Program   
    {
        static void Main(string[] args)
        {

            int[] arr = {1, 2, 3, 6, 7, 8, 9, 0};

            var lownum = from n in arr where n < 5 select n;

            Console.WriteLine("This number is less then 5:");

            foreach (var y in lownum)
            {
                Console.WriteLine(y);
            }



        }
        // select the item where product are out of sock
         static void Main()
        {
            List<Product> products = GetPoductList();

            var soldOutProduct = from p in products where p.UnitInStock == 0 select p;

            Console.WriteLine("Sold out products:");

            foreach (var Product in soldOutProduct) 
            {
                Console.WriteLine("{0} sold out", products.ProductName);
            }


        }
    }

}
