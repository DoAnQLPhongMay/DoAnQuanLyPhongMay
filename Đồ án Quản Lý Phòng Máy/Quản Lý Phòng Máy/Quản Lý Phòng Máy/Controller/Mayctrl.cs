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

        public bool KTTenMay(string tenMay)
        {
            if (KiemTraTenMay(tenMay))
            {
                return true;
            }
            return false;
        }

        public int ThemMoi(May may)
        {
            return mayData.ThemMoi(may);
        }

        public int Xoa(int maMay)
        {
            return mayData.Xoa(maMay);
        }

        public int CapNhatMay(May may)
        {
            return mayData.CapNhatMay(may);
        }

        public bool KiemTraTenMay(string tenmay)
        {
            return mayData.KiemTraTenMay(tenmay);
        }
    }
}
