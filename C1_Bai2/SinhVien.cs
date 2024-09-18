using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Bai2
{
    internal class SinhVien
    {
        public string masv {  get; set; }
        public int mon1 { get; set; }
        public int mon2 { get; set; }
        public int mon3 { get; set; }

        public SinhVien(string masv, int m1, int m2, int m3)
        {
            this.masv = masv;
            this.mon1 = m1;
            this.mon2 = m2;
            this.mon3 = m3;
        }
        public SinhVien() { }

        public double DiemTrungBinh()
        {
            return (mon1 + mon2 + mon3) / 3.0;
        }
    }
}
