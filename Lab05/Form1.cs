using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Add("C# WinForms cơ bản");
            cboKhoaHoc.Items.Add("SQL Server cơ bản");
            cboKhoaHoc.Items.Add("Web Frontend cơ bản");
            cboKhoaHoc.Items.Add("Lập trình Python cơ bản");

            cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void radOnline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được rỗng");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được rỗng!");
                return;
            }
            if (cboKhoaHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!");
                return;
            }
            double hocPhiMotThang = 0;
            if (cboKhoaHoc.SelectedIndex == 0) { hocPhiMotThang = 800000; }
            else if (cboKhoaHoc.SelectedIndex == 1) { hocPhiMotThang = 700000; }
            else if (cboKhoaHoc.SelectedIndex == 2) { hocPhiMotThang = 750000; }
            else hocPhiMotThang = 650000;
            int soThang = (int)numSoThang.Value;
            double tongHocPhi = hocPhiMotThang * soThang;
            string hinhThucHoc;

            if (radOnline.Checked)
            {
                hinhThucHoc = "Online";
            }
            else
            {
                hinhThucHoc = "Offline";
            }
            string nhanEmail;

            if (chkNhanEmail.Checked)
            {
                nhanEmail = "Có";
            }
            else
            {
                nhanEmail = "Không";
            }
            string phieuDangKy =
            "PHIẾU ĐĂNG KÝ KHÓA HỌC\n" +
            "------------------------------\n" +
            "Họ tên: " + txtHoTen.Text + "\n" +
            "Số điện thoại: " + txtSoDienThoai.Text + "\n" +
            "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\n" +
            "Khóa học: " + cboKhoaHoc.Text + "\n" +
            "Hình thức học: " + hinhThucHoc + "\n" +
            "Số tháng: " + numSoThang.Value + "\n" +
            "Tổng tiền: " + tongHocPhi.ToString("N0") + " VNĐ\n" +
              "Nhận email: " + nhanEmail;

            // Hiển thị phiếu
            MessageBox.Show(phieuDangKy, "Đăng ký thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // 1. Xóa họ tên và số điện thoại
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            // 2. Đưa ngày sinh về ngày hiện tại
            dtpNgaySinh.Value = DateTime.Now;
            // 3. Bỏ chọn nhận email
            chkNhanEmail.Checked = false;
            // 4. Chọn lại khóa học đầu tiên
            cboKhoaHoc.SelectedIndex = 0;
            // 5. Chọn lại hình thức Online
            radOnline.Checked = true;
            // 6. Đưa số tháng về 1
            numSoThang.Value = 1;
            // 7. Đưa con trỏ về ô họ tên
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

