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
        private double toan;
        public double Toan
        {
            get { return toan; }
            set
            {
                if (value < 0)
                {
                    toan = 0;
                }
                else if (value > 10)
                {
                    toan = 10;
                }
                else
                {
                    toan = value;
                }
            }
        }
        private double anhVan;
        public double AnhVan
        {
            get { return anhVan; }
            set
            {
                if (value < 0)
                {
                    anhVan = 0;
                }
                else if (value > 10)
                {
                    anhVan = 10;
                }
                else
                {
                    anhVan = value;
                }
            }
        }
        private double tin;
        public double Tin
        {
            get { return tin; }
            set
            {
                if (value < 0)
                {
                    tin = 0;
                }
                else if (value > 10)
                {
                    tin = 10;
                }
                else
                {
                    tin = value;
                }
            }
        }
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
            double diemTB = dtb;
            if (diemTB >= 8)
            {
                return "Giỏi";
            }
            else if (diemTB >= 6.5)
            {
                return "Khá";
            }
            else if (diemTB >= 5)
            {
                return "Trung bình";
            }
            else if (diemTB >= 3.5)
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
