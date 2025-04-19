using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class NhanVien:CanBo
    {
        public string CongViec {  get; set; } 
        public NhanVien() { }
        public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.CongViec = CongViec;
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }
}
