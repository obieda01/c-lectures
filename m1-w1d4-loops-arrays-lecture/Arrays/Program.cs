using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create an array of integers that can hold quiz scores 

            int[] quizScores = new int[100];

            int arrayLength = quizScores.Length;

            //2. Create an array of strings that can hold the names of instructors at TE

            string[] instructorNames = { "John", "Joe", "Casey" };

            //3. Create an array of characters that hold "Tech Elevator"    

            char[] teChar = { 'T', 'e', 'c', 'h', ' ' };

            //4. Print out the 0th item in each array
            Console.WriteLine(quizScores[0]);

            //5. Print out the 3rd item in each array
            Console.WriteLine(quizScores[2]);

            //6. Get the length of each array
            int x = quizScores.Length;

            //7. Get the last index for each array
            int y = quizScores.Length - 1;

            //6. Update the last item in each array
            quizScores[quizScores.Length - 1] = 7;

            //7. Loop over an array's contents and print each item out to the screen

            //8. Loop over an array and print every other item out to the screen

        }
    }
}
