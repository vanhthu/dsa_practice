using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai1_Search
{
    internal class Search
    {
        // 1.1
        public static int TimPhanTuDauTien(int[] arr, int X)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == X)
                    return i;
            return -1;
        }

        // 1.2
        public static int TimPhanTuSauCung(int[] arr, int X)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
                if (arr[i] == X)
                    return i;
            return -1;
        }

        // 1.3
        public static int[] TimTatCaPhanTu(int[] arr, int X)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == X)
                    list.Add(i);
            return list.ToArray();
        }

        // 1.4
        public static int TimPhanTuNhoNhatDauTien(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[i])
                        index = j;
            return index;
        }

        // 1.5
        public static int TimPhanTuLonNhatSauCung(int[] arr)
        {
            int index = arr.Length - 1;
            for (int i = arr.Length - 1; i > 0; i--)
                for (int j = i - 1; j >= 0; j--)
                    if (arr[j] > arr[i])
                        index = j;
            return index;
        }

        // 1.6
        public static int[] TimTatCaCacSoNhoNhat(int[] arr)
        {
            List<int> list = new List<int>();
            int indexMin = TimPhanTuNhoNhatDauTien(arr);
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == arr[indexMin])
                    list.Add(i);
            return list.ToArray();
        }

        // 1.7
        public static int TimPhanTuLeLonNhatDauTien(int[] arr)
        {
            int index = -1;
            if (arr.Length > 0)
            {
                if (arr[0] % 2 != 0)
                    index = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (index == -1)
                        if (arr[i] % 2 != 0)
                        {
                            index = i;
                            continue;
                        }
                    if (arr[i] % 2 != 0)
                        if (arr[i] > arr[index])
                            index = i;
                }
            }
            return index;
        }

        // 1.8
        public static int TimPhanTuChanLonNhatSauCung(int[] arr)
        {
            int index = -1;
            if (arr.Length > 0)
            {
                if (arr[arr.Length - 1] % 2 == 0)
                    index = arr.Length - 1;
                for (int i = arr.Length - 2; i >= 0; i--)
                {
                    if (index == -1)
                        if (arr[i] % 2 == 0)
                        {
                            index = i;
                            continue;
                        }
                    if (arr[i] % 2 == 0)
                        if (arr[i] > arr[index])
                            index = i;
                }
            }
            return index;
        }

        //1.9
        public static int[] TimPhanTuX_Lap(int[] arr, int X)
        {
            return BinSearch_Lap(arr, X).ToArray();
        }
        static List<int> BinSearch_Lap(int[] arr, int X)
        {
            List<int> list = new List<int>();
            int low, up, mid;
            low = 0;
            up = arr.Length - 1;
            while (low <= up)
            {
                mid = (low + up) / 2;
                if (X == arr[mid])
                    list.Add(mid);
                else if (X > arr[mid])
                    low = mid + 1;
                else
                    up = mid - 1;
            }
            return list;
        }

        //1.10
        public static int[] TimPhanTuX_DeQuy(int[] arr, int X)
        {
            return BinSearch_DeQuy(arr, X, 0, arr.Length - 1).ToArray();
        }

        static List<int> BinSearch_DeQuy(int[] arr, int X, int low, int up)
        {
            List<int> list = new List<int>();

            if (low <= up)
            {
                int mid = (low + up) / 2;

                if (X == arr[mid])
                    list.Add(mid);

                if (X <= arr[mid]) // tìm kiếm ở nửa trái
                    list.AddRange(BinSearch_DeQuy(arr, X, low, mid - 1));

                if (X >= arr[mid]) // tìm kiếm ở nửa phải
                    list.AddRange(BinSearch_DeQuy(arr, X, mid + 1, up));
            }
            return list;
        }


    }
}
