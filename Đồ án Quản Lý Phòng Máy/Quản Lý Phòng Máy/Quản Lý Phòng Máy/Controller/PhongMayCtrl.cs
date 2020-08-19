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
    class PhongMayCtrl
    {
        //Khởi tạo biến giá trị.
        PhongMayData phongData = new PhongMayData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return phongData.GetID();
        }

        public int GetSL(int maPhong)
        {
            return phongData.GetSLMay(maPhong);
        }

        public int GetCountMay(int maPhong)
        {
            return phongData.GetCountMay(maPhong);
        }

        //Hàm kiểm tra thiết bị có đang sử dụng.
        public bool KTSuDung(int maPhong)
        {
            return phongData.KTSuDung(maPhong);
        }

        //Hàm kiểm tra tên phòng đã tồn tại chưa.
        public bool KTTenPhong(string tenPhong)
        {
            return phongData.KTTenPhong(tenPhong);
        }

        //Hàm xử lý lấy số lượng máy của phòng.
        public int LaySLMay(int maPhong)
        {
            DataSet ds = phongData.LayPhong(maPhong);
            return Convert.ToInt32(ds.Tables[0].Rows[0]["SoLuongMay"]);
        }

        //Hàm xử lý lấy tên của phòng.
        public string LayTenPhong(int maPhong)
        {
            DataSet ds = phongData.LayPhong(maPhong);
            return ds.Tables[0].Rows[0]["TenPhongMay"].ToString();
        }

        //Hàm hiển thị danh sách phòng máy lên Datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = phongData.LayDSPhong().Tables[0];
        }

        //Hàm xử chức năng tìm kiếm phòng máy.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = phongData.LayDSTK(key, loaiTK).Tables[0];
        }

        //Hàm xử chức năng thêm mới phòng máy.
        public int Them(PhongMay phong)
        {
            return phongData.Them(phong);
        }

        //Hàm xử chức năng xóa phòng máy.
        public int Xoa(int maPhong)
        {
            return phongData.Xoa(maPhong);
        }

        //Hàm xử chức năng cập nhật phòng máy.
        public int CapNhat(PhongMay phong)
        {
            return phongData.CapNhat(phong);
        }

        //Hàm hiển thị dữ liệu lên combox.
        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = phongData.LayDSPhong().Tables[0];
            cb.DisplayMember = "TenPhongMay";
            cb.ValueMember = "MaPhongMay";
        }
    }
}
