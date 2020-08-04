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
    public partial class frmQLThietBi : Form
    {
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        ThietBi thietBi = new ThietBi();
        LoaiThietBiCtrl loaiThietBiCtrl = new LoaiThietBiCtrl();
        bool doubleClick = false;

        public frmQLThietBi()
        {
            InitializeComponent();
        }

        private void frm_QLMay_Load(object sender, EventArgs e)
        {
            thietBiCtrl.HienThiDgv(dgvDSThietBi);
            loaiThietBiCtrl.HienThiCbo(cboLoaiThietBi);
            cboLoaiThietBi.Text = "";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaThietBi.Text = dgvDSThietBi.CurrentRow.Cells[0].Value.ToString();
            txtTenThietBi.Text = dgvDSThietBi.CurrentRow.Cells[1].Value.ToString();
            rtbThongSo.Text = dgvDSThietBi.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDSThietBi.CurrentRow.Cells[3].Value.ToString();
            cboLoaiThietBi.SelectedItem = Convert.ToInt32(dgvDSThietBi.CurrentRow.Cells[4].Value.ToString());
            txtNhaSanXuat.Text = dgvDSThietBi.CurrentRow.Cells[6].Value.ToString();
            txtNamSanXuat.Text = dgvDSThietBi.CurrentRow.Cells[5].Value.ToString();
            txtHanThanhLy.Text = dgvDSThietBi.CurrentRow.Cells[7].Value.ToString();
            rtbGhiChu.Text = dgvDSThietBi.CurrentRow.Cells[8].Value.ToString();

            btnThemMoi.Hide();
            btnXoa.Hide();
            doubleClick = true;
        }

        private void lamMoi()
        {
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
            rtbThongSo.Text = "";
            txtSoLuong.Text = "";
            cboLoaiThietBi.Text = "";
            txtNhaSanXuat.Text = "";
            txtNamSanXuat.Text = "";
            txtHanThanhLy.Text = "";
            rtbGhiChu.Text = "";

            btnThemMoi.Show();
            btnXoa.Show();
            doubleClick = false;
            thietBiCtrl.HienThiDgv(dgvDSThietBi);
        }

        public int autoID()
        {
            int id = 1, row;

            row = dgvDSThietBi.Rows.Count;
            
            if (row != 0)
            {
                //id = Convert.ToInt32(dgv.Rows[row-1].Cells[0].Value.ToString());
                id = row;
            }

            return id;
        }

        public bool kiemTra()
        {
            bool kTra = true;

            if(txtTenThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if(cboLoaiThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else
            {
                if (txtSoLuong.Text == "")
                {
                    txtSoLuong.Text = "0";
                }
                if (txtHanThanhLy.Text == "")
                {
                    txtHanThanhLy.Text = "0";
                }
                if (txtNamSanXuat.Text == "")
                {
                    txtNamSanXuat.Text = DateTime.Now.Year.ToString();
                }
            }

            return kTra;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                thietBi.MaThietBi = autoID();
                thietBi.TenThietBi = txtTenThietBi.Text;
                thietBi.ThongSoThietBi = rtbThongSo.Text;
                thietBi.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                thietBi.MaLoai = Convert.ToInt32(cboLoaiThietBi.SelectedValue.ToString());
                thietBi.NhaSanXuat = txtNhaSanXuat.Text;
                thietBi.NamSanXuat = Convert.ToInt32(txtNamSanXuat.Text);
                thietBi.HanThanhLy = Convert.ToInt32(txtHanThanhLy.Text);
                thietBi.GhiChu = rtbGhiChu.Text;

                thietBiCtrl.Them(thietBi);
                MessageBox.Show("Thêm thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thietBiCtrl.HienThiDgv(dgvDSThietBi);
                lamMoi();

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(dgvDSThietBi.CurrentRow != null)
            {
                int maThietBi = Convert.ToInt32(dgvDSThietBi.CurrentRow.Cells[0].Value);
                thietBiCtrl.Xoa(maThietBi);
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK);
                thietBiCtrl.HienThiDgv(dgvDSThietBi);
                lamMoi();
            }
            else
            {
                MessageBox.Show("Vùi lòng chọn thiết bị muốn xóa ở danh sách thiết bị!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (doubleClick && kiemTra())
            {
                thietBi.MaThietBi = Convert.ToInt32(txtMaThietBi.Text);
                thietBi.TenThietBi = txtTenThietBi.Text;
                thietBi.ThongSoThietBi = rtbThongSo.Text;
                thietBi.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                thietBi.MaLoai = Convert.ToInt32(cboLoaiThietBi.SelectedValue.ToString());
                thietBi.NhaSanXuat = txtNhaSanXuat.Text;
                thietBi.NamSanXuat = Convert.ToInt32(txtNamSanXuat.Text);
                thietBi.HanThanhLy = Convert.ToInt32(txtHanThanhLy.Text);
                thietBi.GhiChu = rtbGhiChu.Text;

                MessageBox.Show("Thêm thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thietBiCtrl.CapNhat(thietBi);
                thietBiCtrl.HienThiDgv(dgvDSThietBi);
                lamMoi();
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radMaThietBi.Checked)
                loaiTK = "maThietBi";
            else if (radTenThietBi.Checked)
                loaiTK = "tenThietBi";
            else if (radNhaSanXuat.Checked)
                loaiTK = "nhaSanXuat";
            else if (radLoaiThietBi.Checked)
                loaiTK = "maLoai";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                thietBiCtrl.TimKiem(dgvDSThietBi, txtTimKiem.Text, loaiTK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //Hàm không xử dụng -------------------------------------------------------------------------------------//
        private void grp_TimKiem_Enter(object sender, EventArgs e)
        {

        }
        private void dgv_DSMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_Click(object sender, EventArgs e)
        {
        }
    }
}
