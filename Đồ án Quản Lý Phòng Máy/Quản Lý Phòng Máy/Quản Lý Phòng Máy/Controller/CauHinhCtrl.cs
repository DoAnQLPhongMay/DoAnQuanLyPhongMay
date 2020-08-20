using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;
using System.Data;
using System;

namespace QuanLyPhongMay.Controller
{
    class CauHinhCtrl
    {
        //Khởi tạo biến giá trị.
        CauHinhData cauHinhData = new CauHinhData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return cauHinhData.GetID();
        }

        //Hàm kiểm tra thiết bị có đang sử dụng.
        public bool KTSuDung(int maCauHinh)
        {
            return cauHinhData.KTSuDung(maCauHinh);
        }

        //Hàm kiểm tra tên.
        public bool KTCauHinh(string tenCauHinh)
        {
            return cauHinhData.KTCauHinh(tenCauHinh);
        }

        //Hàm xử lý hiển thị ds thiết bị lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = cauHinhData.LayDSCauHinh().Tables[0];
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbo(ComboBox cbo)
        {
            cbo.DataSource = cauHinhData.LayDSCauHinh().Tables[0];
            cbo.DisplayMember = "TenCauHinh";
            cbo.ValueMember = "MaCauHinh";
        }

        public int[] LayCauHinh(int maCauHinh)
        {
            int[] cauHinh = new int[12];
            DataSet ds = cauHinhData.LayDSCauHinh(maCauHinh);

            cauHinh[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["ManHinh"]);
            cauHinh[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["Chuot"]);
            cauHinh[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["BanPhim"]);
            cauHinh[4] = Convert.ToInt32(ds.Tables[0].Rows[0]["Thung"]);
            cauHinh[5] = Convert.ToInt32(ds.Tables[0].Rows[0]["CPU"]);
            cauHinh[6] = Convert.ToInt32(ds.Tables[0].Rows[0]["MainBoard"]);
            cauHinh[7] = Convert.ToInt32(ds.Tables[0].Rows[0]["RAM"]);
            cauHinh[8] = Convert.ToInt32(ds.Tables[0].Rows[0]["OCung"]);
            cauHinh[9] = Convert.ToInt32(ds.Tables[0].Rows[0]["VGA"]);
            cauHinh[10] = Convert.ToInt32(ds.Tables[0].Rows[0]["PSU"]);
            cauHinh[11] = Convert.ToInt32(ds.Tables[0].Rows[0]["HeDieuHanh"]);

            return cauHinh;
        }

        public int DemCH(int maCauHinh)
        {
            int count;
            DataSet ds = cauHinhData.LayDemCH(maCauHinh);

            count = Convert.ToInt32(ds.Tables[0].Rows[0]["DemCH"]);

            return count;
        }

        public int KTThietbi(int maThietBi)
        {
            DataSet ds = cauHinhData.KTThietBi(maThietBi);
            if (ds == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["MaCauHinh"]);
            }
        }

        //Hàm xử lý thêm mới.
        public int Them(CauHinh cauHinh)
        {
            return cauHinhData.Them(cauHinh);
        }

        //Hàm xử lý xóa.
        public int Xoa(int maCauHinh)
        {
            return cauHinhData.Xoa(maCauHinh);
        }

        //Hàm xử lý cập nhật.
        public int CapNhat(CauHinh cauHinh)
        {
            return cauHinhData.CapNhat(cauHinh);
        }

        //Hàm xử lý tìm kiếm.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = cauHinhData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
