using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class LichSuCapNhat
    {
        int _maCapNhat, _maPhongMay, _maMay, _maCauHinh;
        string _ghiChu, _tenMay, _tenDangNhap;
        DateTime _ngayCapNhat;

        public LichSuCapNhat()
        {

        }

        public int MaCapNhat 
        { get => _maCapNhat; set => _maCapNhat = value; }
        public int MaPhongMay 
        { get => _maPhongMay; set => _maPhongMay = value; }
        public int MaMay 
        { get => _maMay; set => _maMay = value; }
        public int MaCauHinh 
        { get => _maCauHinh; set => _maCauHinh = value; }
        public string GhiChu 
        { get => _ghiChu; set => _ghiChu = value; }
        public string TenMay
        { get => _tenMay; set => _tenMay = value; }
        public DateTime NgayCapNhat 
        { get => _ngayCapNhat; set => _ngayCapNhat = value; }
        public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
    }
}
