using System;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool ketQua = true;

            // 1. Kiểm tra Họ tên: Không để trống và tối thiểu 3 ký tự
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải từ 3 ký tự trở lên!");
                ketQua = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra Số điện thoại: Đúng 10 chữ số, bắt đầu bằng "0"
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text.Length != 10 || !txtSDT.Text.StartsWith("0") || !long.TryParse(txtSDT.Text, out _))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0!");
                ketQua = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra Email: Chứa "@" và có dấu "." phía sau "@"
            int viTriAt = txtEmail.Text.IndexOf('@');
            int viTriDauCham = txtEmail.Text.LastIndexOf('.');
            if (viTriAt < 0 || viTriDauCham < 0 || viTriDauCham <= viTriAt + 1)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng (phải chứa @ và . phía sau)!");
                ketQua = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra Mật khẩu: Tối thiểu 6 ký tự
            if (string.IsNullOrEmpty(txtMatKhau.Text) || txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự!");
                ketQua = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra Xác nhận mật khẩu: Phải khớp với Mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Xác nhận mật khẩu không khớp với mật khẩu!");
                ketQua = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return ketQua;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void txtSDT_TextChanged(object sender, EventArgs e) { }
        private void txtXacNhanMK_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}