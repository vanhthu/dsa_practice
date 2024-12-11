 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh
{
    // Class đại diện cho mỗi máy tính
    class MayTinh
    {
        public int SoMay;
        public string TenMay;
        public int NamSX;
        public int GiaTri;
        public int ThoiGian;
        public int TienTruyCap;

        public MayTinh(int soMay, string tenMay, int namSX, int giaTri, int thoiGian, int tienTruyCap)
        {
            this.SoMay = soMay;
            this.TenMay = tenMay;
            this.NamSX = namSX;
            this.GiaTri = giaTri;
            this.ThoiGian = thoiGian;
            this.TienTruyCap = tienTruyCap;
        }

        public void Xuat()
        {
            Console.WriteLine("So may: {0} - Ten may: {1} - Nam san xuat: {2} - Gia tri: {3} - Thoi gian truy cap: {4} - Tien truy cap: {5}",
                SoMay, TenMay, NamSX, GiaTri, ThoiGian, TienTruyCap);
        }
    }

    // Class đại diện cho một Node trong danh sách liên kết
    class Node
    {
        public MayTinh Data;
        public Node Next;

        public Node(MayTinh data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
