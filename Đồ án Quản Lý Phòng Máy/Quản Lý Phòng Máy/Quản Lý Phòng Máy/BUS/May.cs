using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class May
    {
        private int _mamay;

        public int MaMay
        {
            get { return _mamay; }
            set { _mamay = value; }
        }
        private int _maphong;

        public int MaPhong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }
        private string _tenmay;

        public string TenMay
        {
            get { return _tenmay; }
            set { _tenmay = value; }
        }
        private int _trangthai;

        public int TrangThai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
        private string _ghichu;

        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }

        public int Mathietbi { get => _mathietbi; set => _mathietbi = value; }
        public int MaCapNhat { get => _macapnhat; set => _macapnhat = value; }

        private int _mathietbi;

        private int _macapnhat;
        private DateTime _ngaycapnhat;

        public DateTime NgayCapNhat
        {
            get { return _ngaycapnhat; }
            set { _ngaycapnhat = value; }
        }

        public int MaCauHinh { get => _maCauHinh; set => _maCauHinh = value; }

        private int _maCauHinh;
    }
}
