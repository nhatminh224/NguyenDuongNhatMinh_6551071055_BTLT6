namespace bai1
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
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            txtXacNhanMK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(380, 86);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(213, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += textBox1_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(380, 140);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(209, 27);
            txtSDT.TabIndex = 1;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(380, 242);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(209, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(380, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += textBox5_TextChanged;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(380, 290);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(209, 27);
            txtXacNhanMK.TabIndex = 5;
            txtXacNhanMK.TextChanged += txtXacNhanMK_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 93);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ Tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 143);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 191);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 249);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 297);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 10;
            label5.Text = "Xác nhận mật khẩu";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(318, 38);
            label6.TabIndex = 11;
            label6.Text = "Đăng ký tài khoản mới";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 47);
            label7.Name = "label7";
            label7.Size = new Size(222, 20);
            label7.TabIndex = 12;
            label7.Text = "vui lòng nhập đầy đủ thông tin";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.Highlight;
            btnDangKy.ForeColor = SystemColors.ControlLightLight;
            btnDangKy.Location = new Point(300, 347);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(154, 39);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(497, 347);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(152, 39);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtXacNhanMK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
