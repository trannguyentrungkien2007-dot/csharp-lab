
using System;
using System.Collections.Generic;

class MatHang
{
    public int MaMH;
    public string TenMH;
    public int SoLuong;
    public double DonGia;

    // Ham tao
    public MatHang(int ma, string ten, int soLuong, double donGia)
    {
        MaMH = ma;
        TenMH = ten;
        SoLuong = soLuong;
        DonGia = donGia;
    }

    // Ham tinh thanh tien
    public double ThanhTien()
    {
        return SoLuong * DonGia;
    }
}

class Program
{
    // 1. Them mat hang vao danh sach
    static void ThemMatHang(List<MatHang> ds, MatHang mh)
    {
        ds.Add(mh);
    }

    // 2. Tim mat hang theo ma, tra ve true hoac false
    static bool TimMatHang(List<MatHang> ds, int ma)
    {
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i].MaMH == ma)
            {
                return true;
            }
        }

        return false;
    }

    // 3. Xuat danh sach mat hang
    static void XuatDanhSach(List<MatHang> ds)
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }

        Console.WriteLine(
            "{0,-10}{1,-25}{2,-12}{3,-15}{4,-15}",
            "Ma MH", "Ten mat hang", "So luong",
            "Don gia", "Thanh tien");

        for (int i = 0; i < ds.Count; i++)
        {
            Console.WriteLine(
                "{0,-10}{1,-25}{2,-12}{3,-15:N0}{4,-15:N0}",
                ds[i].MaMH,
                ds[i].TenMH,
                ds[i].SoLuong,
                ds[i].DonGia,
                ds[i].ThanhTien());
        }
    }

    // 4. Xoa mat hang theo ma
    static bool XoaMatHang(List<MatHang> ds, int ma)
    {
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i].MaMH == ma)
            {
                ds.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    // 5. Ham Main
    static void Main(string[] args)
    {
        List<MatHang> ds = new List<MatHang>();

        string tiepTuc;

        // Nhap danh sach mat hang
        do
        {
            Console.Write("\nNhap ma mat hang: ");
            int ma = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten mat hang: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            int soLuong = int.Parse(Console.ReadLine());

            Console.Write("Nhap don gia: ");
            double donGia = double.Parse(Console.ReadLine());

            MatHang mh = new MatHang(ma, ten, soLuong, donGia);

            ThemMatHang(ds, mh);

            Console.Write("Ban co muon nhap tiep? (y/n): ");
            tiepTuc = Console.ReadLine();

        } while (tiepTuc == "y" || tiepTuc == "Y");

        // Xuat danh sach
        Console.WriteLine("\n===== DANH SACH MAT HANG =====");
        XuatDanhSach(ds);

        // Tim va xoa mat hang
        Console.Write("\nNhap ma mat hang can tim va xoa: ");
        int maCanTim = int.Parse(Console.ReadLine());

        if (TimMatHang(ds, maCanTim))
        {
            XoaMatHang(ds, maCanTim);

            Console.WriteLine("Da xoa mat hang co ma " + maCanTim);

            Console.WriteLine("\n===== DANH SACH SAU KHI XOA =====");
            XuatDanhSach(ds);
        }
        else
        {
            Console.WriteLine("Khong tim thay mat hang!");
        }

        Console.ReadKey();
    }
}

