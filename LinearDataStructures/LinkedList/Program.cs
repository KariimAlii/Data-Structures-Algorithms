using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    // https://the-algorithms.com/category/linkedlist
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.addFirst(3);
            list.addFirst(2);
            list.addFirst(1);

            list.addLast(4);
            list.addLast(5);
            list.addLast(6);
            list.print();
            list.removeFirst();
            list.print();
            list.removeLast();
            list.print();
            Console.WriteLine(list.indexOf(4));
            Console.WriteLine(list.indexOf(7));
            Console.WriteLine(list.contains(4));
            Console.WriteLine(list.contains(7));

            list.print();
            Console.WriteLine("List Size = " + list.size());
            list.addLast(13);
            list.print();
            Console.WriteLine("List Size = " + list.size());

            list.printArray();
            list.print();
            Console.WriteLine("=====Reversing Odd=====");
            list.reverse();
            list.printArray(); // odd number of items
            Console.WriteLine("=====Adding item=====");
            list.addLast(30);
            list.printArray();
            Console.WriteLine("=====Reversing Even=====");
            list.reverse();
            list.printArray(); // even number of items


            SingleLinkedList emptyList = new SingleLinkedList();
            Console.WriteLine("=====Reversing Empyy List=====");
            emptyList.reverse();
            emptyList.printArray();

            SingleLinkedList list2 = new SingleLinkedList();
            list2.addLast(10);
            list2.addLast(20);
            list2.addLast(30);
            list2.addLast(40);
            list2.addLast(50);
            list2.addLast(60);
            list2.addLast(70);
            list2.print();
            Console.WriteLine(list2.getKthFromTheEnd(7));
            //Console.WriteLine(emptyList.getKthFromTheEnd(2)); // Exception
        }
    }
}
