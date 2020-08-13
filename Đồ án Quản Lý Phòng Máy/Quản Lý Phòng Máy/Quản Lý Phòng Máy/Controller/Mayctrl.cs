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

        public int Them(May m)
        {
          
            if (KiemTraTenMay(m.TenMay))
                return 0;
            return mayData.Them(m);
        }

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

        public int Luu(May m)
        {
            return mayData.Luu(m);
        }

        public int ThemChiTietMay(int maMay, int maLoai, int maThietBi)
        {
            return mayData.ThemChiTietMay(maMay, maLoai, maThietBi);
        }

        public bool KiemTraTenMay(string tenmay)
        {
            return mayData.KiemTraTenMay(tenmay);
        }
    }
}
