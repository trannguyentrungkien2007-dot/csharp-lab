using System;
namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu " + i.ToString() + ":");
                mang[i] = int.Parse(Console.ReadLine());
            }
            //Ham tinh tong
            int tong = 0;
            for(int i = 0; i < n; i++)
            {
                tong = tong + mang[i];
            }
            Console.WriteLine($"Tong cua mang la:" + tong);
            
            //So nguyen lon nhat trong mang
            int max = mang[0];
            for(int i = 0; i < n; i++)
            {
                if (max < mang[i])
                {
                    max = mang[i];
                }
            }
            Console.WriteLine($"So nguyen lon nhat cua mang:" + max);

            //So nguyen nho nhat trong mang
            int min = mang[0];
            for(int i = 0; i < n; i++)
            {
                if (min > mang[i])
                {
                    min = mang[i];
                }
            }
            Console.WriteLine($"So nguyen nho nhat cua mang:" + min);
        }
    }
}
