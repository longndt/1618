namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            lblResult = new Label();
            btnAdd = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Input X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(29, 103);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 1;
            label2.Text = "Input Y";
            // 
            // numX
            // 
            numX.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numX.Location = new Point(181, 32);
            numX.Name = "numX";
            numX.Size = new Size(95, 45);
            numX.TabIndex = 2;
            // 
            // numY
            // 
            numY.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numY.Location = new Point(181, 103);
            numY.Name = "numY";
            numY.Size = new Size(95, 45);
            numY.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(0, 0, 192);
            lblResult.Location = new Point(554, 97);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(135, 49);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Purple;
            btnAdd.Location = new Point(300, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 45);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = Color.Purple;
            btnMultiply.Location = new Point(300, 103);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(97, 45);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = Color.Purple;
            btnSubtract.Location = new Point(425, 32);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(95, 45);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Lucida Sans", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = Color.Purple;
            btnDivide.Location = new Point(425, 101);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(95, 45);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Fuchsia;
            btnClear.FlatStyle = FlatStyle.System;
            btnClear.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(128, 64, 0);
            btnClear.Location = new Point(554, 32);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 45);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 189);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnAdd);
            Controls.Add(lblResult);
            Controls.Add(numY);
            Controls.Add(numX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private Label lblResult;
        private Button btnAdd;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnClear;
    }
}
