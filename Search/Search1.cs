using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Search1
    {
        static int[] arr;
        public Search1(int[] inputArray)
        {
            arr = inputArray;
        }
        // VIẾT THEO KIỂU TÌM KIẾM TUẦN TỰ 
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số chẵn lớn nhất đầu tiên
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số chẵn lớn nhất sau cùng
        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ lớn nhất đầu tiên

        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ lớn nhất sau cùng
        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số chẵn nhỏ nhất đầu tiên
        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số chẵn nhỏ nhất sau cùng
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ nhỏ nhất đầu tiên
        
        public static int SequentialSearchFirstOdd()
        {
            int index = -1;
            int minOdd = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] < minOdd)
                {
                    minOdd = arr[i];
                    index = i;
                }
            }

            return index;
        }
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ nhỏ nhất sau cùng
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số nguyên tố đầu tiên
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số nguyên tố sau cùng

        // VIẾT THEO KIỂU TÌM KIẾM NHỊ PHÂN
    }
}
