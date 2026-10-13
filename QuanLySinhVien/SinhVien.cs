using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_sinh_viên_bằng_Console
{
    public class SinhVien : Nguoi
    {
        // 1. Các hằng số
        public const double DiemToiThieu = 0;
        public const double DiemToiDa = 10;
        public const double DiemDat = 5;

        // 2. Các biến lưu thông tin
        private string _maSinhVien = "";
        private string _maLop = "";
        private double _diemTrungBinh;

        // 3. Thuộc tính mã sinh viên
        public string MaSinhVien
        {
            get
            {
                return _maSinhVien;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Mã sinh viên không được để trống.");
                }

                _maSinhVien = value.Trim();
            }
        }

        // 4. Thuộc tính mã lớp
        public string MaLop
        {
            get
            {
                return _maLop;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Mã lớp không được để trống.");
                }

                _maLop = value.Trim();
            }
        }

        // 5. Thuộc tính điểm trung bình
        public double DiemTrungBinh
        {
            get
            {
                return _diemTrungBinh;
            }
            set
            {
                if (double.IsNaN(value) ||
                    value < DiemToiThieu ||
                    value > DiemToiDa)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Điểm phải nằm trong khoảng từ 0 đến 10.");
                }

                _diemTrungBinh = value;
            }
        }

        // 6. Constructor
        public SinhVien(
            string maSinhVien,
            string hoTen,
            DateTime ngaySinh,
            string maLop,
            double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        // 7. Xếp loại sinh viên
        public string XepLoai()
        {
            if (DiemTrungBinh >= 9)
            {
                return "Xuat sac";
            }
            else if (DiemTrungBinh >= 8)
            {
                return "Gioi";
            }
            else if (DiemTrungBinh >= 7)
            {
                return "Kha";
            }
            else if (DiemTrungBinh >= DiemDat)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }
        }

        // 8. Hiển thị điểm trung bình
        public string DiemDangChuoi()
        {
            return DiemTrungBinh.ToString("0.0#");
        }

        // 9. Hiển thị thông tin sinh viên
        public override string LayThongTin()
        {
            return "Ma SV: " + MaSinhVien
                + ", " + base.LayThongTin()
                + ", Lop: " + MaLop
                + ", Diem TB: " + DiemDangChuoi()
                + ", Xep loai: " + XepLoai();
        }
        public static bool LaDiemHopLe(double diem)
        {
            return diem >= 0 && diem <= 10
                   && !double.IsNaN(diem);
        }
    }
}
