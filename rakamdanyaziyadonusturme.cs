using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakamdanYaziyaDonusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("HATIRLATMA : Lütfen girilen sayının en fazla dört basamaklı olduğuna dikkat ediniz !");

            Console.WriteLine(" ");

            Console.Write("Girmiş olduğunuz sayının yazımı : ");

            if (sayi <= 9999 || 0 <= sayi) 
            {
                switch (sayi/1000)
                {
                    case 1:
                        Console.Write("Bin");
                        break;
                    case 2:
                        Console.Write("İkibin");
                        break;
                    case 3:
                        Console.Write("Üçbin");
                        break;
                    case 4:
                        Console.Write("Dörtbin");
                        break;
                    case 5:
                        Console.Write("Beşbin");
                        break;
                    case 6:
                        Console.Write("Altıbin");
                        break;
                    case 7:
                        Console.Write("Yedibin");
                        break;
                    case 8:
                        Console.Write("Sekizbin");
                        break;
                    case 9:
                        Console.Write("Dokuzbin");
                        break;
                }

                switch ((sayi%1000)/100)
                {
                    case 1:
                        Console.Write("Yüz");
                        break;
                    case 2:
                        Console.Write("İkiyüz");
                        break;
                    case 3:
                        Console.Write("Üçyüz");
                        break;
                    case 4:
                        Console.Write("Dörtyüz");
                        break;
                    case 5:
                        Console.Write("Beşyüz");
                        break;
                    case 6:
                        Console.Write("Altıyüz");
                        break;
                    case 7:
                        Console.Write("Yediyüz");
                        break;
                    case 8:
                        Console.Write("Sekizyüz");
                        break;
                    case 9:
                        Console.Write("Dokuzyüz");
                        break;
                }

                switch ((sayi%100)/10)
                {
                    case 1:
                        Console.WriteLine("On");
                        break;
                    case 2:
                        Console.Write("Yirmi");
                        break;
                    case 3:
                        Console.Write("Otuz");
                        break;
                    case 4:
                        Console.Write("Kırk");
                        break;
                    case 5:
                        Console.Write("Elli");
                        break;
                    case 6:
                        Console.Write("Altmış");
                        break;
                    case 7:
                        Console.Write("Yetmiş");
                        break;
                    case 8:
                        Console.Write("Seksen");
                        break;
                    case 9:
                        Console.Write("Doksan");
                        break;
                }

                switch (sayi%10)
                {
                    case 1:
                        Console.Write("Bir");
                        break;
                    case 2:
                        Console.Write("İki");
                        break;
                    case 3:
                        Console.Write("Üç");
                        break;
                    case 4:
                        Console.Write("Dört");
                        break;
                    case 5:
                        Console.Write("Beş");
                        break;
                    case 6:
                        Console.Write("Altı");
                        break;
                    case 7:
                        Console.Write("Yedi");
                        break;
                    case 8:
                        Console.Write("Sekiz");
                        break;
                    case 9:
                        Console.Write("Dokuz");
                        break;
                }
                if (sayi==0)
                {
                    Console.WriteLine("Sıfır");
                }

            }
            
            else
            {
                Console.WriteLine("İstenilen değer aralığında giriş yapmadınız!");
            }

            Console.ReadLine();
        }
    }
}
