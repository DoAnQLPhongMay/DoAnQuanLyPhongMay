using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class TrangThai
    {
        //Khởi tạo các biến giá trị.
        private int _maTrangThai;
        private string _tenTrangThai;

        //Hàm khỏi tạo mặc định.
        public TrangThai()
        {

        }

        //Hàm xử lý getter và setter.
        public int MaTrangThai { get => _maTrangThai; set => _maTrangThai = value; }
        public string TenTrangThai { get => _tenTrangThai; set => _tenTrangThai = value; }
    }
}
