using Bai1;

QLCB qlcb = new QLCB();
string luaChon;

do
{
    Console.WriteLine("============== MENU ==============");
    Console.WriteLine("1. Thêm cán bộ");
    Console.WriteLine("2. Tìm kiếm theo họ tên");
    Console.WriteLine("3. Hiển thị danh sách cán bộ");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            qlcb.ThemCB();
            break;
        case "2":
            qlcb.TimKiemTheoTen();
            break;
        case "3":
            qlcb.HienThiDanhSach();
            break;
        case "4":
            Console.WriteLine("Đã thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.\n");
            break;
    }

    Console.WriteLine();
} while (luaChon != "4");