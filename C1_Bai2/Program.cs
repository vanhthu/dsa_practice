using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
namespace C1_Bai2
{
    internal class Program
    {
        static void NhapTuBanPhim()
        {            
            Console.Write("\n\nNhap vao so luong sinh vien: ");
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

            Stopwatch timer = new Stopwatch();
            timer.Start();
            double dtbCach1 = QLSV.DiemTrungBinhMon(dssv);
            timer.Stop();

            Console.WriteLine($"Diem trung binh theo cach 1: {dtbCach1}");
            Console.WriteLine($"Thoi gian tinh diem trung binh theo cach 1: {timer.ElapsedMilliseconds} ms");

            
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("************** MENU **************");
                Console.WriteLine("*    1. Nhap tu ban phim         *");
                Console.WriteLine("**********************************");

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
