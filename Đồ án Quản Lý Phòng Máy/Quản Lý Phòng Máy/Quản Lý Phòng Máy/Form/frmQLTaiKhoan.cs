﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frm_QLTaiKhoan : Form
    {
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            /*string querry = "SELECT * FROM dtb_TaiKhoan";
            DataSet ds = DBUtils.dsTable(querry, conn);

            dgv_DSTaiKhoan.DataSource = ds.Tables[0];
            dgv_DSTaiKhoan.Refresh();*/
           tkctrl.HienThi(dgv_DSTaiKhoan);
            HienThiThongTin();
        }
        void HienThiThongTin()
        {
            if (dgv_DSTaiKhoan.CurrentRow != null)
            {
                txt_Username.Text = dgv_DSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txt_Password.Text = dgv_DSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                txt_TenTaiKhoan.Text = dgv_DSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
                checkRadio();
                txt_SDT.Text = dgv_DSTaiKhoan.CurrentRow.Cells[5].Value.ToString();
                dtm_NgaySinh.Value = DateTime.Parse(dgv_DSTaiKhoan.CurrentRow.Cells[7].Value.ToString());
                txt_DiaChi.Text = dgv_DSTaiKhoan.CurrentRow.Cells[8].Value.ToString();
                txtMaQuyen.Text = dgv_DSTaiKhoan.CurrentRow.Cells[9].Value.ToString();
            }
        }
        void checkRadio()
        {
            string gtri = dgv_DSTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            rad_Nam.Checked = (gtri == "True") ? true : false;
            rad_Nu.Checked = (gtri == "False") ? true : false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themtk = new frmThemTaiKhoan();
            this.Hide();
            themtk.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSTaiKhoan.CurrentRow != null)
            {
                string tendn = dgv_DSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    tkctrl.Xoa(tendn);
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tkctrl.HienThi(dgv_DSTaiKhoan);
                    }
                }
            }    
               
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.TenGV = txt_TenTaiKhoan.Text;
            /*tk.Gioitinh = (rad_Nam.Checked) ? true : false;*/
            tk.SDT = txt_SDT.Text;
            tk.Ngaysinh = Convert.ToDateTime(dtm_NgaySinh.Value);
            tk.Diachi = txt_DiaChi.Text;
            
            if (tkctrl.Luu(tk) > 0)
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tkctrl.HienThi(dgv_DSTaiKhoan);
                HienThiThongTin();
            }
            else
            {
                MessageBox.Show("Lưu thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rad_TenTaiKhoan.Checked)
                tieuchi = "tentaikhoan";
            else if (rad_SDT.Checked)
                tieuchi = "sdt";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }
            if (txt_TiemKiem.Text.Length != 0 && tieuchi != "")
            {

                tkctrl.HienThiTK(dgv_DSTaiKhoan, txt_TiemKiem.Text, tieuchi);
            }    
                
            
        }

        private void dgv_DSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }

        private void dgv_DSTaiKhoan_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
    }
}
