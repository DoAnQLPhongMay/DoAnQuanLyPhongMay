using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class PhongMay
    {
        private int _maPhong;

        public int MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        private int _soLuongMay;

        public int SoLuongMay
        {
            get { return _soLuongMay; }
            set { _soLuongMay = value; }
        }
        private string _tenPhong;

        public string TenPhong
        {
            get { return _tenPhong; }
            set { _tenPhong = value; }
        }
        private int _trangThai;

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public PhongMay()
        {
        }

       
    }
}
