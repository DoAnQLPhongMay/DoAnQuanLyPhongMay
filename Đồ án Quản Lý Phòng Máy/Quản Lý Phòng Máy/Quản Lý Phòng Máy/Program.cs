﻿using QuanLyPhongMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            //Application.Run(new frmQLThietBi());
            //Application.Run(new frmTrangChu());
            //Application.Run(new frm_QLTaiKhoan());
            //Application.Run(new frmThemMay());
        }
    }
}
