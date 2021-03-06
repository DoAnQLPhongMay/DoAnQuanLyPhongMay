﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LichSuThanhLy
    {
        //Khởi tạo các biến giá trị.
        private int _maThanhLy;
        private DateTime _ngayThanhLy;
        private int _maThietBi;
        private int _maCauHinh;
        private string _nhaSanXuat;
        private int _soLuong;
        private int _namSanXuat;
        private int _donGia;
        private string _nguoiPhuTrach;
        private string _ghiChu;

        //Hàm khởi tạo mặc định của class.
        public LichSuThanhLy()
        {

        }

        //Hàm xử lý getter và setter.
        public int MaThanhLy
        {
            get { return _maThanhLy; }
            set { _maThanhLy = value; }
        }
        public DateTime NgayThanhLy
        {
            get { return _ngayThanhLy; }
            set { _ngayThanhLy = value; }
        }
        public int MaThietBi
        {
            get { return _maThietBi; }
            set { _maThietBi = value; }
        }
        public string NhaSanXuat
        {
            get { return _nhaSanXuat; }
            set { _nhaSanXuat = value; }
        }
        public int NamSanXuat
        {
            get { return _namSanXuat; }
            set { _namSanXuat = value; }
        }
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        public string NguoiPhuTrach
        {
            get { return _nguoiPhuTrach; }
            set { _nguoiPhuTrach = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public int MaCauHinh 
        { get => _maCauHinh; set => _maCauHinh = value; }
    }
}
