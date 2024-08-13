using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace stajOrnekAtm
{
    class ATM
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 2 tane not alan ve bu notların ortalamasını bulan ve ortalaması eğer 
              80-100 arasındaysa A,
              60-80 arasındaysa B, 
              40-60 arasındaysa C yazdıran,
              40'tan küçükse F yazdıran örneğin kodlarını yazınız. */

            Console.WriteLine("1.NOT:");
            int birinciNot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.NOT:");
            int ikinciNot = Convert.ToInt32(Console.ReadLine());


            int sonuc = (birinciNot + ikinciNot) / 2;

            if (sonuc >= 80 && sonuc <=100)
            {
                Console.WriteLine("NOTUNUZ: A");
            }
           else if (sonuc>60 && sonuc < 80)
            {
                Console.WriteLine("NOTUNUZ: B");
            }
           else if (sonuc>40 && sonuc<60)
            {
                Console.WriteLine("NOTUNUZ: C");
            }
            else
            {
                Console.WriteLine("NOTUNUZ: F");
            }
        }
    }
}