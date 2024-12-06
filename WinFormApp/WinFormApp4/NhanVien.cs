using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    //class OOP để lưu thông tin nhân viên
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public string Phong { get; set; }
        public string ChucVu { get; set; }

        public NhanVien() { }

        public NhanVien (string hoTen, int tuoi, string diaChi, string phong, string chucVu)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            DiaChi = diaChi;
            Phong = phong;
            ChucVu = chucVu;
        }

        // Override ToString method để chỉ hiển thị tên nhân viên & phòng ban trong listbox
        public override string ToString()
        {
            string label = HoTen + " - " + Phong;
            return label;
        }
    }
}
