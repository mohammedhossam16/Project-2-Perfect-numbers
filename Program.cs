using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_Perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start_num, end_num;

            Console.Write("Enter the start number of range : ");
            start_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number of range : ");
            end_num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("perfect numbers in given range are: ");

            for (int i = start_num; i <= end_num; i++)
            {
                int sum = 0;

                for (int t = 1; t < i; t++)
                {
                    if (i % t == 0)
                    {
                        sum = sum + t;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(". \t" + i);

                }
            }
        }
    }
}
