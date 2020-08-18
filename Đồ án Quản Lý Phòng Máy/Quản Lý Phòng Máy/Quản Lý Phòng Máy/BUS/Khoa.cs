using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class Khoa
    {
        //Khởi tạo biến giá trị.
        int _maKhoa;
        string _tenKhoa;

        //Khởi tạo mặc định.
        public Khoa()
        {

        }

        //Hàm xử lý getter, setter.
        public int MaKhoa { get => _maKhoa; set => _maKhoa = value; }
        public string TenKhoa { get => _tenKhoa; set => _tenKhoa = value; }
    }
}
