using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh
{
    // Class quản lý nhập xuất máy tính (DanhSachMayTinh)
    class QuanLyMayTinh
    {
        public static void Nhap(DanhSachMayTinh danhSach)
        {
            Console.Write("Nhap so luong may tinh: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin may thu {0}:", i + 1);
                Console.Write(" - So may: ");
                int SoMay = Convert.ToInt32(Console.ReadLine());
                Console.Write(" - Ten may: ");
                string TenMay = Console.ReadLine();
                Console.Write(" - Nam san xuat: ");
                int NamSX = Convert.ToInt32(Console.ReadLine());
                Console.Write(" - Gia tri: ");
                int GiaTri = Convert.ToInt32(Console.ReadLine());
                Console.Write(" - Thoi gian truy cap: ");
                int ThoiGian = Convert.ToInt32(Console.ReadLine());
                Console.Write(" - Tien truy cap: ");
                int TienTruyCap = Convert.ToInt32(Console.ReadLine());

                MayTinh mayTinh = new MayTinh(SoMay, TenMay, NamSX, GiaTri, ThoiGian, TienTruyCap);

                // Thêm máy tính vào đầu danh sách
                //danhSach.ThemMayTinh(mayTinh);

                // Thêm máy tính vào cuối danh sách
                danhSach.ThemMayTinhCuoi(mayTinh);

            }
        }
    }
}
