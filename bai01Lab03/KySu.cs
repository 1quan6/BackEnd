using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class KySu:CanBo
    {
        public string NganhDaoTao {  get; set; }
        public KySu() { }
        public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.NganhDaoTao = nganhDaoTao;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ngành đào tạo: ");
            NganhDaoTao = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Ngành đào tạo: "+ NganhDaoTao);
        }
    }
}
