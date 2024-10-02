using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai1_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            Console.Write("Nhap vao so luong phan tu cua mang: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[soLuong];

            ArrayInOut arrayInOut = new ArrayInOut();
            ArrayInOut.NhapMang(arr, soLuong);
            ArrayInOut.XuatMang(arr, soLuong);

            Console.ReadKey();
        }
    }
}
