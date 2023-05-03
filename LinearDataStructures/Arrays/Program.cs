using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        // Arrays are stored sequentially in memory
        // items of array are stored next to eachother in sequence according to their index in the array

        public int Lookup(int[] arr, int index)
        {
            // Finding Item in an Array
            // Lookup ===> O(1) Runtime Complexity
            return arr[index];
        }
        public void Insert(int[] arr1, int[] arr2)
        {
            // Copy Array Items (Insert) ===> O(n) Runtime Complexity
            for (int i = 0; i < arr2.Length; i++)
            {
                arr1[i] = arr2[i];
            }
        }
        public void Delete(int[] arr)
        {
            // O(1)
            // Required delete last item (Best Case Senario)
            arr[arr.Length - 1] = 0;

            // O(n)
            // Required delete first item ( Worst Case Senario )
            // Array are static in Size & Datatype
            // You have to shift all items of the array to fill the gap in the first index
            // In this case it's better to use LinkedList which can grow or shrink dynamically
            arr[0] = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = 0;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 10, 20, 30 };
            Console.WriteLine(String.Join(",",numbers));
            Console.WriteLine($"Size of Array = {numbers.Length}");

            Console.WriteLine("-------------------------");
            Array<int> ids = new Array<int>(4);
            ids.insert(10);
            ids.insert(20);
            ids.insert(30);
            ids.insert(40);
            ids.insert(50);
            Console.WriteLine(ids.indexOf(20)); // 1
            Console.WriteLine(ids.indexOf(30)); // 2
            Console.WriteLine(ids.indexOf(200)); // -1
            ids.Print();
            ids.removeAt(0);
            ids.Print();
            ids.insert(60);
            ids.Print();
            Console.WriteLine(ids.indexOf(60));

            Console.WriteLine("-------------------------");
            Array<string> names = new Array<string>(4);
            names.insert("Lala");
            names.insert("Krkr");
            names.insert("Roro");
            names.insert("Moataz");
            names.insert("Samia");
            Console.WriteLine(names.indexOf("Krkr")); // 1
            Console.WriteLine(names.indexOf("Roro")); // 2
            Console.WriteLine(names.indexOf("Ali")); // -1
            names.Print();
            names.removeAt(0);
            names.Print();
            names.insert("Amal");
            names.Print();
            Console.WriteLine(names.indexOf("Amal"));
        }
    }
}
