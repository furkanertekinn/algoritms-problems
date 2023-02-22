using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{
    class Program
    {
        delegate void MatematikselIslemler(int sayi1, int sayi2);

        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama işleminin sonucu : " + sonuc);
        }

        static void Cikartma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu : " + sonuc);
        }

        static void Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu : " + sonuc);
        }
        static void Main(string[] args)
        {
            MatematikselIslemler M1 = new MatematikselIslemler(Topla);
            M1 += Cikartma;
            M1 += Carpma;

            // M1.Invoke(20, 2);

            Delegate[] isaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var item in isaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Carpma;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cikartma;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 += Carpma;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 += Cikartma;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.ReadLine();
        }
    }
}
