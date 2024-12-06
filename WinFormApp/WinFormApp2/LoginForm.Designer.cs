namespace WinFormApp3
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(237, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(195, 161);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(223, 39);
            tbPassword.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(195, 75);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(223, 39);
            tbUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(22, 161);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 369);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
    }
}