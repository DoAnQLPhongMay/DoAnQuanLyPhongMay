using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LoaiThietBi
    {
        //Khởi tạo các biến giá trị.
        private int _maLoai;
        private string _tenLoaiThietBi;

        //Hàm khỏi tạo mặc định.
        public LoaiThietBi()
        {

        }

        //Hàm getter, setter.
        public int MaLoai 
        { get => _maLoai; set => _maLoai = value; }
        public string TenLoaiThietBi 
        { get => _tenLoaiThietBi; set => _tenLoaiThietBi = value; }
    }
}
