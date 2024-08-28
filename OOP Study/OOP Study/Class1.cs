using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study
{
    public class Student : IStudent
    {
        public string MaSinhVien { get;private set; }
        public string HoTen { get; private set; }
        public string Lop { get; private set; }
        public double Toan { get; private set; }
        public double AnhVan { get; private set; }
        public double Tin { get; private set; }
        public double DiemTrungBinh { get; private set; }
        public string XepLoai { get; private set; }
        public Student(string maSinhVien, string hoTen, string lop, double toan, double anhVan, double tin)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            Lop = lop;
            Toan = toan;
            AnhVan = anhVan;
            Tin = tin;
            DiemTrungBinh = (Toan + AnhVan + Tin) / 3;
            XepLoai = XepLoaiHoc(DiemTrungBinh);
        }
        string XepLoaiHoc(double dtb)
        {
            if (dtb >= 8)
            {
                return "Gioi";
            }
            else if (dtb >= 6.5 && dtb < 8)
            {
                return "Kha";
            }
            else if (dtb >= 5 && dtb < 6.5)
            {
                return "Trung binh";
            }
            else if (dtb >= 3.5 && dtb <5)
            {
                return "Yeu";
            }
            else
            {
                return "Kem";
            }
        }
    }
}
