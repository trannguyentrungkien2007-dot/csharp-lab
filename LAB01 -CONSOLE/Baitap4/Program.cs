using System;
namespace BaiTap4
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Nhap ho, ten lot va ten. Xuat ra ho va ten day du.");
            Console.WriteLine();
            Console.WriteLine($"Nhap ho: ");
            string ho = Console.ReadLine();
            Console.WriteLine($"Nhap ten lot:");
            string tenlot = Console.ReadLine();
            Console.WriteLine($"Nhap ten:");
            string ten = Console.ReadLine();
            Console.WriteLine("Ho ten day du: {0} {1} {2}", ho, tenlot, ten);
            Console.ReadKey(true);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Nhap ho ten day du. Xuat ra tung phan.");
            Console.WriteLine();

            Console.Write("Nhap ho ten:");
            string fullname = Console.ReadLine();

            string SPACE = " ";
            string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);
            Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);
            Console.ReadKey(true);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Nhap ho ten khong theo chuan. Chinh lai theo chuan va xuat ra.");
            Console.WriteLine();
            Console.WriteLine("Nhap ho ten (khong can theo chuan):");
            string fullname1= Console.ReadLine();

            string SEPERATOR = " ";
            string[] parts1 = fullname1.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);

            string ho1 = parts1[0].Substring(0, 1).ToUpper() + parts1[0].Substring(1, parts1[0].Length - 1).ToLower();
            string tenlot1 = parts1[1].Substring(0, 1).ToUpper() + parts1[1].Substring(1, parts1[1].Length - 1).ToLower();
            string ten1 = parts1[2].Substring(0, 1).ToUpper() + parts1[2].Substring(1, parts1[0].Length - 1).ToLower();

            Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho1, tenlot1, ten1);
            Console.ReadKey(true);
        }
    }
}
