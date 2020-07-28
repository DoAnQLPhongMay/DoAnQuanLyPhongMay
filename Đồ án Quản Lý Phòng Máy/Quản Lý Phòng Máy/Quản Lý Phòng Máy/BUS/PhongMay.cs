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
        private int _soLuongMay;
        private string _tenPhong;
        private int _trangThai;
        private string _ghiChu;

        public PhongMay()
        {

        }

        public string TenPhong {
            get {return _tenPhong;}
            set { _tenPhong = value; }
        }
        public int SoLuongMay { 
            get {return _soLuongMay;}
            set { _soLuongMay = value; }
        } 
        public int MaPhong {
            get { return _maPhong; }
            set { _maPhong = value; } }
        public string GhiChu { 
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
    }
    
}
