using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniatm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 700;

            Console.WriteLine("ATM");

            Console.WriteLine("İşlem seç");
            Console.WriteLine("1-Bakiye görüntüle");
            Console.WriteLine("2-para çek");
            Console.WriteLine("3-para yatır");
            Console.WriteLine("4-çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Console.WriteLine("Bakiyeniz:" + bakiye);
                    Console.ReadLine();
                    break;
                    
                case "2":
                    Console.WriteLine("çekmek istediğin tutar");
                    int cekilecek_tutar = int.Parse(Console.ReadLine());

                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("kalan bakiyeniz" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }

                    break;
                   
                case "3":
                    Console.WriteLine("yatırmak istediğin tutarı gir");
                    int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni bakiyeniz" + (yatırılacak_tutar + bakiye));
                    Console.ReadLine();
                    break;
                    
                case "4":
                    Console.WriteLine("Çıkış yapıldı");
                    Console.ReadLine();
                    break;
                   
                default:
                    Console.WriteLine("lütfen işlem seç");
                    Console.ReadLine();
                    break;
                   

            }

        }
    }
}
