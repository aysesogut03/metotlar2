using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz");
            int girilenSayi=Convert.ToInt32(Console.ReadLine());
            tekmiciftmi(girilenSayi);
            Console.ReadLine();
        }

        static void tekmiciftmi(int girilenSayi)
        {
            if(girilenSayi%2 == 0)
            {
                Console.WriteLine("Girilen sayı çift sayıdır");
            }
            else
            {
                Console.WriteLine("Girilen sayı tek sayıdır");
            }
        }
    }
}
