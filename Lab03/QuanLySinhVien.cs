using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_sinh_viên_bằng_Console
{
    public class QuanLySinhVien
    {
        // 1. Danh sách sinh viên
        private List<SinhVien> _danhSach = new List<SinhVien>();

        // 2. Lấy số lượng sinh viên
        public int SoLuong
        {
            get
            {
                return _danhSach.Count;
            }
        }

        // 3. Thêm sinh viên
        public bool Them(SinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                return false;
            }

            // Kiểm tra mã sinh viên đã tồn tại chưa
            if (TimTheoMa(sinhVien.MaSinhVien) != null)
            {
                return false;
            }

            _danhSach.Add(sinhVien);
            return true;
        }

        // 4. Sửa điểm trung bình theo mã sinh viên
        public bool Sua(string maSinhVien, double diemMoi)
        {
            SinhVien sinhVien = TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                return false;
            }

            sinhVien.DiemTrungBinh = diemMoi;
            return true;
        }

        // 5. Xóa sinh viên theo mã
        public bool Xoa(string maSinhVien)
        {
            SinhVien sinhVien = TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                return false;
            }

            _danhSach.Remove(sinhVien);
            return true;
        }

        // 6. Tìm sinh viên theo mã
        public SinhVien TimTheoMa(string maSinhVien)
        {
            if (string.IsNullOrWhiteSpace(maSinhVien))
            {
                return null;
            }

            maSinhVien = maSinhVien.Trim();

            for (int i = 0; i < _danhSach.Count; i++)
            {
                if (string.Equals(
                    _danhSach[i].MaSinhVien,
                    maSinhVien,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return _danhSach[i];
                }
            }

            return null;
        }

        // 7. Tìm sinh viên theo tên
        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return ketQua;
            }

            tuKhoa = tuKhoa.Trim();

            for (int i = 0; i < _danhSach.Count; i++)
            {
                if (_danhSach[i].HoTen.IndexOf(
                    tuKhoa,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ketQua.Add(_danhSach[i]);
                }
            }

            return ketQua;
        }

        // 8. Sắp xếp điểm từ cao xuống thấp
        public List<SinhVien> SapXepTheoDiem()
        {
            List<SinhVien> ketQua = LayDanhSach();

            for (int i = 0; i < ketQua.Count - 1; i++)
            {
                for (int j = i + 1; j < ketQua.Count; j++)
                {
                    if (ketQua[i].DiemTrungBinh <
                        ketQua[j].DiemTrungBinh)
                    {
                        SinhVien tam = ketQua[i];
                        ketQua[i] = ketQua[j];
                        ketQua[j] = tam;
                    }
                }
            }

            return ketQua;
        }

        // 9. Lọc sinh viên đạt (điểm từ 5 trở lên)
        public List<SinhVien> LocSinhVienDat()
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            for (int i = 0; i < _danhSach.Count; i++)
            {
                if (_danhSach[i].DiemTrungBinh >= SinhVien.DiemDat)
                {
                    ketQua.Add(_danhSach[i]);
                }
            }

            return ketQua;
        }

        // 10. Lấy bản sao danh sách sinh viên
        public List<SinhVien> LayDanhSach()
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            for (int i = 0; i < _danhSach.Count; i++)
            {
                ketQua.Add(_danhSach[i]);
            }

            return ketQua;
        }
    }
}
