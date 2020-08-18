using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class CauHinh
    {
        //Khởi tạo các biến giá trị.
        int _maCauHinh, _manHinh, _chuot, _banPhim, _case, _CPU, _mainBoard, _VGA, _RAM, _OCung, _HDH, _PSU;
        string _tenCauHinh;

        //Khởi tạo mặc định.
        public CauHinh()
        {

        }
        
        //Hàm xử lý getter, setter.
        public int MaCauHinh { get => _maCauHinh; set => _maCauHinh = value; }
        public string TenCauHinh { get => _tenCauHinh; set => _tenCauHinh = value; }
        public int ManHinh { get => _manHinh; set => _manHinh = value; }
        public int Chuot { get => _chuot; set => _chuot = value; }
        public int BanPhim { get => _banPhim; set => _banPhim = value; }
        public int Case { get => _case; set => _case = value; }
        public int CPU { get => _CPU; set => _CPU = value; }
        public int MainBoard { get => _mainBoard; set => _mainBoard = value; }
        public int VGA { get => _VGA; set => _VGA = value; }
        public int RAM { get => _RAM; set => _RAM = value; }
        public int OCung { get => _OCung; set => _OCung = value; }
        public int HDH { get => _HDH; set => _HDH = value; }
        public int PSU { get => _PSU; set => _PSU = value; }
    }
}
