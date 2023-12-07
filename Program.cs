using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    // Star pattern with no extra space at start
                    if (i == j)
                    {
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write(" ");
                }

                // Star pattern with extra space at start
                //for (int k = 1; k <= i; k++)
                //{
                //    Console.Write("*");
                //}
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
