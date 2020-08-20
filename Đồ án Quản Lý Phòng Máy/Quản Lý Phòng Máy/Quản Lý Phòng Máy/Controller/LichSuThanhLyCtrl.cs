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
        public void HienThiDgv(DataGridView dgvTB, DataGridView dgvCH)
        {
            dgvTB.DataSource = lsThanhLyData.LayDSLichSuThanhLyTB().Tables[0];
            dgvCH.DataSource = lsThanhLyData.LayDSLichSuThanhLyCH().Tables[0];
        }

        //Hàm xử lý thêm mới LSThanhLy.
        public int ThemThietBi(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.ThemThietBi(lsThanhLy);
        }

        public int ThemCauHinh(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.ThemCauHinh(lsThanhLy);
        }

        //Hàm cập nhật lại số lượng sau khi thêm mới LSThanhLy.
        public int CapNhatSL(LichSuThanhLy lsThanhLy)
        {
            return lsThanhLyData.CapNhatSL(lsThanhLy);
        }

        //Hàm xử lý tìm kiếm LSThanhLy.
        public void TimKiemTB(DataGridView dgv, string key1, string key2, string loaiTK)
        {
            dgv.DataSource = lsThanhLyData.LayDSTKTB(key1, key2, loaiTK).Tables[0];
        }

        public void TimKiemCH(DataGridView dgv, string key1, string key2, string loaiTK)
        {
            dgv.DataSource = lsThanhLyData.LayDSTKCH(key1, key2, loaiTK).Tables[0];
        }
    }
}
