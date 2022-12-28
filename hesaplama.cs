using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesapla
{
    internal class Program
    {
        public static void Hesapla(string isim,string dogumYil,double dogumYilInt)
        {
            double aritmatikOrt = 0;
            double geometrikOrt = 0;

            double rakamtoplam = 0;
            double rakamcarpim = 1;

            if (isim.Length<4)
            {
                while (0 < dogumYilInt)
                {
                    rakamtoplam += (dogumYilInt % 10);
                    dogumYilInt = dogumYilInt / 10;
                }

                aritmatikOrt = rakamtoplam / 4;
                Console.WriteLine("Doğum yılınızın aritmatik ortalaması : "+aritmatikOrt);
            }

            else if (4<=isim.Length)
            {
                while (0<dogumYilInt)
                {
                    
                    for (int i = 0; i <((long)dogumYilInt); i++)
                    {
                        rakamcarpim *= (dogumYilInt % 10);                      
                        dogumYilInt /= 10;                      
                    }
                    break;              
                }
                geometrikOrt = Math.Pow(rakamcarpim, (0.25));
                Console.WriteLine("Doğum yılınızın geometrik ortalaması : " + geometrikOrt);
            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }
            
        }


        static void Main(string[] args)
        {
            Console.Write("Lütfen isminizi giriniz : ");
            string isim=Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Lütfen doğum yılınızı giriniz : ");
            string dogumYil=Console.ReadLine();
            double dogumYilInt = Convert.ToInt32(dogumYil);

            Console.Clear();

            Console.WriteLine(isim+";"+dogumYil);

            Console.WriteLine(" ");

            Hesapla(isim, dogumYil,dogumYilInt);

            Console.ReadLine();
        }
    }
}
