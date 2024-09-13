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
        public double DiemTrungBinh => Math.Round((Toan + AnhVan + Tin) / 3, 1);
        public string XepLoai
        {
            get
            {
                return XepLoaiHoc(DiemTrungBinh);
            } 
        }
        public Student(string maSinhVien, string hoTen, string lop, double toan, double anhVan, double tin)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            Lop = lop;
            Toan = toan;
            AnhVan = anhVan;
            Tin = tin;
        }
        string XepLoaiHoc(double dtb)
        {
            if (dtb >= 8)
            {
                return "Giỏi";
            }
            else if (dtb >= 6.5)
            {
                return "Khá";
            }
            else if (dtb >= 5)
            {
                return "Trung bình";
            }
            else if (dtb >= 3.5)
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }
    }
}
