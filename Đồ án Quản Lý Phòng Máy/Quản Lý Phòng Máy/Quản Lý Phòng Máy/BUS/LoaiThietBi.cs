using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LoaiThietBi
    {
        private int _maLoai;
        private string _tenLoaiThietBi;

        public LoaiThietBi()
        {

        }

        public int MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenLoaiThietBi { get => _tenLoaiThietBi; set => _tenLoaiThietBi = value; }
    }
}
