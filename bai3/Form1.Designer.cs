namespace bai5._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtDiemToan = new TextBox();
            txtDiemVan = new TextBox();
            txtDiemAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstForm = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 35);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 35);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(677, 35);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(50, 73);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(92, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(170, 73);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(168, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtDiemToan
            // 
            txtDiemToan.Location = new Point(361, 73);
            txtDiemToan.Name = "txtDiemToan";
            txtDiemToan.Size = new Size(99, 27);
            txtDiemToan.TabIndex = 2;
            // 
            // txtDiemVan
            // 
            txtDiemVan.Location = new Point(520, 73);
            txtDiemVan.Name = "txtDiemVan";
            txtDiemVan.Size = new Size(102, 27);
            txtDiemVan.TabIndex = 3;
            // 
            // txtDiemAnh
            // 
            txtDiemAnh.Location = new Point(677, 73);
            txtDiemAnh.Name = "txtDiemAnh";
            txtDiemAnh.Size = new Size(96, 27);
            txtDiemAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.MediumSeaGreen;
            btnLuu.Location = new Point(48, 118);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 37);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.AppWorkspace;
            btnXoaTrang.Location = new Point(170, 118);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 37);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstForm
            // 
            lstForm.FormattingEnabled = true;
            lstForm.Location = new Point(48, 166);
            lstForm.Name = "lstForm";
            lstForm.Size = new Size(704, 264);
            lstForm.TabIndex = 12;
            lstForm.SelectedIndexChanged += lstForm_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeftChanged += btnLuu_Click;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            errorProvider2.RightToLeftChanged += btnLuu_Click;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            errorProvider3.RightToLeftChanged += btnLuu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstForm);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtDiemAnh);
            Controls.Add(txtDiemVan);
            Controls.Add(txtDiemToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nhập điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtDiemToan;
        private TextBox txtDiemVan;
        private TextBox txtDiemAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstForm;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
