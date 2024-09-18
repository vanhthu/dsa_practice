using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Bai3_GenericT
{
    internal class C1_Bai3
    {
        public struct NhanVien
        {
            public string HoTen { get; set; }
            public string MaNhanVien { get; set; }
            public double HeSoLuong { get; set; }

            public override string ToString()
            {
                return $"{HoTen} - {MaNhanVien} - He so luong: {HeSoLuong}";

            }
        }
        public class SinhVien
        {
            public string HoTen { get; set; }
            public string MaSinhVien { get; set; }
            public double DiemTrungBinh { get; set; }

            public override string ToString()
            {
                return $"{HoTen} - {MaSinhVien} - He so luong: {DiemTrungBinh}";

            }
        }

        static void Main(string[] args)
        {
            int a = 2; int b = 5;
            double c = 1.2; double d = 2.3;
            string e = "Xin chao";
            string f = "Khoa CNTT";

            Console.WriteLine("1. Swap by type");
            Console.WriteLine("1.1. Int");
            Console.WriteLine("- Before swap: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("- After swap : a = {0}, b = {1}", a, b);
            Console.WriteLine("\n");
            Console.WriteLine("1.2. Double");
            Console.WriteLine("- Before swap: c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("- After swap : c = {0}, d = {1}", c, d);
            Console.WriteLine("\n");
            Console.WriteLine("1.3. String");
            Console.WriteLine("- Before swap: e = {0}, f = {1}", e, f);
            Swap<string>(ref e, ref f);
            Console.WriteLine("- After swap : e = {0}, f = {1}", e, f);

            Console.WriteLine("\n\n");
            // Hoán vị NhanVien
            Console.WriteLine("2. Swap by struct");
            NhanVien nv1 = new NhanVien { HoTen = "Nguyen Van A", MaNhanVien = "NV001", HeSoLuong = 2.5 };
            NhanVien nv2 = new NhanVien { HoTen = "Nguyen Van B", MaNhanVien = "NV002", HeSoLuong = 3.5 };
            Console.WriteLine($" - Before swap: {nv1}  - {nv2}");
            Swap(ref nv1, ref nv2);
            Console.WriteLine($" -After swap  : {nv1}  - {nv2}");
            Console.WriteLine();

            Console.WriteLine("\n\n");
            // Hoán vị SinhVien
            Console.WriteLine("3. Swap by class");
            SinhVien sv1 = new SinhVien { HoTen = "Tran Van A", MaSinhVien = "SV001", DiemTrungBinh = 7.5 };
            SinhVien sv2 = new SinhVien { HoTen = "Tran Van B", MaSinhVien = "SV002", DiemTrungBinh = 8.5 };
            Console.WriteLine($" - Before swap: {sv1} - {sv2}");
            Swap(ref sv1, ref sv2);
            Console.WriteLine($" - After swap : {sv1} - {sv2}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
