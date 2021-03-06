﻿using System;
using System.Windows.Forms;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLKhoa : Form
    {
        //Khởi tạo các biến giá trị và kết nối.
        Khoa khoa = new Khoa();
        KhoaCtrl khoaCtrl = new KhoaCtrl();
        User user = new User();
        string tenKhoa;
        string text;

        //Hàm xử lý khởi tạo mặc định của form.
        public frmQLKhoa()
        {
            InitializeComponent();
        }

        public frmQLKhoa(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load dữ liệu khi mở form.
        private void frmThemMay_Load(object sender, EventArgs e)
        {
            khoaCtrl.HienThiDgv(dgvDSKhoa);

            btnCapNhat.Enabled = false;
        }

        //Hàm lấy và gán các giá trị từ Datagridview.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaKhoa.Text = dgvDSKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvDSKhoa.CurrentRow.Cells[1].Value.ToString();
            tenKhoa = txtTenKhoa.Text;

            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        //Hàm xử lý làm mới các text.
        private void lamMoi()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTimKiem.Clear();
            radTenKhoa.Checked = false;
            tenKhoa = "";

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
            khoaCtrl.HienThiDgv(dgvDSKhoa);
        }

        //Hàm xuất thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm kiểm tra dữ liệu các text.
        private bool kiemTra()
        {
            bool kTra = true;

            if (txtTenKhoa.Text == "")
            {
                text = "Vui lòng nhập tên khoa!";
                ThongBao(text);
                kTra = false;
            }
            else if (khoaCtrl.KTTenKhoa(txtTenKhoa.Text) && tenKhoa != txtTenKhoa.Text)
            {
                text = "Tên khoa đã tồn tại!";
                ThongBao(text);
                kTra = false;
            }

            return kTra;
        }

        //Hàm xử lý chức năng thêm mới.
        private void btnThemMay_Click(object sender, EventArgs e)
        {
           if (kiemTra())
            {
                khoa.MaKhoa = khoaCtrl.GetID() + 1;
                khoa.TenKhoa = txtTenKhoa.Text;

                khoaCtrl.Them(khoa);
                MessageBox.Show("Thêm khoa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lamMoi();
            }
        }

        //Hàm xử lý chức năng xóa.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (user.PhanQuyen == 1)
            {
                if (dgvDSKhoa.CurrentRow != null)
                {
                    if(khoaCtrl.KTSuDung(Convert.ToInt32(dgvDSKhoa.CurrentRow.Cells[0].Value)) == false)
                    {
                        DialogResult dlg = MessageBox.Show("Sau khi xóa sẽ không thể khôi phục.\nBạn thật sự muốn xóa khoa này?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dlg == System.Windows.Forms.DialogResult.Yes)
                        {
                            int maKhoa = Convert.ToInt32(dgvDSKhoa.CurrentRow.Cells[0].Value);
                            khoaCtrl.Xoa(maKhoa);

                            MessageBox.Show("Xóa khoa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lamMoi();
                        }
                    }
                    else
                    {
                        text = "Không thể xóa. Vẫn còn phòng thuộc khoa này!";
                        ThongBao(text);
                    }
                }
                else
                {
                    text = "Vui lòng chọn khoa muốn xóa!";
                    ThongBao(text);
                }
            }
            else
            {
                text = "Bạn không được cấp quyền để xóa!";
                ThongBao(text);
            }
        }

        //Hàm xử lý chức năng cập nhật.
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    khoa.MaKhoa = Convert.ToInt32(txtMaKhoa.Text);
                    khoa.TenKhoa = txtTenKhoa.Text;

                    if (khoaCtrl.CapNhat(khoa)  > 0)
                    {
                        MessageBox.Show("Cập nhập khoa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        text = "Cập nhật thất bại. Vui lòng thử lại!";
                        ThongBao(text);
                    }

                    lamMoi();
                }
            }
        }

        //Hàm xử lý chức năng tìm kiếm.
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radTenKhoa.Checked)
            {
                loaiTK = "tenKhoa";
            }
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                khoaCtrl.TimKiem(dgvDSKhoa, txtTimKiem.Text, loaiTK);
            }
        }

        //Hàm xử lý chức năng làm mới dữ liệu của các text.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
    }
}
