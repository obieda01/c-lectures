using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. How would we print out "Hello World" 10 times using a for loop?

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
            Console.WriteLine("\n\n");

            //2. How would we print out the numbers 1 through 50 using a for loop?

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }

            //3. How would we only print out odd numbers 1 through 50 using a for loop?
            Console.WriteLine("\n\n");

            for (int i = 1; i <= 50; i=i+2)
            {
                Console.WriteLine(i);
            }

            //4. How would we find the sum of even numbers 1 through 50 using a for loop?
            int sumOfEven = 0;
            for (int i = 2; i <= 50; i = i + 2)
            {
                sumOfEven += i;
            }

            Console.WriteLine("\n\n" + sumOfEven);
                        
        }
    }
}
