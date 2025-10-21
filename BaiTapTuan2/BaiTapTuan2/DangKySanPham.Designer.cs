using System.Drawing;
using System.Windows.Forms;

namespace BaiTapTuan2
{
    partial class DangKySanPham
    {
        private System.ComponentModel.IContainer components = null;

        // KHAI BÁO CÁC CONTROL VỚI TÊN GỌI RÕ RÀNG
        private TextBox txtTenSanPham;
        private ComboBox cmbLoaiSanPham;
        private NumericUpDown numSoLuong;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvDanhSachSanPham;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colLoaiSanPham;
        private DataGridViewTextBoxColumn colSoLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTenSanPham = new TextBox();
            cmbLoaiSanPham = new ComboBox();
            numSoLuong = new NumericUpDown();
            btnLuu = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvDanhSachSanPham = new DataGridView();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colLoaiSanPham = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(30, 20);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PlaceholderText = "Nhập tên sản phẩm...";
            txtTenSanPham.Size = new Size(255, 27);
            txtTenSanPham.TabIndex = 0;
            // 
            // cmbLoaiSanPham
            // 
            cmbLoaiSanPham.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            cmbLoaiSanPham.Location = new Point(30, 60);
            cmbLoaiSanPham.Name = "cmbLoaiSanPham";
            cmbLoaiSanPham.Size = new Size(255, 28);
            cmbLoaiSanPham.TabIndex = 1;
            cmbLoaiSanPham.Text = "Chọn loại sản phẩm";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(30, 100);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(255, 27);
            numSoLuong.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(30, 140);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(120, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(210, 140);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 34);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Columns.AddRange(new DataGridViewColumn[] { colTenSanPham, colLoaiSanPham, colSoLuong });
            dgvDanhSachSanPham.Location = new Point(344, 20);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.Size = new Size(424, 191);
            dgvDanhSachSanPham.TabIndex = 6;
            // 
            // colTenSanPham
            // 
            colTenSanPham.HeaderText = "Tên sản phẩm";
            colTenSanPham.MinimumWidth = 6;
            colTenSanPham.Name = "colTenSanPham";
            colTenSanPham.Width = 150;
            // 
            // colLoaiSanPham
            // 
            colLoaiSanPham.HeaderText = "Loại sản phẩm";
            colLoaiSanPham.MinimumWidth = 6;
            colLoaiSanPham.Name = "colLoaiSanPham";
            colLoaiSanPham.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 125;
            // 
            // DangKySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 260);
            Controls.Add(dgvDanhSachSanPham);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(numSoLuong);
            Controls.Add(cmbLoaiSanPham);
            Controls.Add(txtTenSanPham);
            Name = "DangKySanPham";
            Text = "Đăng Ký Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}