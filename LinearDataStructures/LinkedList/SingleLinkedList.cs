using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class SingleLinkedList
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; } // a reference to the next node
            public Node(int value)
            {
                Value = value;
            }
        }

        private Node Head;
        private Node Tail;
        private int count = 0;
        public void addFirst(int value)
        {
            Node node = new Node(value);

            if (isEmpty()) // empty linkedlist
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            count++;
        }
        public void addLast(int value)
        {
            Node node = new Node(value);
            if (isEmpty()) // empty linkedlist
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            count++;
        }
        public void removeFirst()
        {
            if (isEmpty()) throw new Exception("The Linked List has no Nodes to remove"); // empty list
            else if (Head == Tail) Head = Tail = null; // a single node
            else // more than one node
            {
                Node deletedNode = Head;
                Head = Head.Next;
                deletedNode.Next = null;
            }
            count--;
        }
        public void removeLast()
        {
            if (isEmpty()) throw new Exception("The Linked List has no Nodes to remove");
            else if (Head == Tail) Head = Tail = null; // a single node
            else // more than one node
            {
                Node previous = getPreviousNode(Tail);
                previous.Next = null;
                Tail = previous;
            }
            count--;
        }
        public bool contains(int value)
        {
            Node pointer = Head;
            while (pointer != null)
            {
                if (pointer.Value == value) return true; // i found the required node
                pointer = pointer.Next;
            }
            return false; // I didn't find the node ==> I moved outside the linked list
        }
        public int indexOf(int value)
        {
            int index = 0;
            Node pointer = Head;
            while (pointer != null)
            {
                if (pointer.Value == value) return index; // i found the required node
                pointer = pointer.Next;
                index++;
            }
            return -1; // I didn't find the node ==> I moved outside the linked list
        }

        // O(n)
        //public int size()
        //{
        //    int count = 0;
        //    Node pointer = Head;
        //    while (pointer != null)
        //    {
        //        count++;
        //        pointer = pointer.Next;
        //    }
        //    return count;
        //}

        // O(1)
        public int size()
        {
            return count;
        }

        public void print()
        {
            if (!isEmpty())
            {
                Node pointer = Head;
                while (pointer != Tail) // move until you reach  the last node
                {
                    Console.Write($"{pointer.Value},");
                    pointer = pointer.Next;
                }
                if (pointer == Tail) Console.Write($"{pointer.Value}");
                Console.WriteLine();
            }
            else throw new Exception("The Linkedlist has no Nodes to print");
        }
        public int[] toArray()
        {
            int index = 0;
            int[] result = new int[count];
            Node pointer = Head;
            while (pointer != null) // move until you go outside the linked list
            {
                result[index] = pointer.Value;
                pointer = pointer.Next;
                index++;
            }
            return result;
        }
        public void printArray()
        {
            var result = toArray();
            Console.WriteLine(String.Join(",", result));
        }
        // Reverse a LinkedList
        //public void reverse()
        //{
        //    Node current = Head;
        //    Node previous = null;

        //    Tail = current;

        //    while (current != null)
        //    {
        //        Head = previous;
        //        previous = current;
        //        current = current.Next;
        //        previous.Next = Head;
        //    }
        //    Head = previous;
        //}
        public void reverse()
        {
            if (isEmpty()) return;
            Node previous = Head;
            Node current = Head.Next;

            while (current != null)
            {
                Node next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            // Reversing Head & Tail
            Tail = Head;
            Tail.Next = null;
            Head = previous;
        }
        public int getKthFromTheEnd(int k)
        {
            if (isEmpty()) throw new Exception("The List is Empty");
            //if (k > size()) throw new Exception("Out of list boundaries");
            Node previous = Head;
            Node current = Head;
            for (int i = 1;i < k;i++)
            {
                if (current.Next != null)
                    current = current.Next;
                else
                    throw new Exception("Out of list boundaries");
            }
            while (current != Tail)
            {
                previous = previous.Next;
                current = current.Next;
            }
            return previous.Value;
        }
        private bool isEmpty()
        {
            return Head == null;
        }
        private Node getPreviousNode(Node node)
        {
            Node pointer = Head;
            while (pointer != null)
            {
                if (pointer.Next == node) return pointer; // i found the required node
                pointer = pointer.Next;
            }
            return null; // I didn't find the node ==> I moved outside the linked list
        }

    }

}
