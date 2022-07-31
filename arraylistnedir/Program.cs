using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistnedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("A");
            koleksiyon.Add("B");
            koleksiyon.Add("C");
            koleksiyon.Add("D");
            
            koleksiyon.Insert(2, "sercan");
            koleksiyon.Reverse();
            koleksiyon.Sort();

            foreach (object a in koleksiyon)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("var mı");
            Console.ReadLine();


        }
    }
}
