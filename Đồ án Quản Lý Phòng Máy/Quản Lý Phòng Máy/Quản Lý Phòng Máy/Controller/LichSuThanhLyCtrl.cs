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
    class LichSuThanhLyCtrl
    {
        LichSuThanhLyData lsThanhLyData = new LichSuThanhLyData();

        //Hàm hiển thị danh sách phòng máy lên Datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = lsThanhLyData.LayDSLichSuThanhLy().Tables[0];
        }

        //Hàm xử chức năng tìm kiếm phòng máy.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = lsThanhLyData.LayDSTK(key, loaiTK).Tables[0];
        }

        //Hàm xử chức năng thêm mới phòng máy.
        public int Them(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.Them(lsThanhLy);
        }
    }
}
