using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 6, 8, 1, 9, 3, 5, 9, 12, 5, 11, 13, 1 };
            Sort.XuatMang(arr);

            //Sort.QuickSortIterative(arr, 0, arr.Length - 1);
            Sort.XuatMang(arr);
            Console.ReadKey();

        }
    }
}
