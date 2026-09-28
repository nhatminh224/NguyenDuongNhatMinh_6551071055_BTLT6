namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose; // Nền đỏ nhạt khi lỗi[cite: 1, 2]
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew; // Nền xanh lá khi đúng[cite: 1, 2]
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtCCCD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 || !long.TryParse(txtCCCD.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool isValid = DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayNhan);

            if (!isValid || ngayNhan.Date < DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải đúng định dạng dd/MM/yyyy và từ hôm nay trở đi!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayNhan, ngayTra;
            bool parseNhan = DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayNhan);
            bool parseTra = DateTime.TryParseExact(txtNgayTra.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayTra);

            if (!parseTra || !parseNhan || ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải sau ngày nhận và đúng định dạng dd/MM/yyyy!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soNguoiLon;
            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTreEm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soTreEm;
            if (!int.TryParse(txtSoTreEm.Text, out soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }
        private void TextBoxes_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null);
                DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text, "dd/MM/yyyy", null);

                // Tính số đêm[cite: 2]
                int soDem = (ngayTra - ngayNhan).Days;

                // Hiển thị thông tin[cite: 2]
                string message = $"Đặt phòng thành công!\n" +
                                 $"- Họ tên khách: {txtHoTen.Text}\n" +
                                 $"- Số đêm: {soDem}\n" +
                                 $"- Số người lớn: {txtSoNguoiLon.Text}\n" +
                                 $"- Số trẻ em: {txtSoTreEm.Text}";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
