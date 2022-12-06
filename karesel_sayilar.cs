using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeUyguluma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dPay;
            decimal dPayda; 
            while (true)
            {
                Console.Write("Lütfen pay değerini giriniz :");
                string pay = Console.ReadLine();

                Console.WriteLine(" ");

                Console.Write("Lütfen payda değerini giriniz :");
                string payda = Console.ReadLine();

                dPay = Convert.ToDecimal(pay);
                dPayda = Convert.ToDecimal(payda);

                if (dPay<0 || dPayda<0)
                {
                    Console.WriteLine("Geçersiz değer girdiniz!");
                }

                else
                {
                    break;
                }
            }

            if (dPayda==0)
            {
                Console.WriteLine("Payda sıfır olamaz!");
                Console.ReadLine();
            }
            else
            {
                decimal bolme = dPay / dPayda;
                Console.WriteLine(" ");
                Console.WriteLine("Sonuç : " + (dPay / dPayda));

                Console.WriteLine(" ");

                if (dPay < dPayda)
                {
                    Console.WriteLine("Basit kesir girdiniz.");
                }

                else if (dPay == dPayda)
                {
                    Console.WriteLine("Girdiğiniz değer bir tamsayıdır.");
                }

                else
                {
                    Console.WriteLine("Bileşik bir kesir girdiniz kesir değeri X tam Y/Z");
                }
                Console.ReadLine();
            }
        }
    }
}
