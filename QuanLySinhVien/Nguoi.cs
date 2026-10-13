using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_sinh_viên_bằng_Console
{
    public class Nguoi
    {
        // 1. Các hằng số
        public const string DinhDangNgay = "dd/MM/yyyy";
        public const int NamSinhToiThieu = 1900;

        // 2. Các biến lưu thông tin
        private string _hoTen = "";
        private DateTime _ngaySinh;

        // 3. Thuộc tính họ tên
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Ho ten khong duoc de trong.");
                }

                _hoTen = value.Trim();
            }
        }

        // 4. Thuộc tính ngày sinh
        public DateTime NgaySinh
        {
            get
            {
                return _ngaySinh;
            }
            set
            {
                if (!LaNgaySinhHopLe(value))
                {
                    throw new ArgumentException(
                        "Ngay sinh khong hop le.");
                }

                _ngaySinh = value.Date;
            }
        }

        // 5. Constructor
        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        // 6. Kiểm tra ngày sinh
        public static bool LaNgaySinhHopLe(DateTime ngaySinh)
        {
            if (ngaySinh.Year < NamSinhToiThieu)
            {
                return false;
            }

            if (ngaySinh.Date > DateTime.Today)
            {
                return false;
            }

            return true;
        }

        // 7. Chuyển ngày sinh thành chuỗi
        public string NgaySinhDangChuoi()
        {
            return NgaySinh.ToString(DinhDangNgay);
        }

        // 8. Lấy thông tin người
        public virtual string LayThongTin()
        {
            return "Ho ten: " + HoTen
                + ", Ngay sinh: " + NgaySinhDangChuoi();
        }
    }
}
