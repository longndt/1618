namespace WinFormApp3
{
    partial class FormNhaKhoa
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
            label1 = new Label();
            txtKhachHang = new TextBox();
            cbMenRang = new CheckBox();
            cbTayRang = new CheckBox();
            rdNhoRang = new RadioButton();
            rdTramRang = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTongTien = new TextBox();
            btnHoaDon = new Button();
            btnNhapLai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(237, 21);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(292, 31);
            txtKhachHang.TabIndex = 1;
            // 
            // cbMenRang
            // 
            cbMenRang.AutoSize = true;
            cbMenRang.Location = new Point(44, 95);
            cbMenRang.Name = "cbMenRang";
            cbMenRang.Size = new Size(145, 29);
            cbMenRang.TabIndex = 2;
            cbMenRang.Text = "Lấy men răng";
            cbMenRang.UseVisualStyleBackColor = true;
            // 
            // cbTayRang
            // 
            cbTayRang.AutoSize = true;
            cbTayRang.Location = new Point(44, 152);
            cbTayRang.Name = "cbTayRang";
            cbTayRang.Size = new Size(112, 29);
            cbTayRang.TabIndex = 3;
            cbTayRang.Text = "Tẩy trắng";
            cbTayRang.UseVisualStyleBackColor = true;
            // 
            // rdNhoRang
            // 
            rdNhoRang.AutoSize = true;
            rdNhoRang.Location = new Point(44, 283);
            rdNhoRang.Name = "rdNhoRang";
            rdNhoRang.Size = new Size(112, 29);
            rdNhoRang.TabIndex = 4;
            rdNhoRang.TabStop = true;
            rdNhoRang.Text = "Nhổ răng";
            rdNhoRang.UseVisualStyleBackColor = true;
            // 
            // rdTramRang
            // 
            rdTramRang.AutoSize = true;
            rdTramRang.Location = new Point(44, 223);
            rdTramRang.Name = "rdTramRang";
            rdTramRang.Size = new Size(116, 29);
            rdTramRang.TabIndex = 5;
            rdTramRang.TabStop = true;
            rdTramRang.Text = "Trám răng";
            rdTramRang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 100);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 6;
            label2.Text = "200.000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 156);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 7;
            label3.Text = "500.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 225);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 8;
            label4.Text = "1.000.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 287);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 9;
            label5.Text = "100.000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(419, 100);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền";
            label6.Click += label6_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(419, 150);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(227, 31);
            txtTongTien.TabIndex = 11;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(424, 224);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(222, 34);
            btnHoaDon.TabIndex = 12;
            btnHoaDon.Text = "Tính hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(424, 287);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(222, 34);
            btnNhapLai.TabIndex = 13;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(308, 342);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 44);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormNhaKhoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 409);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnNhapLai);
            Controls.Add(btnHoaDon);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdTramRang);
            Controls.Add(rdNhoRang);
            Controls.Add(cbTayRang);
            Controls.Add(cbMenRang);
            Controls.Add(txtKhachHang);
            Controls.Add(label1);
            Name = "FormNhaKhoa";
            Text = "Tính tiền nha khoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKhachHang;
        private CheckBox cbMenRang;
        private CheckBox cbTayRang;
        private RadioButton rdNhoRang;
        private RadioButton rdTramRang;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTongTien;
        private Button btnHoaDon;
        private Button btnNhapLai;
        private Button btnThoat;
    }
}
