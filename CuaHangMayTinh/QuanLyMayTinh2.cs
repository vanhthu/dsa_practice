using CuaHangMayTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongGame
{
    internal class QuanLyMayTinh2
    {
        private LinkedList<MayTinh> danhSachMayTinh;

        public QuanLyMayTinh2()
        {
            danhSachMayTinh = new LinkedList<MayTinh>();
        }

        // Phương thức thêm máy tính vào danh sách
        public void ThemMayTinh(MayTinh may)
        {
            danhSachMayTinh.AddLast(may);
        }

        // Phương thức tìm máy tính có thời gian truy cập lâu nhất
        public void FindMaxTimeComputers()
        {
            if (danhSachMayTinh.Count == 0)
            {
                Console.WriteLine("Danh sach may tinh rong.");
                return;
            }

            // Tìm thời gian truy cập lớn nhất
            int maxThoiGian = int.MinValue;
            foreach (var may in danhSachMayTinh)
            {
                if (may.ThoiGian > maxThoiGian)
                {
                    maxThoiGian = may.ThoiGian;
                }
            }

            // Lọc và hiển thị các máy tính có thời gian truy cập tối đa
            Console.WriteLine("\nDanh sach may tinh co thoi gian truy cap lau nhat ({0} gio):", maxThoiGian);
            foreach (var may in danhSachMayTinh)
            {
                if (may.ThoiGian == maxThoiGian)
                {
                    may.Xuat();
                }
            }
        }

        // Phương thức tìm máy tính có thời gian truy cập thấp nhất
        public void FindMinTimeComputers()
        {
            if (danhSachMayTinh.Count == 0)
            {
                Console.WriteLine("Danh sach may tinh rong.");
                return;
            }

            // Tìm thời gian truy cập nhỏ nhất
            int minThoiGian = int.MaxValue;
            foreach (var may in danhSachMayTinh)
            {
                if (may.ThoiGian < minThoiGian)
                {
                    minThoiGian = may.ThoiGian;
                }
            }

            // Lọc và hiển thị các máy tính có thời gian truy cập tối thiểu
            Console.WriteLine("\nDanh sach may tinh co thoi gian truy cap thap nhat ({0} gio):", minThoiGian);
            foreach (var may in danhSachMayTinh)
            {
                if (may.ThoiGian == minThoiGian)
                {
                    may.Xuat();
                }
            }
        }
    }
}
