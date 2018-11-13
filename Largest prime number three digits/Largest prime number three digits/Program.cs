using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_prime_number_three_digits
{
    class Program
    {
        static void prime()
        {
            bool active = false;
            for (int find=999 ; find >= 100 ; find--)
            {
                for (int i = 2 ; i < Math.Sqrt(find) && active == false ; i++)
                {
                    if (find % i == 0)
                    {
                        active = true;
                        break;
                    }
                }
                if (active == false)
                {
                    Console.WriteLine($"The number {find} is prime");
                    break;
                }
                else
                    active = false;
            }
        }
        static void Main(string[] args)
        {
            prime();
            Console.ReadKey();
        }
    }
}
