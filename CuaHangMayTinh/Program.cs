namespace CuaHangMayTinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachMayTinh danhSachMayTinh = new DanhSachMayTinh();

            // Nhập danh sách máy tính
            QuanLyMayTinh.Nhap(danhSachMayTinh);

            // Xuất danh sách máy tính
            Console.WriteLine("\nDanh sach may tinh vua nhap:");
            danhSachMayTinh.XuatDanhSach();

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
