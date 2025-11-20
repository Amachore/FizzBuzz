using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz with a Twist");
            int[] border = { 1, 100 };
            Console.WriteLine($"Print numbers from {border[0]} to n with FizzBuzz rules and a twist.");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string word = "";

                if (i % 3 == 0) word += "Fizz";
                if (i % 5 == 0) word += "Buzz";
                if (i.ToString().Contains('3')) word += "Lucky";

                if (word == "") word = i.ToString();

                Console.WriteLine(word);
            }
        }
    }
}



/*
 * C# Challenge: "FizzBuzz with a Twist"
Write a program that:
- Asks the user to enter a number (n).
- Prints all numbers from 1 to n.
- For multiples of 3, print "Fizz" instead of the number.
- For multiples of 5, print "Buzz" instead of the number.
- For multiples of both 3 and 5, print "FizzBuzz".
- Bonus twist: If the number contains the digit 3, also print "Lucky".
*/