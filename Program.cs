using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace stajOrnekAtm
{
    class ATM
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;
            /* İŞLEMLER: 
            1-BAKİYE GÖRÜNTÜLEME
            2- PARA ÇEKME
            3- PARA YATIRMA
            9- ÇIKIŞ. */

            Console.WriteLine("Hoşgeldiniz. Lütfen yapmak istediğiniz işlemi seçiniz:\n   1-BAKİYE GÖRÜNTÜLEME\r\n  2- PARA ÇEKME\r\n 3- PARA YATIRMA\r\n   9- ÇIKIŞ.");
            String secim = Console.ReadLine();

            if (secim == "1") 
            {
                Console.WriteLine("Güncel Bakiyeniz: " + bakiye);
            }
            else if (secim == "2") 
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecekTutar <= bakiye)
                {
                    Console.WriteLine("Kalan Tutar: " + (bakiye - cekilecekTutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyeniz bu işlem için yetersiz.");
                    Console.ReadLine(); 
                }
            }
            else if (secim == "3") 
           {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int yatiralacakTutar = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("Para yatırma işleminiz başarılı. Yeni bakiyeniz: " + (bakiye + yatiralacakTutar));
           }
            else if (secim == "9"){
                Console.Write("Çıkış yapılıyor. İYİ GÜNLER");
            
            }
            else
            {
                Console.WriteLine("Geçersiz işlem.");
            }


        } 
    } 
}
