using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiDongusu klavye=new SayiDongusu();
            klavye.ToplamaMetod();
        }
    }
    public class SayiDongusu
    {
        public void ToplamaMetod()
        {
            int sayi, toplam = 0;
            while (true)
            {
                Console.Write("Sayı giriniz: ");
                sayi=Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine("Gidiniz sayının toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
