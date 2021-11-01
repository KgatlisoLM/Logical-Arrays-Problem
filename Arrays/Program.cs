using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            var common = list1.Intersect(list2);

            foreach (int list3 in common)
            {
                Console.WriteLine(string.Join(",", list3));
            }

            var list4 = list1.Except(list2);
            Console.WriteLine(string.Join(",", list4));

            var list5 = list2.Except(list1);
            Console.WriteLine(string.Join(",", list5));

            Console.WriteLine("Press <ENTER> to continue");

            Console.ReadLine();
        }
    }
}
