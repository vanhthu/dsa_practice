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

            // SẮP XẾP TĂNG DẦN
            //// Sắp xếp danh sách theo năm sản xuất
            //danhSachMayTinh.SapXepTheoNamSanXuat();
            //// Sắp xếp danh sách theo năm sản xuất bằng Bubble Sort
            //danhSachMayTinh.SapXepTheoNamSanXuatBubbleSort();

            //// Sắp xếp danh sách theo năm sản xuất bằng Selection Sort
            //danhSachMayTinh.SapXepTheoNamSanXuatSelectionSort();

            //// Sắp xếp danh sách theo năm sản xuất bằng Insertion Sort
            //danhSachMayTinh.SapXepTheoNamSanXuatInsertionSort();

            // SẮP XẾP GIẢM DẦN
            //// Sắp xếp danh sách theo năm sản xuất (giảm dần) bằng Quick Sort
            //danhSachMayTinh.SapXepGiamDanTheoNamSanXuat();            

            //// Sắp xếp danh sách theo năm sản xuất (giảm dần) bằng Bubble Sort
            //danhSachMayTinh.SapXepGiamDanTheoNamSanXuatBubbleSort();

            //// Sắp xếp danh sách theo năm sản xuất (giảm dần) bằng Selection Sort
            //danhSachMayTinh.SapXepGiamDanTheoNamSanXuatSelectionSort();

            // Sắp xếp danh sách theo năm sản xuất (giảm dần) bằng Insertion Sort
            danhSachMayTinh.SapXepGiamDanTheoNamSanXuatInsertionSort();



            // Xuất danh sách máy tính sau khi sắp xếp
            Console.WriteLine("\nDanh sach may tinh sau khi sap xep theo nam san xuat:");
            danhSachMayTinh.XuatDanhSach();


            Console.ReadKey();
        }
    }
}
