using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionaryList = new Dictionary<int, string>();

            Console.Write("Lütfen oluşturmak istediğiniz listenin boyutunu giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < boyut; i++)
            {
                Console.Write("Lütfen bir sayısal değer giriniz : ");
                int sayisalDeger = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                Console.Write("Lütfen girdiğiniz sayısal değeri yazınız : ");
                string sayisalDegerYazi = Console.ReadLine();

                if (dictionaryList.ContainsKey(sayisalDeger))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("!! Girdiğiniz değeri birden fazla giremezsiniz !!");
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    dictionaryList.Add(sayisalDeger, sayisalDegerYazi);
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.WriteLine("Sonuç : ");
            Console.WriteLine(" ");

            foreach (KeyValuePair<int, string> item in dictionaryList)
            {
                Console.WriteLine("Sayı : {0}  ||  Yazı : {1}", item.Key, item.Value);
            }

            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Write("Lütfen girdiğiniz listeden, silmek istediğiniz sayıyı giriniz :  ");
            int silme=Convert.ToInt32(Console.ReadLine());

            bool silmeSonuc = dictionaryList.Remove(silme);

            Console.WriteLine(" ");

            if (silmeSonuc)
            {
                Console.WriteLine("Girdiğiniz değer silindi.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz değer liste içinde bulunamadı, silme işlemi başarısız !");
            }
            Console.Clear();
            Console.WriteLine("Yeni Sonuç : ");
            Console.WriteLine(" ");

            foreach (KeyValuePair<int,string> item in dictionaryList)
            {
                Console.WriteLine("Sayı : {0}  ||  Yazı : {1}", item.Key, item.Value);
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Write("Lütfen değiştirmek istediğiniz yazıya karşılık gelen sayıyı giriniz : ");
            int degistirme=Convert.ToInt32(Console.ReadLine());

            bool degirstirmeSonuc=dictionaryList.ContainsKey(degistirme);

            if (degirstirmeSonuc)
            {
                string gelenDeger = dictionaryList[degistirme];
                Console.WriteLine(" ");
                Console.Write("Lütfen yeni metini giriniz : ");
                gelenDeger =Console.ReadLine();
                dictionaryList[degistirme] = gelenDeger;
            }

            else
            {
                Console.WriteLine("Girdiğiniz değer liste içresinde bulunamadı!");
            }
            Console.Clear();
            Console.WriteLine("Yeni Sonuç : ");
            Console.WriteLine(" ");

            foreach (KeyValuePair<int, string> item in dictionaryList)
            {
                Console.WriteLine("Sayı : {0}  ||  Yazı : {1}", item.Key, item.Value);
            }

            Console.ReadLine();
        }
    }
}
