using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir boy değeri giriniz : ");
            int boy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen bir en değeri giriniz : ");
            int en = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Sonuç : ");

            Console.WriteLine(" ");

            for (int i = 1; i <= boy; i++)
            {
                for (int j = 1; j <= en; j++)
                {
                    if (i == 1 || i == boy)
                        Console.Write("*");
                    else
                        if (j == 1 || j == en)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }         
            Console.ReadLine();
        }
    }
}
