using QuanLyPhongGame;

namespace CuaHangMayTinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachMayTinh danhSachMayTinh = new DanhSachMayTinh();

            // Nhập danh sách máy tính
            //QuanLyMayTinh.Nhap(danhSachMayTinh);

            //// Xuất danh sách máy tính
            //Console.WriteLine("\nDanh sach may tinh vua nhap:");
            //danhSachMayTinh.XuatDanhSach();

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
            //danhSachMayTinh.SapXepGiamDanTheoNamSanXuatInsertionSort();

            //// Xuất danh sách máy tính sau khi sắp xếp
            //Console.WriteLine("\nDanh sach may tinh sau khi sap xep theo nam san xuat:");
            //danhSachMayTinh.XuatDanhSach();



            // câu c 
            // Khởi tạo quản lý máy tính
            QuanLyMayTinh2 quanLyMayTinh = new QuanLyMayTinh2();

            // Thêm một số máy tính vào danh sách
            quanLyMayTinh.ThemMayTinh(new MayTinh(1, "May 1", 2020, 15000, 10, 100));
            quanLyMayTinh.ThemMayTinh(new MayTinh(10, "May 10", 2020, 15000, 10, 100));
            quanLyMayTinh.ThemMayTinh(new MayTinh(2, "May 2", 2021, 20000, 20, 200));
            quanLyMayTinh.ThemMayTinh(new MayTinh(3, "May 3", 2019, 30, 12000, 150)); // Máy này có thời gian truy cập lâu nhất
            quanLyMayTinh.ThemMayTinh(new MayTinh(3, "May 3", 2019, 30, 12000, 150)); // Máy này có thời gian truy cập lâu nhất
            quanLyMayTinh.ThemMayTinh(new MayTinh(4, "May 4", 2022, 25000, 30, 250)); // Máy này cũng có thời gian truy cập lâu nhất
            quanLyMayTinh.ThemMayTinh(new MayTinh(4, "May 4", 2022, 25000, 30, 250)); // Máy này cũng có thời gian truy cập lâu nhất

            // Tìm tất cả các máy tính có thời gian truy cập lâu nhất
            quanLyMayTinh.FindMaxTimeComputers();
            // Tìm tất cả các máy tính có thời gian truy cập thấp nhất
            quanLyMayTinh.FindMinTimeComputers();


            Console.ReadKey();
            
        }
    }
}
