using System.Text;
{
    //bài 1:
    //int TinhTongSoChan(int[] a)
    //{
    //    int tong = 0;
    //    foreach (int i in a)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            tong += i;
    //        }
    //    }
    //    return tong;
    //}

    //int[] a = {23, 87, 45, 12, 56, 91, 38, 67, 4, 73 };
    //int tong = TinhTongSoChan(a);
    //Console.WriteLine("Tổng các số chẵn của mảng là: " + tong);

    ////bài 2:
    //static bool KiemTraSoNT(int n)
    //{
    //    if (n < 2) return false;
    //    for (int i = 2; i < n; i++)
    //    {
    //        if (n % i == 0)
    //            return false;
    //    }
    //    return true;
    //}


    //    Console.Write("Nhập số phần tử: ");
    //    int n = int.Parse(Console.ReadLine());
    //    int[] a = new int[n];

    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write($"Nhập phần tử a[{i}]: ");
    //        a[i] = int.Parse(Console.ReadLine());
    //    }

    //    Console.WriteLine("Các số nguyên tố trong mảng:");
    //    for (int i = 0; i < n; i++)
    //    {
    //        if (KiemTraSoNT(a[i]))
    //        {
    //            Console.WriteLine($"a[{i}] = {a[i]}");
    //        }
    //    }

    //bài 3:
    //    static void Main()
    //    {
    //        Console.Write("Nhập số lượng phần tử của mảng: ");
    //        int n = int.Parse(Console.ReadLine());

    //        int[] a = new int[n];

    //        Console.WriteLine("Nhập các phần tử của mảng:");
    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.Write($"Phần tử thứ {i + 1}: ");
    //            a[i] = int.Parse(Console.ReadLine());
    //        }

    //        DemSoAmVaDuong(a);
    //    }

    //    static void DemSoAmVaDuong(int[] a)
    //    {
    //        int soAm = 0;
    //        int soDuong = 0;

    //        foreach (int x in a)
    //        {
    //            if (x < 0)
    //                soAm++;
    //            else if (x > 0)
    //                soDuong++;
    //        }

    //        Console.WriteLine($"Số lượng số âm: {soAm}");
    //        Console.WriteLine($"Số lượng số dương: {soDuong}");
    //    }

    //}

    //bài 5:

    //static void HoanVi(ref int a, ref int b)
    //{
    //    int c = a;
    //    a = b;
    //    b = c;

    //}
    //int a, b;
    //Console.WriteLine("Nhập số a: ");
    //a = int.Parse(Console.ReadLine());
    //Console.WriteLine("Nhập số b: ");
    //b = int.Parse(Console.ReadLine());
    //HoanVi(ref a, ref b);
    //Console.WriteLine($"Hai số a và b sau khi hoán vị là: a - {a} và b - {b}");

    //bài 6:
    Console.Write("Nhập số lượng của mảng: ");
    int n = int.Parse(Console.ReadLine());

    double[] a = new double[n];

    Console.WriteLine("Nhập các phần tử của mảng:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Phần tử thứ {i + 1}: ");
        a[i] = double.Parse(Console.ReadLine());
    }

    SapXepTangDan(a);

    Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
    foreach (double x in a)
    {
        Console.Write(x + " ");
    }
}

static void SapXepTangDan(double[] a)
{
    Array.Sort(a); // Sắp xếp tăng dần
}