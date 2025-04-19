using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
        internal class CongNhan : CanBo
        {
            public string Bac { get; set; }
            public CongNhan() { }
            public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac) : base(hoTen, namSinh, gioiTinh, diaChi)
            {
                this.Bac = bac; 
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhập bậc (VD: 3/7): ");
                Bac = Console.ReadLine();
            }
            public override void HienThi()
            {
                base.HienThi();
                Console.WriteLine($"Bậc: {Bac}");
            }
        }
}
