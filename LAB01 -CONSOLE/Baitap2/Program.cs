using System;
namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap tham so a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhap tham so b: ");
                double b = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");

                    }
                }
                else
                {
                    double x = -b / a;
                    Console.WriteLine("Phuong trinh co nghiem duy nhat: x = " + x.ToString());
                }
            }
            //Bắt lỗi khi giá trị vượt phạm vi kiểu dữ liệu.
            catch (FormatException)
            {
                Console.WriteLine("Loi: Vui long nhap cac he so la so!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Loi: Gia tri nhap vao qua lon hoac qua nho!");
            }
        }
    }
}