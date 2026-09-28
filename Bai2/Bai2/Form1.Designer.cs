namespace Bai2
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
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(167, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(255, 31);
            txtHoTen.TabIndex = 1;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBoxes_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "Số CCCD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 133);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 3;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 195);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 4;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 268);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 5;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 339);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 6;
            label6.Text = "Số trẻ em";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(167, 99);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(255, 31);
            txtCCCD.TabIndex = 7;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBoxes_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(167, 161);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(255, 31);
            txtNgayNhan.TabIndex = 8;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBoxes_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(167, 223);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(255, 31);
            txtNgayTra.TabIndex = 9;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBoxes_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(167, 296);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(255, 31);
            txtSoNguoiLon.TabIndex = 10;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBoxes_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(167, 367);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(255, 31);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.TextChanged += txtSoTreEm_TextChanged;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBoxes_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Location = new Point(167, 407);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(255, 34);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
