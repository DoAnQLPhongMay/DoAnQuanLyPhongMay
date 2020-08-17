using QuanLyPhongMay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    public partial class frmLichSuCapNhat : Form
    {
        User user = new User();
        public frmLichSuCapNhat()
        {
            InitializeComponent();
        }

        public frmLichSuCapNhat(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmLichSuCapNhat_Load(object sender, EventArgs e)
        {

        }
    }
}
