using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O_Notation
{
    internal class Program
    {
        public void oLinear(int[] numbers)
        {
            // O(1)
            // Only Single Operation
            Console.WriteLine(numbers[0]);   // O(1)
            Console.WriteLine(numbers[0]);   // O(1)
            Console.WriteLine(numbers[0]);   // O(1)
            // O(1 + 1 + 1) = O (3) ====drop the constant======> O (1)
        }
        public void oN(int[] numbers)
        {
            // O(n)
            // Loop
            for (int i = 0; i < numbers.Length; i++)  // O(n)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++) // O(n)
            {
                Console.WriteLine(numbers[i]);
            }

            // O(n + n) = O (2n) ====drop the constant======> O (n)
        }
        public void oN(int[] numbers, string[] names)
        {
            // O(n)
            // Loop
            for (int i = 0; i < numbers.Length; i++)  // O(n)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < names.Length; i++)  // O(m)
            {
                Console.WriteLine(names[i]);
            }
            // O(n + m)  ====still increases linearly======> O (n)
        }
        public void oN2(int[] numbers)
        {

            // O(n^2)
            // Nested Loop

            //Ex1

            for (int i = 0; i < numbers.Length; i++)  // O(n)
            {
                for (int j = 0; j < numbers.Length; j++)  // O(n)
                {
                    Console.WriteLine(numbers[j]);
                }

            }

            // O(n * n )  ====Quadratic======> O (n^2)

            //EX2
            for (int i = 0; i < numbers.Length; i++)  // O(n)
            {
                for (int j = 0; j < numbers.Length; j++)  // O(n)
                {
                    Console.WriteLine(numbers[j]);
                }

            }
            for (int j = 0; j < numbers.Length; j++)  // O(n)
            {
                Console.WriteLine(numbers[j]);
            }

            // O(n * n + n) = O(n^2 + n)  ====simplify======> O (n^2)



        }
        public void oN3(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)  // O(n)
            {
                for (int j = 0; j < numbers.Length; j++)  // O(n)
                {
                    for (int k = 0; k < numbers.Length; k++)  // O(n)
                    {
                        Console.WriteLine(numbers[k]);
                    }
                }

            }
            // O(n * n * n)  ====Cubic======> O (n^3)
        }
        public void oLogN(int[] numbers)
        {
            // Logarithmic
            // O(log N)

            // Ex:Binary Search
        }
        public void o2n()
        {
            // Exponential
            // opposite of logarithmic growth
            // O(2^n)
        }

        // Space Complexity O(x)
        // The Additional space we need to allocate relative to the size of the input
        public void greet(String[] names)
        {
            // O(1) space
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hi " + names[i]);
            }
            // Declaring a loop variable (i) is independent of length of the array
            // whether the array have 10 elements or 1000000 elements
            // we will declare and allocate some special memory for only one loop variable (i) in memory in both cases
        }
        public void greet2(String[] names)
        {
            // O(n) space
            string[] copy = new string[names.Length];
            // the copy array length = names array length = n
            // the more items we have in our input array ===> the more space the method will take in memory
            // Direct propotion between size of input and the method memory consuming
            for (int i = 0; i < copy.Length; i++)
            {
                Console.WriteLine("Hi " + copy[i]);
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
