using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5, secondNumber = 10;
            Console.WriteLine("Before Swapping:");
            Console.WriteLine("firstNumber= " + firstNumber);
            Console.WriteLine("secondNumber= " + secondNumber);

            //Swap using mathematical operations
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("firstNumber= " + firstNumber);
            Console.WriteLine("secondNumber= " + secondNumber);




        }
    }
}
