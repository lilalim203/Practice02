// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Lila Lim!");

// 2 - Develop an algorithm that requests 3 numbers and calculates and prints the average.

using System;

namespace ReadLine2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string sinput1, sinput2, sinput3;
            int input1, input2, input3, sum, avg;

            Console.Write("\nInput the first number: ");
            sinput1 = Console.ReadLine();
            input1 = Convert.ToInt32(sinput1);
            //Console.WriteLine(input1);

            Console.Write("Input the second number: ");
            sinput2 = Console.ReadLine();
            input2 = Convert.ToInt32(sinput2);
            //Console.WriteLine(input2);

            Console.Write("Input the third number: ");
            sinput3 = Console.ReadLine();
            input3 = Convert.ToInt32(sinput3);
            //Console.WriteLine(input2);

            sum = input1+ input2+input3;
            avg = sum / 3;
           

            Console.WriteLine("\nThe avg of three inputs is " + avg);
        }
    }
}
