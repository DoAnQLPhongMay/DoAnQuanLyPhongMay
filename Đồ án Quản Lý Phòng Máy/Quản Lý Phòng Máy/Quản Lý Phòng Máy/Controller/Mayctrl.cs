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
    class MayCtrl
    {
        MayData mayData = new MayData();

        public int GetID()
        {
            return mayData.GetID();
        }

        public int GetIDLSCapNhat()
        {
            return mayData.GetIDLSCapNhat();
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = mayData.LayDSMay().Tables[0];
        }

        public void HienThi(DataGridView dgv, int maPhong)
        {
            dgv.DataSource = mayData.LayDSMay(maPhong).Tables[0];
        }

        public void TimKiem(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = mayData.LayDSTK(tukhoa, tieuchi).Tables[0];
        }

        /*public int Them(May m)
        {
          
            if (KiemTraTenMay(m.TenMay))
                return 0;
            return mayData.Them(m);
        }*/

        public int ThemMoi(May may)
        {
            if (KiemTraTenMay(may.TenMay))
                return 0;
            return mayData.ThemMoi(may);
        }

        public int Xoa(int maMay)
        {
            mayData.XoaChiTiet(maMay);
            return mayData.Xoa(maMay);
        }

        public int CapNhatMay(May m)
        {
            return mayData.CapNhatMay(m);
        }

        public int CapNhatChiTiet(int maMay, int maLoai, int maThietBi)
        {
            if(mayData.KiemTraChiTiet(maMay, maLoai))
            {
                return mayData.CapNhatChiTiet(maMay, maLoai, maThietBi);
            }
            return mayData.ThemChiTietMay(maMay, maLoai, maThietBi);

        }

        public int ThemChiTietMay(int maMay, int maLoai, int maThietBi)
        {
            return mayData.ThemChiTietMay(maMay, maLoai, maThietBi);
        }

        public bool KiemTraTenMay(string tenmay)
        {
            return mayData.KiemTraTenMay(tenmay);
        }

        public void ThemLSCapNhat(May may, string user)
        {
            DateTime ngayCapNhat = DateTime.Now;
            mayData.ThemLSCapNhat(this.GetIDLSCapNhat()+1, may , user, ngayCapNhat);
        }
        public void ThemChiTietCapNhat(May may, int maLoai, int maThietBi)
        {
            mayData.ThemChiTietLSCapNhat(this.GetIDLSCapNhat(), may, maLoai, maThietBi);
        }
    }
}
