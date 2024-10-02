using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai1_Search
{
    internal class InOut
    {
        static int[] arr;
        public static void NhapMang()
        {
            Console.Write("Nhap so phan tu: ");
            int N = Convert.ToInt32(Console.ReadLine());
            arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write(" - Nhap phan tu arr[{0}]: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void XuatMang()
        {
            Console.Write("\nMang vua nhap la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void InKetQua()
        {
            //XuatMang();
            //Console.Write("Nhap vao gia tri X: ");
            //int X = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("1.1. Phan tu X = {0} co gia tri dau tien: arr[{1}]", X, Search.TimPhanTuDauTien(arr, X));

            //Console.WriteLine("1.2. Phan tu X = {0} co gia tri sau cung: arr[{1}]", X, Search.TimPhanTuSauCung(arr, X));

            //Console.Write("1.3. Phan tu co gia tri X = {0}         : ", X);
            //int[] arr1 = Search.TimTatCaPhanTu(arr, X);
            //for (int i = 0; i < arr1.Length; i++)
            //    Console.Write("arr[{0}]\t", arr1[i]);
            //Console.WriteLine();

            //Console.WriteLine("1.4. Phan tu nho nhat dau tien          : arr[{0}]", Search.TimPhanTuNhoNhatDauTien(arr));


           
        }       
    }
}
