namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblA1 = new Label();
            lblD = new Label();
            lblN = new Label();
            txtA1 = new TextBox();
            txtD = new TextBox();
            txtN = new TextBox();
            lblAn = new Label();
            lblSn = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblA1
            // 
            lblA1.AutoSize = true;
            lblA1.Location = new Point(70, 31);
            lblA1.Name = "lblA1";
            lblA1.Size = new Size(68, 15);
            lblA1.TabIndex = 0;
            lblA1.Text = "Введите a1:";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(70, 61);
            lblD.Name = "lblD";
            lblD.Size = new Size(63, 15);
            lblD.TabIndex = 2;
            lblD.Text = "Введите d:";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(70, 91);
            lblN.Name = "lblN";
            lblN.Size = new Size(63, 15);
            lblN.TabIndex = 4;
            lblN.Text = "Введите n:";
            // 
            // txtA1
            // 
            txtA1.Location = new Point(180, 28);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(140, 23);
            txtA1.TabIndex = 1;
            // 
            // txtD
            // 
            txtD.Location = new Point(180, 58);
            txtD.Name = "txtD";
            txtD.Size = new Size(140, 23);
            txtD.TabIndex = 3;
            // 
            // txtN
            // 
            txtN.Location = new Point(180, 88);
            txtN.Name = "txtN";
            txtN.Size = new Size(140, 23);
            txtN.TabIndex = 5;
            // 
            // lblAn
            // 
            lblAn.AutoSize = true;
            lblAn.Location = new Point(70, 122);
            lblAn.Name = "lblAn";
            lblAn.Size = new Size(59, 15);
            lblAn.TabIndex = 6;
            lblAn.Text = "n-й член:";
            // 
            // lblSn
            // 
            lblSn.AutoSize = true;
            lblSn.Location = new Point(70, 147);
            lblSn.Name = "lblSn";
            lblSn.Size = new Size(101, 15);
            lblSn.TabIndex = 7;
            lblSn.Text = "Сумма n членов:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(180, 193);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 25);
            btnExit.TabIndex = 8;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 274);
            Controls.Add(lblA1);
            Controls.Add(txtA1);
            Controls.Add(lblD);
            Controls.Add(txtD);
            Controls.Add(lblN);
            Controls.Add(txtN);
            Controls.Add(lblAn);
            Controls.Add(lblSn);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Арифметическая прогрессия (Задание 2)";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}