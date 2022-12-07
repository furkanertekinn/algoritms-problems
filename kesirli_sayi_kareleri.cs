using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeUygulam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pay = 1;
            decimal payda = 2;

            for (int i = 0; i<= 5; i++)
            {
                Console.WriteLine(pay + "/" + payda);
                pay = payda;
                payda = payda * payda;
                
            }
            Console.ReadLine();
        }
    }
}
