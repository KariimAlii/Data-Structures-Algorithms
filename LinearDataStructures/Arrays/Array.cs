using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array<T>
    {
        T[] items;
        int currentIndex;
        public static readonly IComparer<T> comparer = Comparer<T>.Default;
        public Array (int length)
        {
            items = new T[length];
            currentIndex = 0;
        }

        // O(n)
        public void insert(T item)
        {
            if (currentIndex == items.Length ) // array is full
            {
                int newLength = items.Length + 1;
                T[] newArray = new T[newLength];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                newArray[newLength - 1] = item;
                items = newArray;
            }
            else if (currentIndex < items.Length )
            {
                items[currentIndex] = item;
                currentIndex++;
            }
        }

        // O(n)
        public void removeAt(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                int newLength = items.Length - 1;
                T[] newArray = new T[newLength];
                for (int i = 0, j = 0; i < items.Length && j < newArray.Length; i++, j++)
                {
                    if (i != index)
                    {
                        newArray[j] = items[i];
                    }
                    else
                    {
                        j--;
                    }
                }
                items = newArray;
            }
            else
            {
                throw new IndexOutOfRangeException(); // to stop the execution of the program
            }
        }


        // O(n)
        public int indexOf(T item)
        {
            int required = -1;
            for (int i = 0;i < items.Length;i++)
            {
                if  (comparer.Compare(items[i], item) == 0) // if they are equal ==> returns zero
                {
                    required = i;
                    break;
                }
            }
            return required;
            // https://stackoverflow.com/questions/72098900/c-sharp-gives-cs0019-error-operator-cannot-be-applied-to-operands-of-type-t-a
            // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.comparer-1?view=net-8.0
            // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.comparer-1.compare?view=net-7.0
        }

        // O(1)
        public void Print()
        {
            Console.WriteLine(String.Join(",", items));
        }
    }
}



//public void removeAt(int index)
//{
//    if (index >= 0 && index < items.Length)
//    {
//        for (int i = index; i < currentIndex; i++)
//        {
//            items[i] = items[i + 1];
//            items[currentIndex] = default; // === default(T) // https://www.pluralsight.com/guides/automatic-default-values-for-variables-in-c
//            currentIndex--;
//        }
//    }
//    else
//    {
//        throw new IndexOutOfRangeException();
//    }
//}