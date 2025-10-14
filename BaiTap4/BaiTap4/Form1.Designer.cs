namespace BaiTap4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Các control đã được Việt hóa tên
        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSoThuNhat = new Label();
            lblSoThuHai = new Label();
            lblKetQua = new Label();
            txtSoThuNhat = new TextBox();
            txtSoThuHai = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lblSoThuNhat
            // 
            lblSoThuNhat.AutoSize = true;
            lblSoThuNhat.Location = new Point(30, 33);
            lblSoThuNhat.Name = "lblSoThuNhat";
            lblSoThuNhat.Size = new Size(85, 20);
            lblSoThuNhat.TabIndex = 0;
            lblSoThuNhat.Text = "Số thứ nhất";
            // 
            // lblSoThuHai
            // 
            lblSoThuHai.AutoSize = true;
            lblSoThuHai.Location = new Point(30, 73);
            lblSoThuHai.Name = "lblSoThuHai";
            lblSoThuHai.Size = new Size(76, 20);
            lblSoThuHai.TabIndex = 1;
            lblSoThuHai.Text = "Số thứ hai";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(30, 163);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Kết quả";
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.Location = new Point(130, 30);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(220, 27);
            txtSoThuNhat.TabIndex = 0;
     
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.Location = new Point(130, 70);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(220, 27);
            txtSoThuHai.TabIndex = 1;
            // 
            // txtKetQua
            // 
            txtKetQua.Enabled = false;
            txtKetQua.Location = new Point(130, 160);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(220, 27);
            txtKetQua.TabIndex = 3;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(34, 115);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(45, 30);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(85, 115);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(45, 30);
            btnTru.TabIndex = 3;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(136, 115);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(45, 30);
            btnNhan.TabIndex = 4;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(187, 115);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(45, 30);
            btnChia.TabIndex = 5;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(250, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa (Del)";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(382, 213);
            Controls.Add(lblSoThuNhat);
            Controls.Add(lblSoThuHai);
            Controls.Add(lblKetQua);
            Controls.Add(txtSoThuNhat);
            Controls.Add(txtSoThuHai);
            Controls.Add(txtKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnXoa);
            Name = "Form1";
            Text = "Máy tính bỏ túi đơn giản";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
