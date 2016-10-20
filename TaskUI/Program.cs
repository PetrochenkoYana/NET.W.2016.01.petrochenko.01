using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bs = null;
            Task1.BinarySearch.Search(bs, 40);
            int[] bs2 = new int[0];
            Task1.BinarySearch.Search(bs2, 30);
            bs = new int[] { 7 };
            Task1.BinarySearch.Search(bs, 7);
            Task1.BinarySearch.Search(bs, 15);
            bs = new int[] { 7, 15, 30, 45 };
            Task1.BinarySearch.Search(bs, -30);
            Task1.BinarySearch.Search(bs, 7);
            Task1.BinarySearch.Search(bs, 12);
            Task1.BinarySearch.Search(bs, 20);
            Task1.BinarySearch.Search(bs, 30);
            bs = new int[] { -16, -9, -5, 0, 3, 7, 12, 18, 20, 24, 30, 32, 38, 47, 50 };
            Task1.BinarySearch.Search(bs, -30);
            Task1.BinarySearch.Search(bs, -16);
            Task1.BinarySearch.Search(bs, 7);
            Task1.BinarySearch.Search(bs, 20);
            Task1.BinarySearch.Search(bs, 24);
            Task1.BinarySearch.Search(bs, 40);
            Task1.BinarySearch.Search(bs, 50);
            Task1.BinarySearch.Search(bs, 60);
            Console.ReadKey();
            int[] array = { 3, 4, 7, 3, 2, 67, 78, 68, 89, 7, 9, 4, 89, 65, 7, 8 };
            int[] array2 = null;
            Array.Sort(array);
            int res = Task1.BinarySearch.Search(array, 5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
