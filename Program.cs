using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndirimliFiyatHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Ali Amcanın Kitapçı Dükkanı *******");
            int x, indirim, odenecek;
            Console.Write("Alışverişinizin toplam tutarını girin:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Ürüne yapılacak indirim:"+ indirim);
                Console.WriteLine("Ürünün indirimli fiyatı:" + odenecek);
            }
            if (x >= 100 && x < 150)
            {
                indirim = x * 15 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Ürüne yapılacak indirim:" + indirim);
                Console.WriteLine("Ürünün indirimli fiyatı:" + odenecek);
            }
            if (x >= 150 && x < 200)
            {
                indirim = x * 20 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Ürüne yapılacak indirim:" + indirim);
                Console.WriteLine("Ürünün indirimli fiyatı:" + odenecek);
            }
            Console.ReadLine();
        }
    }

}