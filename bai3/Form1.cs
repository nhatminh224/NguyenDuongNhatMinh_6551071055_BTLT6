namespace bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }
        private void DangKyEnterChuyenField()
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.KeyPress += TextBox_KeyPress;
            }
        }
        private void  TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if(sender == txtDiemAnh)
                {
                    btnLuu.PerformClick();
                    txtMaHS.Focus();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }
        private void lstForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal diemToan, diemAnh, diemVan;
            if (!decimal.TryParse(txtDiemToan.Text, out diemToan) || diemToan < 0.0m || diemToan > 10.0m)
            {
                errorProvider1.SetError(txtDiemToan, "Diem toan phai lon hon 0 be hon 10");
                txtDiemToan.Focus();
                return;
            }
            errorProvider1.SetError(txtDiemToan, "");
            if (!decimal.TryParse(txtDiemVan.Text, out diemVan) || diemVan < 0.0m || diemVan > 10.0m)
            {
                errorProvider2.SetError(txtDiemVan, "Diem van phai lon hon 0 be hon 10");
                txtDiemVan.Focus();
                return;
            }
            errorProvider2.SetError(txtDiemVan, "");
            if (!decimal.TryParse(txtDiemAnh.Text, out diemAnh)|| diemAnh < 0.0m || diemAnh > 10.0m){
                errorProvider3.SetError(txtDiemAnh, "Diem anh phai lon hon 0 be hon 10");
                txtDiemAnh.Focus();
                return;
            }
            errorProvider3.SetError(txtDiemAnh, "");
            lstForm.Items.Add(txtMaHS.Text + " | " +
            txtHoTen.Text + " | " +
            "T:" + txtDiemToan.Text + " " +
            "V:" + txtDiemVan.Text + " " +
            "A:" + txtDiemAnh.Text
            );
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtDiemToan.Clear();
            txtDiemVan.Clear();
            txtDiemAnh.Clear();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtDiemToan.Clear();
            txtDiemVan.Clear();
            txtDiemAnh.Clear();
            txtMaHS.Focus();
        }
    }
}
