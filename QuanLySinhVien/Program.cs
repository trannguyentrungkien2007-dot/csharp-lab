using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Quản_lý_sinh_viên_bằng_Console
{
    internal class Program
    {
        // Đối tượng quản lý danh sách sinh viên
        private static QuanLySinhVien quanLy = new QuanLySinhVien();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            ChayChuongTrinh();
        }

        // 1. Chạy chương trình
        static void ChayChuongTrinh()
        {
            bool tiepTuc = true;

            while (tiepTuc)
            {
                HienThiMenu();

                int luaChon = NhapLuaChon();

                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;

                    case 2:
                        XuatDanhSach();
                        break;

                    case 3:
                        TimSinhVienTheoMa();
                        break;

                    case 4:
                        TimSinhVienTheoTen();
                        break;

                    case 5:
                        SuaDiem();
                        break;

                    case 6:
                        XoaSinhVien();
                        break;

                    case 7:
                        SapXepSinhVien();
                        break;

                    case 8:
                        LocSinhVienDat();
                        break;

                    case 0:
                        Console.WriteLine("Tam biet!");
                        tiepTuc = false;
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                Console.WriteLine();
            }
        }

        // 2. Hiển thị menu
        static void HienThiMenu()
        {
            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
        }

        // 3. Nhập lựa chọn menu
        static int NhapLuaChon()
        {
            int luaChon;

            bool hopLe = int.TryParse(Console.ReadLine(), out luaChon);

            if (hopLe)
            {
                return luaChon;
            }

            return -1;
        }

        // 4. Thêm sinh viên
        static void ThemSinhVien()
        {
            Console.WriteLine("--- THEM SINH VIEN ---");

            string ma = NhapChuoi("Ma sinh vien: ");

            if (quanLy.TimTheoMa(ma) != null)
            {
                Console.WriteLine("Ma sinh vien da ton tai!");
                return;
            }

            string hoTen = NhapChuoi("Ho ten: ");
            DateTime ngaySinh = NhapNgaySinh();
            string maLop = NhapChuoi("Ma lop: ");
            double diem = NhapDiem();

            SinhVien sv = new SinhVien(
                ma, hoTen, ngaySinh, maLop, diem);

            bool ketQua = quanLy.Them(sv);

            if (ketQua)
            {
                Console.WriteLine("Them sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong the them sinh vien!");
            }
        }

        // 5. Xuất danh sách sinh viên
        static void XuatDanhSach()
        {
            Console.WriteLine("--- DANH SACH SINH VIEN ---");

            List<SinhVien> danhSach = quanLy.LayDanhSach();

            InBang(danhSach);
        }

        // 6. Tìm sinh viên theo mã
        static void TimSinhVienTheoMa()
        {
            Console.WriteLine("--- TIM SINH VIEN THEO MA ---");

            string ma = NhapChuoi("Nhap ma sinh vien can tim: ");

            SinhVien sv = quanLy.TimTheoMa(ma);

            if (sv == null)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
            else
            {
                Console.WriteLine(sv.LayThongTin());
            }
        }

        // 7. Tìm sinh viên theo tên
        static void TimSinhVienTheoTen()
        {
            Console.WriteLine("--- TIM SINH VIEN THEO TEN ---");

            string ten = NhapChuoi("Nhap ten can tim: ");

            List<SinhVien> ketQua = quanLy.TimTheoTen(ten);

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
            else
            {
                InBang(ketQua);
            }
        }

        // 8. Sửa điểm sinh viên
        static void SuaDiem()
        {
            Console.WriteLine("--- SUA DIEM ---");

            string ma = NhapChuoi("Nhap ma sinh vien: ");

            SinhVien sv = quanLy.TimTheoMa(ma);

            if (sv == null)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
                return;
            }

            Console.WriteLine("Ho ten: " + sv.HoTen);
            Console.WriteLine("Diem cu: " + sv.DiemDangChuoi());

            double diemMoi = NhapDiem();

            bool ketQua = quanLy.Sua(ma, diemMoi);

            if (ketQua)
            {
                Console.WriteLine("Cap nhat diem thanh cong!");
                Console.WriteLine("Diem moi: " + sv.DiemDangChuoi());
                Console.WriteLine("Xep loai: " + sv.XepLoai());
            }
            else
            {
                Console.WriteLine("Khong the sua diem!");
            }
        }

        // 9. Xóa sinh viên
        static void XoaSinhVien()
        {
            Console.WriteLine("--- XOA SINH VIEN ---");

            string ma = NhapChuoi("Nhap ma sinh vien can xoa: ");

            bool ketQua = quanLy.Xoa(ma);

            if (ketQua)
            {
                Console.WriteLine("Xoa sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }

        // 10. Sắp xếp điểm giảm dần
        static void SapXepSinhVien()
        {
            Console.WriteLine("--- SAP XEP THEO DIEM GIAM DAN ---");

            List<SinhVien> danhSach = quanLy.SapXepTheoDiem();

            InBang(danhSach);
        }

        // 11. Lọc sinh viên đạt
        static void LocSinhVienDat()
        {
            Console.WriteLine("--- SINH VIEN DAT ---");

            List<SinhVien> danhSach = quanLy.LocSinhVienDat();

            InBang(danhSach);
        }

        // 12. In danh sách thành bảng
        static void InBang(List<SinhVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            Console.WriteLine(
                "Ma SV".PadRight(12) +
                "Ho ten".PadRight(25) +
                "Ngay sinh".PadRight(15) +
                "Ma lop".PadRight(12) +
                "Diem".PadRight(10) +
                "Xep loai");

            Console.WriteLine(new string('-', 85));

            for (int i = 0; i < danhSach.Count; i++)
            {
                SinhVien sv = danhSach[i];

                Console.WriteLine(
                    sv.MaSinhVien.PadRight(12) +
                    CatChuoi(sv.HoTen, 24).PadRight(25) +
                    sv.NgaySinhDangChuoi().PadRight(15) +
                    CatChuoi(sv.MaLop, 11).PadRight(12) +
                    sv.DiemDangChuoi().PadRight(10) +
                    sv.XepLoai());
            }

            Console.WriteLine(new string('-', 85));
            Console.WriteLine("Tong so sinh vien: " + danhSach.Count);
        }

        // 13. Cắt chuỗi quá dài
        static string CatChuoi(string chuoi, int doDai)
        {
            if (chuoi.Length <= doDai)
            {
                return chuoi;
            }

            return chuoi.Substring(0, doDai - 3) + "...";
        }

        // 14. Nhập chuỗi không được để trống
        static string NhapChuoi(string loiNhac)
        {
            string giaTri;

            do
            {
                Console.Write(loiNhac);
                giaTri = Console.ReadLine() ?? "";
                giaTri = giaTri.Trim();

                if (giaTri == "")
                {
                    Console.WriteLine("Khong duoc de trong!");
                }

            } while (giaTri == "");

            return giaTri;
        }

        // 15. Nhập điểm từ 0 đến 10
        static double NhapDiem()
        {
            double diem;
            bool hopLe;

            do
            {
                Console.Write("Nhap diem (0 - 10): ");

                string chuoi = Console.ReadLine() ?? "";
                chuoi = chuoi.Trim().Replace(',', '.');

                hopLe = double.TryParse(
                    chuoi,
                    NumberStyles.AllowLeadingSign |
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out diem);

                if (!hopLe)
                {
                    Console.WriteLine("Diem phai la mot so!");
                }
                else if (!SinhVien.LaDiemHopLe(diem))
                {
                    Console.WriteLine("Diem phai tu 0 den 10!");
                    hopLe = false;
                }

            } while (!hopLe);

            return diem;
        }

        // 16. Nhập ngày sinh
        static DateTime NhapNgaySinh()
        {
            DateTime ngaySinh;
            bool hopLe;

            do
            {
                Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");

                string chuoi = Console.ReadLine() ?? "";
                chuoi = chuoi.Trim();

                hopLe = DateTime.TryParseExact(
                    chuoi,
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngaySinh);

                if (!hopLe)
                {
                    Console.WriteLine(
                        "Ngay sinh khong dung dinh dang!");
                }
                else if (!Nguoi.LaNgaySinhHopLe(ngaySinh))
                {
                    Console.WriteLine(
                        "Ngay sinh phai tu nam 1900 den hom nay!");

                    hopLe = false;
                }

            } while (!hopLe);

            return ngaySinh;
        }
    }
}
