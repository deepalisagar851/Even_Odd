using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            }
        }
    }

