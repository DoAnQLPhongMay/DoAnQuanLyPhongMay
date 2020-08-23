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
    class TaiKhoanCtrl
    {
        TaiKhoanData GVData = new TaiKhoanData();

        public void HienThiComboBox(ComboBox cb)
        {
            cb.DataSource = GVData.LayDSTK().Tables[0];
            cb.DisplayMember = "tentaikhoan";
            cb.ValueMember = "MaTaiKhoan";
        }

        public void HienThiTK(DataGridView dgv,string tukhoa, string tieuchi)
        {
            dgv.DataSource = GVData.LayDSTK(tukhoa, tieuchi).Tables[0];
        }

        public TaiKhoan DuLieuGV(string ten)
        {
            DataSet ds = GVData.LayDLMotDong(ten);
            TaiKhoan gv = new TaiKhoan();
            gv.TenDangNhap = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
            gv.MatKhau = ds.Tables[0].Rows[0]["MatKhau"].ToString();
            gv.MaGV = ds.Tables[0].Rows[0]["MaTaiKhoan"].ToString().ToString();
            gv.TenGV = ds.Tables[0].Rows[0]["HoVaTen"].ToString();
            gv.Gioitinh = (bool)ds.Tables[0].Rows[0]["GioiTinh"];
            gv.SDT = ds.Tables[0].Rows[0]["SDT"].ToString();
            gv.Email = ds.Tables[0].Rows[0]["Email"].ToString();
            gv.Ngaysinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString());
            gv.Diachi = ds.Tables[0].Rows[0]["DiaChi"].ToString();
            gv.Loaitaikhoan = Convert.ToInt32(ds.Tables[0].Rows[0]["LoaiTaiKhoan"]);
            return gv;
        }

        public void HienThi(DataGridView dgv)
        {
         dgv.DataSource = GVData.LayDSGiangVien().Tables[0];
        }

        public int Them(TaiKhoan gv)
        {
            if (!KiemTraSDT(gv.SDT))
                return 0;
            if (KiemTraTonTai(gv.TenDangNhap))
                return -1;
            if (KiemTraMatk(gv.MaGV))
                return 2;
            return GVData.Them(gv);
        }

        public int Xoa(string tendn)
        {
            return GVData.Xoa(tendn);
        }

        public int Luu(TaiKhoan gv)
        {
            if (!KiemTraSDT(gv.SDT))
                return 0;
            return GVData.Luu(gv);
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

        public bool KTLSThanhLy(string taikhoan)
        {
            return GVData.KTLSThanhLy(taikhoan);
        }

        public bool KTLSNhap(string taikhoan)
        {
            return GVData.KTLSNhap(taikhoan);
        }

        public bool KTLSCapNhat(string taikhoan)
        {
            return GVData.KTLSCapNhat(taikhoan);
        }

        public bool KiemTraMaQuyen(int maquyen)
        {
            return GVData.KiemTraQuyen(maquyen);
        }

        public bool KiemTraMatk(string matk)
        {
            return GVData.KiemTraMaTaiKhoan(matk);
        }
    }
}
