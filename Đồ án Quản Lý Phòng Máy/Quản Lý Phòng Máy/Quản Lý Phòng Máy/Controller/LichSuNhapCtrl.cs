using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;

namespace QuanLyPhongMay.Controller
{
    class LichSuNhapCtrl
    {
        LichSuNhapData lsNhapData = new LichSuNhapData();

        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = lsNhapData.LayDSLichSuNhap().Tables[0];
        }

        public int Them(LichSuNhap lsNhap)
        {
            return lsNhapData.Them(lsNhap);
        }

        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = lsNhapData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
