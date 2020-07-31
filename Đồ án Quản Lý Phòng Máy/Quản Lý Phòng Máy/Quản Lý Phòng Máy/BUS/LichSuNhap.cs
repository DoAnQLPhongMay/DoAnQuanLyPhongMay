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

        public int MaNhap
        {
            get { return _maNhap; }
            set { _maNhap = value; }
        }
        private DateTime _ngayNhap;

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }
        private int _maThietBi;

        public int MaThietBi
        {
            get { return _maThietBi; }
            set { _maThietBi = value; }
        }
        private string _nhaCungCap;

        public string NhaCungCap
        {
            get { return _nhaCungCap; }
            set { _nhaCungCap = value; }
        }
        private string _nhaSanXuat;

        public string NhaSanXuat
        {
            get { return _nhaSanXuat; }
            set { _nhaSanXuat = value; }
        }
        private int _namSanXuat;

        public int NamSanXuat
        {
            get { return _namSanXuat; }
            set { _namSanXuat = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private int _donGia;

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        private string _nguoiPhuTrach;

        public string NguoiPhuTrach
        {
            get { return _nguoiPhuTrach; }
            set { _nguoiPhuTrach = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public LichSuNhap()
        {

        }

       
    }
}
