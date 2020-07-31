using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LichSuThanhLy
    {
        private int _maThanhLy;

        public int MaThanhLy
        {
            get { return _maThanhLy; }
            set { _maThanhLy = value; }
        }
        private DateTime _ngayThanhLy;

        public DateTime NgayThanhLy
        {
            get { return _ngayThanhLy; }
            set { _ngayThanhLy = value; }
        }
        private int _maThietBi;

        public int MaThietBi
        {
            get { return _maThietBi; }
            set { _maThietBi = value; }
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

        public LichSuThanhLy()
        {

        }
    }
}
