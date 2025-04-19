using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = Encoding.UTF8;
namespace Bai1
{
    internal class QLCB
    {
        private CanBo[] dsCanBo = new CanBo[100];
        private int luong = 0;
        public void ThemCB()
        {
            if (luong < dsCanBo.Length)
            {
                Console.WriteLine("Danh sách đã đầy, ko thể thêm mới.");
                return;
            }
            Console.WriteLine("------Chọn cán bộ mà bạn  muôn thêm:");
            Console.WriteLine("1. Công nhân");
            Console.WriteLine("2. Kỹ sư");
            Console.WriteLine("3. Nhân viên");
            Console.WriteLine("Chọn: ");
            string chon = Console.ReadLine();

            CanBo cb = null;
            switch (chon)
            {
                case "1":
                    cb = new CongNhan();
                case "2":
                    cb = new KySu();
                    break;
                case "3":
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }
            cb.Nhap();
            dsCanBo[luong] = cb;
            luong++;

            Console.WriteLine("==> Thêm cán bộ thành công!\n");
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string ten = Console.ReadLine();
            bool timThay = false;

            Console.WriteLine("\n==> Kết quả tìm kiếm:");
            for (int i = 0; i < luong; i++)
            {
                if (dsCanBo[i].HovaTen.ToLower().Contains(ten.ToLower()))
                {
                    dsCanBo[i].HienThi();
                    Console.WriteLine();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("==> Không tìm thấy cán bộ nào.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n==> Danh sách cán bộ:");
            for (int i = 0; i < luong; i++)
            {
                dsCanBo[i].HienThi();
                Console.WriteLine();
            }
        }
    }
}
