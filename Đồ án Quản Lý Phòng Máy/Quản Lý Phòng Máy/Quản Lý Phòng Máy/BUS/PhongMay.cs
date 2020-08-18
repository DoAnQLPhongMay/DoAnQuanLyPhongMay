using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class PhongMay
    {
        //Khởi tạo các biến giá trị.
        private int _maPhong;
        private int _soLuongMay;
        private string _tenPhong;
        private int _khoa;
        private int _trangThai;
        private string _ghiChu;

        //Hàm khởi tạo mặc định của class.
        public PhongMay()
        {
        }

        //Hàm xử lý getter và setter.
        public int MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
        public string TenPhong
        {
            get { return _tenPhong; }
            set { _tenPhong = value; }
        }
        public int SoLuongMay
        {
            get { return _soLuongMay; }
            set { _soLuongMay = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public int Khoa 
        { get => _khoa; set => _khoa = value; }
    }
}
