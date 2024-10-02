using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai1_Search
{
    internal class Search
    {
        static int[] arr;
        public static void NhapMang()
        {
            Console.Write("Nhap so phan tu: ");
            int N = Convert.ToInt32(Console.ReadLine());
            arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write(" - Nhap phan tu arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void XuatMang()
        {
            Console.Write("Mang vua nhap la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void InKetQua()
        {
            XuatMang();
            Console.Write("Nhap phan tu X: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\t KET QUA");

            Console.WriteLine("1.1. Phan tu X = {0} co gia tri dau tien: arr[{1}]", X, TimPhanTuDauTien(X));

            Console.WriteLine("1.2. Phan tu X = {0} co gia tri sau cung: arr[{1}]", X, TimPhanTuSauCung(X));

            Console.Write("1.3. Phan tu co gia tri X = {0}         : ", X);
            int[] arr1 = TimTatCaPhanTu(X);
            for (int i = 0; i < arr1.Length; i++)
                Console.Write("arr[{0}]\t", arr1[i]);
            Console.WriteLine();

            Console.WriteLine("1.4. Phan tu nho nhat dau tien          : arr[{0}]", TimPhanTuNhoNhatDauTien());

        }
        // 1.1
        public static int TimPhanTuDauTien(int X)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == X)
                    return i;
            return -1;
        }

        // 1.2
        public static int TimPhanTuSauCung(int X)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
                if (arr[i] == X)
                    return i;
            return -1;
        }

        // 1.3
        public static int[] TimTatCaPhanTu(int X)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == X)
                    list.Add(i);
            return list.ToArray();
        }

        // 1.4
        public static int TimPhanTuNhoNhatDauTien()
        {
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[i])
                        index = j;
            return index;
        }

        // 1.5
        public static int TimPhanTuLonNhatSauCung()
        {
            int index = arr.Length - 1;
            for (int i = arr.Length - 1; i > 0; i--)
                for (int j = i - 1; j >= 0; j--)
                    if (arr[j] > arr[i])
                        index = j;
            return index;
        }

        // 1.6
        public static int[] TimTatCaCacSoNhoNhat()
        {
            List<int> list = new List<int>();
            int indexMin = TimPhanTuNhoNhatDauTien();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == arr[indexMin])
                    list.Add(i);
            return list.ToArray();
        }

        // 1.7
        public static int TimPhanTuLeLonNhatDauTien()
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
        public static int TimPhanTuChanLonNhatSauCung()
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
        public static int[] TimPhanTuX_Lap(int X)
        {
            return BinSearch_Lap(X).ToArray();
        }
        static List<int> BinSearch_Lap(int X)
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
        public static int[] TimPhanTuX_DeQuy(int X)
        {
            return BinSearch_DeQuy(X, 0, arr.Length - 1).ToArray();
        }

        static List<int> BinSearch_DeQuy(int X, int low, int up)
        {
            List<int> list = new List<int>();

            if (low <= up)
            {
                int mid = (low + up) / 2;

                if (X == arr[mid])
                    list.Add(mid);

                if (X <= arr[mid]) // tìm kiếm ở nửa trái
                    list.AddRange(BinSearch_DeQuy(X, low, mid - 1));

                if (X >= arr[mid]) // tìm kiếm ở nửa phải
                    list.AddRange(BinSearch_DeQuy(X, mid + 1, up));
            }
            return list;
        }


    }
}
