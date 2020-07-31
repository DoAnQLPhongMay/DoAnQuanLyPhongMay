using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class TrangThai
    {
        private int _maTrangThai;
        private string _tenTrangThai;

        public TrangThai()
        {

        }

        public int MaTrangThai { get => _maTrangThai; set => _maTrangThai = value; }
        public string TenTrangThai { get => _tenTrangThai; set => _tenTrangThai = value; }
    }
}
