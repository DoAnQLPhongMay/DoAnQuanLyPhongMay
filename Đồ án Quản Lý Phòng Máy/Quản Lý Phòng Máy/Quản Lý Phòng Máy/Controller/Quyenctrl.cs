using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongMay.DataLayer;

namespace QuanLyPhongMay.Controller
{
    class Quyenctrl
    {

        QuyenData quyen = new QuyenData();

        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = quyen.LayDSTrangThai().Tables[0];
            cb.DisplayMember = "TenQuyen";
            cb.ValueMember = "MaQuyen";
        }

    }
}
