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

        public PhongMay()
        {

        }

        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public int SoLuongMay { get => _soLuongMay; set => _soLuongMay = value; }
        public int MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
