using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePlace
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1_A Write a program that receives two numbers, and prints them with the screen.
            //The program then replaces the numbers and prints them again(you should see that the numbers have been replaced)

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} and {1},{1} and {2}", number1, number2);

            Console.ReadKey();
        }
    }
}
