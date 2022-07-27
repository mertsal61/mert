using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenkitleindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double endex = kilo / (boy * boy);

            if (endex <= 18)
            {
                Console.WriteLine("ZAYIFSINIZ");
            }
            else if (endex >=18 && endex <=25)
            {
                Console.WriteLine("NORMALSINIZ");
            }
            else if(endex>25)
            {
                Console.WriteLine("OBEZSINIZ");
            }
            Console.ReadLine();


        }
    }
}
