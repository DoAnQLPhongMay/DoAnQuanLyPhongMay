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
        //Khởi tạo biến giá trị.
        LichSuNhapData lsNhapData = new LichSuNhapData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return lsNhapData.GetID();
        }

        //Hàm hiển thị danh sách LSNhap lên datagridview.
        public void HienThiDgv(DataGridView dgvTB, DataGridView dgvCH)
        {
            dgvTB.DataSource = lsNhapData.LayDSLichSuNhapTB().Tables[0];
            dgvCH.DataSource = lsNhapData.LayDSLichSuNhapCH().Tables[0];
        }

        //Hàm xử lý thêm mới LSNhap.
        public int ThemThietBi(LichSuNhap lsNhap)
        {
            return lsNhapData.ThemThietBi(lsNhap);
        }

        public int ThemCauHinh(LichSuNhap lsNhap)
        {
            return lsNhapData.ThemCauHinh(lsNhap);
        }

        //Hàm cập nhật lại số lượng sau khi thêm mới LSNhap.
        public int CapNhatSL(LichSuNhap lsNhap)
        {
            return lsNhapData.CapNhatSL(lsNhap);
        }

        //Hàm xử lý tìm kiếm LSNhap.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = lsNhapData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
