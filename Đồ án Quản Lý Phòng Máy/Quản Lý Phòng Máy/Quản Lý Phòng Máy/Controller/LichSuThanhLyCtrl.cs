using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;
using System.Data;

namespace QuanLyPhongMay.Controller
{
    class LichSuThanhLyCtrl
    {
        //Khởi tạo biến giá trị.
        LichSuThanhLyData lsThanhLyData = new LichSuThanhLyData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return lsThanhLyData.GetID();
        }

        //Hàm hiển thị danh sách LSThanhLy lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = lsThanhLyData.LayDSLichSuThanhLy().Tables[0];
        }

        //Hàm xử lý thêm mới LSThanhLy.
        public int Them(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.Them(lsThanhLy);
        }

        //Hàm cập nhật lại số lượng sau khi thêm mới LSThanhLy.
        public int CapNhatSL(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.CapNhatSL(lsThanhLy);
        }

        //Hàm xử lý tìm kiếm LSThanhLy.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = lsThanhLyData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
