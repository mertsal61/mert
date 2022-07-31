using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tckontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TC kimlik No Giriniz");
            string tc= Console.ReadLine();
            employee _employee= new employee();
            _employee.tckn=tc;

            Console.WriteLine("TCKN"+_employee.tckn);

    }
    }
}
