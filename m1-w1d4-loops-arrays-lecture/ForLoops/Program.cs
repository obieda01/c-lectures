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

            for (int x = 0; x < 10; x++) 
            {
                Console.WriteLine("Hello World");
            }
            

            //2. How would we print out the numbers 1 through 50 using a for loop?

            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
                        

            //3. How would we only print out odd numbers 1 through 50 using a for loop?

            for (int i = 1; i <=50; i = i +2)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();


            //4. How would we find the sum of even numbers 1 through 50 using a for loop?

            int sumOfEvens = 0;

            for(int i = 2; i <=50; i +=2)
            {
                sumOfEvens += i;
            }

            Console.Write(sumOfEvens);

                        
        }
    }
}
