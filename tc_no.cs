using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TcKimliNo2
{
    public class Program
    {
        public static int Olustur(string TcKimlikNo2)
        {
            
            int[,] array= new int[3,3];

            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = Convert.ToInt32(TcKimlikNo2.Substring(k,1));
                    k++;
                }

            }

            int sonİkisayi=Convert.ToInt32(TcKimlikNo2.Substring(9,2));

            if (sonİkisayi > 50)
            {
                int[] sutun = new int[3];
                int sonuc = 0;

                for (int i = 0; i < sutun.Length; i++)
                {
                    for (int j = 0; j < sutun.Length; j++)
                    {
                        sonuc = sonuc + array[j, i];
                    }
                    sutun[i] = sonuc;
                    sonuc = 0;
                }

                int enbuyuk = sutun[0];
                for (int i = 0; i < sutun.Length; i++)
                {
                    if (sutun[i]>enbuyuk)
                    {
                        enbuyuk = sutun[i];
                    }
                    
                }
                return enbuyuk;
            }

            else if (sonİkisayi < 50)
            {
                int[] satir = new int[3];
                int sonuc = 0;

                for (int i = 0; i < satir.Length; i++)
                {
                    for (int j = 0; j < satir.Length; j++)
                    {
                        sonuc = sonuc + array[i, j];
                    }
                    satir[i] = sonuc;
                    sonuc = 0;
                }

                int enkucuk = satir[0];
                for (int i = 0; i < satir.Length; i++)
                {
                    if (satir[i]<enkucuk)
                    {
                        enkucuk = satir[i];
                    }

                }
                
                return enkucuk;
                
            }
            else
            {
                return 0;
            }
            
        }
        public static void Main(string[] args)
        {

            string TcKimlikNo1 = string.Empty;

            while (true)
            {
                Console.Write("Lütfen Tc kimlik numaranızı giriniz : ");
                TcKimlikNo1 = Console.ReadLine();

                if (TcKimlikNo1.Length != 11)
                {
                    Console.WriteLine("Tc Kimlik Numaranızı eksik veya fazla girdiniz!");
                   
                }
                else if (TcKimlikNo1.Length==11)
                {
                    Console.WriteLine(Olustur(TcKimlikNo1));

                    Console.WriteLine("Yeni bir değer girmek istiyor musunuz? (E/H)");
                    string kullaniciSecim = Console.ReadLine();

                    if (kullaniciSecim.ToUpper() == "E")
                    {
                        Console.Clear();
                        continue;
                    }

                    else if (kullaniciSecim.ToUpper() == "H")
                    {
                        Console.WriteLine("İşleminiz sonlandı,iyi günler dileriz.");
                        break;

                    }

                    else
                    {
                        Console.WriteLine("Lütfen istenilen harflerden birini giriniz!");
                    }
                }

            }

            

           
           

            Console.ReadLine();
        }
    }
}
