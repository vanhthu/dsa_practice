using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Bai2
{
    internal class Program
    {
        static void NhapTuBanPhim()
        {            
            Console.Write("Nhap vao so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] dssv = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ma sinh vien: ");
                string maSV = Console.ReadLine();
                Console.Write("Nhap diem mon 1: ");
                int mon1= Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap diem mon 2: ");
                int mon2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap diem mon 3: ");
                int mon3 = Convert.ToInt32(Console.ReadLine());

                dssv[i] = new SinhVien(maSV, mon1, mon2, mon3);
            }
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("1. Nhap tu ban phim");

                Console.Write("Lua chon cua ban la: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1: NhapTuBanPhim(); break;
                    case 0:
                        Console.WriteLine("Ban muon thoat khoi chuong trinh?");                        
                        break;
                    default: 
                        Console.WriteLine("Du lieu khong hop le!");
                        break;
                }
                Console.WriteLine("Nhap phim bat ky de tiep tuc!");
                Console.ReadKey();
                Console.Clear();
            }
            while (choice != 0);
        }
    }
}
