using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeUygulama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine(" ");
            Console.Write("Lütfen bir değer giriniz (1<=değer<=365 olmaası gerekir): ");
            
            string kullaniciDeger = Console.ReadLine();
            int kullaniciDegerInt = Convert.ToInt32(kullaniciDeger);

            int sayi1 = kullaniciDegerInt;
            int sayi2 = 7;

            int mod=sayi1 % sayi2;
            

            if (1<=kullaniciDegerInt && kullaniciDegerInt<=365) 
            {
                Console.WriteLine(" ");
                switch (mod)
                {
                    case 1:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Pazar günüdür", kullaniciDegerInt);
                        break;
                    case 2:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Pazartesi günüdür", kullaniciDegerInt);
                        break;
                    case 3:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Salı günüdür", kullaniciDegerInt);
                        break;
                    case 4:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Çarşamba günüdür", kullaniciDegerInt);
                        break;
                    case 5:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Perşembe günüdür", kullaniciDegerInt);
                        break;
                    case 6:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Cuma günüdür", kullaniciDegerInt);
                        break;
                    default:
                        Console.WriteLine("Bugün cumartesi {0} gün sonra Cumartesi günüdür", kullaniciDegerInt);
                        break;
                }
                Console.ReadLine();

            }
           
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen belirtilen koşullara uygun giriş yapınız!");
                Console.ReadLine();
            }

            



        }
    }
}
