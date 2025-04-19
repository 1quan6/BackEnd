using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class CanBo
    {
        public string HovaTen { get; set; }
        public int NamSinh { get; set; }    
        public string GioiTinh { get; set; }
        public string DiaChi {  get; set; }
        public CanBo() { }

        public CanBo(string HovaTen, int NamSinh, string GioiTinh, string DiaChi)
        {
            this.HovaTen = HovaTen;
            this.NamSinh = NamSinh;
            this.GioiTinh = GioiTinh;   
            this.DiaChi = DiaChi;   
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Họ và tên: ");
            HovaTen = Console.ReadLine();
            Console.WriteLine("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Họ và tên + {HovaTen}\n Năm Sinh: {NamSinh}\n Giới tính: {GioiTinh}\n Địa chỉ: {DiaChi}");
        }
    }
}
