using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pay = 1;
            int payda = 2;

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(pay + "/" + payda);
                pay++;
                payda++;
                if (i==5)
                {
                    pay++;
                    payda++;
                }
            }
            Console.ReadLine();
        }
    }
}
