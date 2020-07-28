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
        private string _nhaSanXuat;
        private int _namSanXuat;
        private int _soLuong;
        private int _donGia;
        private string _nguoiPhuTrach;
        private int _trangThai;
        private string _ghiChu;

        public LichSuNhap()
        {

        }

        public int MaNhap 
        {
            get { return _maNhap; }
            set { _maNhap = value; } 
        }
        public DateTime NgayNhap 
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; } 
        }
        public int MaThietBi 
        {
            get { return _maThietBi; }
            set { _maThietBi = value; } 
        }
        public string NhaSanXuat { get { return _nhaSanXuat; }
            set { _nhaSanXuat = value; } }
        public int NamSanXuat { get { return _namSanXuat; }
            set { _namSanXuat = value; } }
        public int SoLuong { get { return _soLuong; }
            set { _soLuong = value; } }
        public int DonGia { get { return _donGia; }
            set { _donGia = value; } }
        public string NguoiPhuTrach { get { return _nguoiPhuTrach; }
            set { _nguoiPhuTrach = value; } }
        public int TrangThai { get { return _trangThai; }
            set { _trangThai = value; } }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
