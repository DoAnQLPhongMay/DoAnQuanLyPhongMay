using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.Class
{
    public class TTThietBi
    {
        //Khởi tạo biến giá trị.
        private int _maThietBi, _maLoai, _namSanXuat, _soLuong;
        private string _tenThietBi, _nhaSanXuat;

        //Hàm getter và setter.
        public int MaThietBi { get => _maThietBi; set => _maThietBi = value; }
        public int MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenThietBi { get => _tenThietBi; set => _tenThietBi = value; }
        public string NhaSanXuat { get => NhaSanXuat1; set => NhaSanXuat1 = value; }
        public int NamSanXuat { get => _namSanXuat; set => _namSanXuat = value; }
        public string NhaSanXuat1 { get => _nhaSanXuat; set => _nhaSanXuat = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }

        //Khởi tạo mặc định của class.
        public TTThietBi()
        {
            this.MaLoai = 0;
            this.MaThietBi = 0;
            this.TenThietBi = "";
            this.NamSanXuat = 0;
            this.NhaSanXuat1 = "";
            this.SoLuong = 0;
        }

        public TTThietBi(TTThietBi thietBi)
        {
            this.MaLoai = thietBi.MaLoai;
            this.MaThietBi = thietBi.MaThietBi;
            this.TenThietBi = thietBi.TenThietBi;
            this.NamSanXuat = thietBi.NamSanXuat;
            this.NhaSanXuat1 = thietBi.NhaSanXuat;
            this.SoLuong = thietBi.SoLuong;

        }
    }
}
