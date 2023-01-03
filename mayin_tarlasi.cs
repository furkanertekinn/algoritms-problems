using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    internal class Program
    {
        public static void MayinTarlasi(int satir,int sutun)
        {
            Console.WriteLine("Sonuç:");
            Random rnd= new Random();
            

            int[,] array = new int[satir,sutun];

            for (int i = 0; i < satir; i++)
            {
                Console.WriteLine(" ");

                for (int j = 0; j < sutun; j++)
                {
                    int rastgeleSayi = rnd.Next(0, 2);
                    array[i, j] = rastgeleSayi;
                    Console.Write("[{0}][{1}] = {2} ", i, j,rastgeleSayi);
                    
                    Console.WriteLine();
                }
                Console.Write("-----------------------");          
                
            }
            Console.WriteLine(" ");

            int puan = 0;
          
            bool kontrol = true;

            while (kontrol)
            {
                Console.Write("Lütfen lokasyonunuzun satır değerini giriniz : ");
                int lokasyonSatir = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lütfen lokasyonunuzun sütun değerini giriniz : ");
                int lokasyonSutun = Convert.ToInt32(Console.ReadLine());

                if (array[lokasyonSatir,lokasyonSutun]==0)
                {
                    puan = puan + 10;
                    Console.WriteLine("Hala hayattasın...Devam");
                }
                else if (array[lokasyonSatir, lokasyonSutun] ==1)
                {
                    Console.WriteLine("Oyun bitti puanınız : " + puan);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz");
                }
                
            }            
        }

        static void Main(string[] args)
        {
            Console.Write("Lütfen satır uzunluğunu giriniz : ");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Lütfen sütun uzunluğunu giriniz : ");
            int sutun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            
            MayinTarlasi(satir,sutun);

            Console.ReadLine();

        }
    }
}
