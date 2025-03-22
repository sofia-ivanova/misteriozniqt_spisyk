using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misteriozniqt_spisyk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>(new int[] { 42, 7, 19, 3, 88, 56 });

            Console.WriteLine("Създаден списък:");
            DisplayList(numbers);

            SearchNumber(numbers, 19);
            SearchNumber(numbers, 100);

            numbers = ReverseLinkedList(numbers);
            Console.WriteLine("Обърнат списък:");
            DisplayList(numbers);

            RemoveNumber(numbers, 42);
            Console.WriteLine("Списък след премахване на 42:");
            DisplayList(numbers);

            LinkedList<int> list1 = new LinkedList<int>(new int[] { 1, 5, 10 });
            LinkedList<int> list2 = new LinkedList<int>(new int[] { 2, 6, 12 });
            LinkedList<int> merged = MergeSortedLists(list1, list2);
            Console.WriteLine("Слят списък:");
            DisplayList(merged);

            Console.ReadKey();
        }
        static void SearchNumber(LinkedList<int> list, int num)
        {
            if (list.Contains(num))
                Console.WriteLine($"Числото {num} е в списъка.");
            else
                Console.WriteLine($"Числото {num} липсва.");
        }
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();
            foreach (var number in list)
            {
                reversed.AddFirst(number);
            }
            return reversed;
        }
        static void RemoveNumber(LinkedList<int> list, int num)
        {
            list.Remove(num);
            Console.WriteLine($"Числото {num} е премахнато.");
        }
        static LinkedList<int> MergeSortedLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            List<int> combined = new List<int>();

            combined.AddRange(list1);
            combined.AddRange(list2);

            combined.Sort();

            LinkedList<int> result = new LinkedList<int>(combined);

            return result;
        }
        static void DisplayList(LinkedList<int> list)
        {
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
