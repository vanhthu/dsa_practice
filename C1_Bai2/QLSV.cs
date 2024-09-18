using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C1_Bai2
{
    internal class QLSV
    {
        // nhập từ bàn phím
        // static là 1 biến tĩnh => cấp phát vùng nhớ 1 lần duy nhất và có thể sử dụng lại nhiều lần
        public static double DiemTrungBinhMon(SinhVien[] dssv)
        {
            int totalMon1 = 0; 
            int totalMon2 = 0; 
            int totalMon3 = 0; 
            
            foreach(var sv in dssv)
            {
                if(sv == null)
                {
                    Console.WriteLine("Danh sach sinh vien rong!");
                    continue;
                }
                totalMon1 += sv.mon1;
                totalMon2 += sv.mon2;
                totalMon3 += sv.mon3;
            }

            double tbMon1 = (double)totalMon1/dssv.Length;
            double tbMon2 = (double)totalMon2/dssv.Length;
            double tbMon3 = (double)totalMon3/dssv.Length;

            return (tbMon1 + tbMon2 + tbMon3) / 3;
        }

        public static double DiemTrungBinhMonSV(SinhVien[] dssv)
        {
            double total= 0;

            foreach (var sv in dssv)
            {
                if (sv == null)
                {
                    Console.WriteLine("Danh sach sinh vien rong!");
                    continue;
                }
                total += sv.DiemTrungBinh();
            }          

            return total/dssv.Length;
        }
    }
}
