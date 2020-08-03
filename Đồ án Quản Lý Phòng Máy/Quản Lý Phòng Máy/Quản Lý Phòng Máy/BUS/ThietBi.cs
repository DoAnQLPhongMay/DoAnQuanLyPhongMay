using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class ThietBi
    {
        private int _maThietBi;
        private string _tenThietBi;
        private string _thongSoThietBi;
        private int _soLuong;
        private int _maLoai;
        private int _namSanXuat;
        private string _nhaSanXuat;
        private int _hanThanhLy;
        private string _ghiChu;

        public ThietBi()
        {

        }

        public int MaThietBi { get => _maThietBi; set => _maThietBi = value; }
        public string TenThietBi { get => _tenThietBi; set => _tenThietBi = value; }
        public string ThongSoThietBi { get => _thongSoThietBi; set => _thongSoThietBi = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int MaLoai { get => _maLoai; set => _maLoai = value; }
        public int NamSanXuat { get => _namSanXuat; set => _namSanXuat = value; }
        public string NhaSanXuat { get => _nhaSanXuat; set => _nhaSanXuat = value; }
        public int HanThanhLy { get => _hanThanhLy; set => _hanThanhLy = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
    }
}
