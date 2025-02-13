using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Reversed number: " + Reverse(number));
            Console.ReadKey();
        }

        static int Reverse(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            return (number % 10) * (int)Math.Pow(10, (int)Math.Log10(number)) + Reverse(number / 10);
        }
    }
}
