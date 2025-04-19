using System;
using System.Text;
namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            //bài 1:

            //Console.WriteLine("Xin mời nhập tên: ");
            //string ten = Console.ReadLine();
            //Console.WriteLine("Xin mời nhập tuổi: ");
            //int n;
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Xin Chào " + ten);
            //Console.WriteLine("bạn " + n + " tuổi");

            //bài 2:
            //Console.WriteLine("Chiều dài: ");
            //int a;
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Chiều rộng: ");
            //int b;
            //b = int.Parse(Console.ReadLine());
            //int c;
            //c = a * b;
            //Console.WriteLine("Diện tích hình chữ nhật là: " + c);

            //bài 3:
            //Console.WriteLine("Nhập độ C: " );
            //int C;
            //C = int.Parse(Console.ReadLine());
            //float F;
            //F = (C * 9 / 5) + 32;
            //Console.WriteLine("Độ F là: " + F + " độ F");

            //bài 4:
            //Console.WriteLine("Nhập số: ");
            //int d;
            //d = int.Parse(Console.ReadLine());
            //if (d % 2 == 0) 
            //{
            //    Console.WriteLine("SỐ chẵn");
            //}
            //else
            //{
            //    Console.WriteLine("Số lẻ");
            //}

            //bài 5:
            //Console.WriteLine("Nhập số thứ nhất: ");
            //int e;
            //e = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập số thứ 2: ");
            //int g;
            //g = int.Parse(Console.ReadLine());
            //int tong;
            //tong = e + g;
            //int tich;
            //tich = e * g;
            //Console.WriteLine("Tổng là: " + tong);
            //Console.WriteLine("Tích là: " + tich);

            //bài 6:
            //Console.WriteLine("Nhập số: ");
            //int h;
            //h = int.Parse(Console.ReadLine());
            //if (h < 0)
            //{
            //    Console.WriteLine("Đây là số âm");
            //}
            //else if (h > 0)
            //{
            //    Console.WriteLine("Đây là số dương");
            //}
            //else 
            //{
            //    Console.WriteLine("Đây là số 0");
            //}

            //bài 7:
            //Console.WriteLine("Nhập năm: ");
            //int nam;
            //nam = int.Parse(Console.ReadLine());
            //if (nam % 4 == 0 && nam % 100 != 0) {
            //    Console.WriteLine($"{nam} là năm nhuận");
            //}else
            //{
            //    Console.WriteLine($"{nam} ko là năm nhuận");
            //}

            //bài 8:
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Bảng cửu chương {i}:");


            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }

            //    Console.WriteLine();
            //}

            //bài 9:

            //Console.WriteLine("Nhập số nguyên dương: ");
            //int n;
            //n = int.Parse(Console.ReadLine());
            //long gt = 1;
            //for (int i = 1; i < n; i++) 
            //{
            //    gt *= i;
            //}
            //Console.WriteLine($"{n}! = {gt}");

            //bài 10:
            Console.WriteLine("Nhập só: ");
            int k;
            k = int.Parse(Console.ReadLine());
            if (k <= 1) {
                Console.WriteLine($"{k} ko phải là số nguyên tố");
                return;
            }
            bool sont = true;
            for (int i = 2; i < k; i++) 
            {
                if (k % i == 0) { 
                    sont = false;
                    break;
                }
            }
            if (sont) { 
                Console.WriteLine($"{k} là số nguyên tố");

            }
            else {
                Console.WriteLine($"{k} ko là số nguyên tố");

            }
        }
    }
}
