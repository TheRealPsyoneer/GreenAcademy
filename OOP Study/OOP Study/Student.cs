using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study
{
    public interface IStudent
    {
        string MaSinhVien { get; }
        string HoTen { get; }
        string Lop { get; }
        double Toan { get; }
        double AnhVan { get; }
        double Tin { get; }
        double DiemTrungBinh { get; }
        string XepLoai { get; }
    }
}
