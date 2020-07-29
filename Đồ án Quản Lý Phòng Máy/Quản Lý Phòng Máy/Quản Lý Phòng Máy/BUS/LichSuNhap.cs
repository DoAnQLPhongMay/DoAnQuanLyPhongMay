using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LichSuNhap
    {
        private int _maNhap;
        private DateTime _ngayNhap;
        private int _maThietBi;
        private string _nhaCungCap;
        private string _nhaSanXuat;
        private int _namSanXuat;
        private int _soLuong;
        private int _donGia;
        private string _nguoiPhuTrach;
        private string _ghiChu;

        public LichSuNhap()
        {

        }

        public int MaNhap { get => _maNhap; set => _maNhap = value; }
        public DateTime NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
        public int MaThietBi { get => _maThietBi; set => _maThietBi = value; }
        public string NhaSanXuat { get => _nhaSanXuat; set => _nhaSanXuat = value; }
        public int NamSanXuat { get => _namSanXuat; set => _namSanXuat = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public string NguoiPhuTrach { get => _nguoiPhuTrach; set => _nguoiPhuTrach = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public string NhaCungCap { get => _nhaCungCap; set => _nhaCungCap = value; }
    }
}
