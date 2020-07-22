using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongMay.DataLayer;
using System.Windows.Forms;
using QuanLyPhongMay.BUS;
using System.Data;

namespace QuanLyPhongMay.Controller
{
    class GiangVienctrl
    {
        GiangVienDATA GVData = new GiangVienDATA();
        public void HienThiComboBox(ComboBox cb)
        {
            cb.DataSource = GVData.LayDSGiangVien().Tables[0];
            cb.DisplayMember = "TenNV";
            cb.ValueMember = "MaNV";
        }
        public void HienThiTK(DataGridView dgv,string tukhoa, string tieuchi)
        {
            dgv.DataSource = GVData.LayDSTK(tukhoa, tieuchi).Tables[0];
        }
        public GiangVien DuLieuNV(string ten)
        {
            DataSet ds = GVData.LayDLMotDong(ten);
            GiangVien gv = new GiangVien();
            gv.MaGV = int.Parse(ds.Tables[0].Rows[0]["MaNV"].ToString());
            gv.TenGV = ds.Tables[0].Rows[0]["TenNV"].ToString();
            gv.Ngaysinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString());
            gv.Gioitinh = (bool)ds.Tables[0].Rows[0]["GioiTinh"];
            gv.Diachi = ds.Tables[0].Rows[0]["DiaChi"].ToString();
            gv.SoDienThoai = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
            gv.TenDangNhap = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
            gv.MatKhau = ds.Tables[0].Rows[0]["MatKhau"].ToString();
            return gv;
        }
        //public void HienThi(DataGridView dgv)
        //{
        //  dgv.DataSource = GVData.LayDSGiangVien.Tables[0];
       // }
        public int Them(GiangVien gv)
        {
            if (!KiemTraSDT(gv.SoDienThoai))
                return 0;
            if (KiemTraTonTai(gv.TenDangNhap))
                return -1;
            return GVData.Them(gv);
        }
        public int Xoa(int ma)
        {
            return GVData.Xoa(ma);
        }
        public int Luu(GiangVien gv)
        {
            if (!KiemTraSDT(gv.SoDienThoai))
                return 0;
            return GVData.Luu(gv);
        }
        public int DoiThongTin(GiangVien gv,string matkhaucu,string matkhauNcu)
        {
            if (!KiemTraSDT(gv.SoDienThoai))
                return 0;
            if (!KiemTraMatKhau(matkhauNcu, matkhaucu))
                return -1;
            return GVData.DoiThongTin(gv);
        }
        private bool KiemTraMatKhau(string matkhauNcu,string matkhaucu)
        {
            if (DataProvider.MD5(matkhauNcu) != matkhaucu)
                return false;
            return true;
        }
        private bool KiemTraSDT(string sdt)
        {
            long k = 0;
            if (!long.TryParse(sdt, out k))
                return false;
            if (sdt.Length > 11)
                return false;
            return true;
        }
        public bool KiemTraTonTai(string taikhoan)
        {
            return GVData.KiemTra(taikhoan);
        }
    }
}
