namespace WinForm3
{
    partial class AdminForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbFullName = new TextBox();
            cmbBirthplace = new ComboBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label9 = new Label();
            dtpBirthday = new DateTimePicker();
            btnOK = new Button();
            label10 = new Label();
            tbFullName_Output = new TextBox();
            tbGender_Output = new TextBox();
            tbBirthplace_Output = new TextBox();
            tbBirthday_Output = new TextBox();
            label11 = new Label();
            cbGraduated = new CheckBox();
            label12 = new Label();
            tbGraduated_Output = new TextBox();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(150, 42);
            label1.Name = "label1";
            label1.Size = new Size(163, 47);
            label1.TabIndex = 0;
            label1.Text = "INPUT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(731, 31);
            label2.Name = "label2";
            label2.Size = new Size(207, 47);
            label2.TabIndex = 1;
            label2.Text = "OUTPUT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(41, 143);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(41, 311);
            label4.Name = "label4";
            label4.Size = new Size(134, 27);
            label4.TabIndex = 3;
            label4.Text = "Birthplace";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(639, 132);
            label5.Name = "label5";
            label5.Size = new Size(133, 27);
            label5.TabIndex = 4;
            label5.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(41, 225);
            label6.Name = "label6";
            label6.Size = new Size(99, 27);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(639, 214);
            label7.Name = "label7";
            label7.Size = new Size(99, 27);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(638, 300);
            label8.Name = "label8";
            label8.Size = new Size(134, 27);
            label8.TabIndex = 7;
            label8.Text = "Birthplace";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(248, 139);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(272, 31);
            tbFullName.TabIndex = 8;
            // 
            // cmbBirthplace
            // 
            cmbBirthplace.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBirthplace.FormattingEnabled = true;
            cmbBirthplace.Items.AddRange(new object[] { "Hà Nội", "Hải Phong", "Hải Dương", "Nam Định", "Quảng Ninh", "Hà Nam", "Thanh Hóa", "Nghệ An", "Lào Cai", "Thái Nguyên" });
            cmbBirthplace.Location = new Point(255, 303);
            cmbBirthplace.Name = "cmbBirthplace";
            cmbBirthplace.Size = new Size(265, 33);
            cmbBirthplace.TabIndex = 9;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbMale.Location = new Point(270, 223);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(79, 29);
            rbMale.TabIndex = 10;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbFemale.Location = new Point(402, 223);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(97, 29);
            rbFemale.TabIndex = 11;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(41, 405);
            label9.Name = "label9";
            label9.Size = new Size(115, 27);
            label9.TabIndex = 12;
            label9.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(257, 396);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(263, 31);
            dtpBirthday.TabIndex = 13;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.MistyRose;
            btnOK.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Red;
            btnOK.Location = new Point(306, 565);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(128, 55);
            btnOK.TabIndex = 14;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(639, 394);
            label10.Name = "label10";
            label10.Size = new Size(115, 27);
            label10.TabIndex = 15;
            label10.Text = "Birthday";
            // 
            // tbFullName_Output
            // 
            tbFullName_Output.BackColor = SystemColors.Info;
            tbFullName_Output.Enabled = false;
            tbFullName_Output.Location = new Point(831, 128);
            tbFullName_Output.Name = "tbFullName_Output";
            tbFullName_Output.ReadOnly = true;
            tbFullName_Output.Size = new Size(272, 31);
            tbFullName_Output.TabIndex = 16;
            // 
            // tbGender_Output
            // 
            tbGender_Output.BackColor = SystemColors.Info;
            tbGender_Output.Enabled = false;
            tbGender_Output.Location = new Point(831, 214);
            tbGender_Output.Name = "tbGender_Output";
            tbGender_Output.ReadOnly = true;
            tbGender_Output.Size = new Size(272, 31);
            tbGender_Output.TabIndex = 17;
            // 
            // tbBirthplace_Output
            // 
            tbBirthplace_Output.BackColor = SystemColors.Info;
            tbBirthplace_Output.Enabled = false;
            tbBirthplace_Output.Location = new Point(831, 300);
            tbBirthplace_Output.Name = "tbBirthplace_Output";
            tbBirthplace_Output.ReadOnly = true;
            tbBirthplace_Output.Size = new Size(272, 31);
            tbBirthplace_Output.TabIndex = 18;
            // 
            // tbBirthday_Output
            // 
            tbBirthday_Output.BackColor = SystemColors.Info;
            tbBirthday_Output.Enabled = false;
            tbBirthday_Output.Location = new Point(831, 387);
            tbBirthday_Output.Name = "tbBirthday_Output";
            tbBirthday_Output.ReadOnly = true;
            tbBirthday_Output.Size = new Size(272, 31);
            tbBirthday_Output.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(41, 486);
            label11.Name = "label11";
            label11.Size = new Size(138, 27);
            label11.TabIndex = 20;
            label11.Text = "Graduated";
            // 
            // cbGraduated
            // 
            cbGraduated.AutoSize = true;
            cbGraduated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbGraduated.Location = new Point(257, 486);
            cbGraduated.Name = "cbGraduated";
            cbGraduated.Size = new Size(65, 29);
            cbGraduated.TabIndex = 21;
            cbGraduated.Text = "Yes";
            cbGraduated.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(639, 475);
            label12.Name = "label12";
            label12.Size = new Size(138, 27);
            label12.TabIndex = 22;
            label12.Text = "Graduated";
            // 
            // tbGraduated_Output
            // 
            tbGraduated_Output.BackColor = SystemColors.Info;
            tbGraduated_Output.Enabled = false;
            tbGraduated_Output.Location = new Point(831, 475);
            tbGraduated_Output.Name = "tbGraduated_Output";
            tbGraduated_Output.ReadOnly = true;
            tbGraduated_Output.Size = new Size(272, 31);
            tbGraduated_Output.TabIndex = 23;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 255, 255);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(0, 64, 0);
            btnLogout.Location = new Point(906, 565);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 55);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 654);
            Controls.Add(btnLogout);
            Controls.Add(tbGraduated_Output);
            Controls.Add(label12);
            Controls.Add(cbGraduated);
            Controls.Add(label11);
            Controls.Add(tbBirthday_Output);
            Controls.Add(tbBirthplace_Output);
            Controls.Add(tbGender_Output);
            Controls.Add(tbFullName_Output);
            Controls.Add(label10);
            Controls.Add(btnOK);
            Controls.Add(dtpBirthday);
            Controls.Add(label9);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(cmbBirthplace);
            Controls.Add(tbFullName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            Text = "Admin Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbFullName;
        private ComboBox cmbBirthplace;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label9;
        private DateTimePicker dtpBirthday;
        private Button btnOK;
        private Label label10;
        private TextBox tbFullName_Output;
        private TextBox tbGender_Output;
        private TextBox tbBirthplace_Output;
        private TextBox tbBirthday_Output;
        private Label label11;
        private CheckBox cbGraduated;
        private Label label12;
        private TextBox tbGraduated_Output;
        private Button btnLogout;
    }
}
