using System.Windows.Forms;
using System.Drawing;

namespace BaiTapTuan2
{
    partial class QuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox picLogo;
        private TextBox txtTenSanPham;
        private ComboBox cmbLoaiSanPham;
        private NumericUpDown numSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox grpTinhTrang;
        private RadioButton rdoConHang;
        private RadioButton rdoHetHang;
        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTinhTrang;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTongSanPham;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySanPham));
            panelLeft = new Panel();
            picLogo = new PictureBox();
            txtTenSanPham = new TextBox();
            cmbLoaiSanPham = new ComboBox();
            numSoLuong = new NumericUpDown();
            grpTinhTrang = new GroupBox();
            rdoHetHang = new RadioButton();
            rdoConHang = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panelRight = new Panel();
            dgvSanPham = new DataGridView();
            colTen = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            lblTongSanPham = new ToolStripStatusLabel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            grpTinhTrang.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(240, 248, 255);
            panelLeft.Controls.Add(picLogo);
            panelLeft.Controls.Add(txtTenSanPham);
            panelLeft.Controls.Add(cmbLoaiSanPham);
            panelLeft.Controls.Add(numSoLuong);
            panelLeft.Controls.Add(grpTinhTrang);
            panelLeft.Controls.Add(btnThem);
            panelLeft.Controls.Add(btnSua);
            panelLeft.Controls.Add(btnXoa);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 420);
            panelLeft.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(276, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenSanPham.Location = new Point(12, 175);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(276, 27);
            txtTenSanPham.TabIndex = 0;
            toolTip1.SetToolTip(txtTenSanPham, "Nhập tên sản phẩm");
            // 
            // cmbLoaiSanPham
            // 
            cmbLoaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbLoaiSanPham.FormattingEnabled = true;
            cmbLoaiSanPham.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt", "Bánh mì" });
            cmbLoaiSanPham.Location = new Point(12, 208);
            cmbLoaiSanPham.Name = "cmbLoaiSanPham";
            cmbLoaiSanPham.Size = new Size(276, 28);
            cmbLoaiSanPham.TabIndex = 1;
            toolTip1.SetToolTip(cmbLoaiSanPham, "Chọn loại sản phẩm");
            // 
            // numSoLuong
            // 
            numSoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numSoLuong.Location = new Point(12, 242);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(276, 27);
            numSoLuong.TabIndex = 2;
            toolTip1.SetToolTip(numSoLuong, "Nhập số lượng > 0");
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpTinhTrang
            // 
            grpTinhTrang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTinhTrang.Controls.Add(rdoHetHang);
            grpTinhTrang.Controls.Add(rdoConHang);
            grpTinhTrang.Location = new Point(12, 275);
            grpTinhTrang.Name = "grpTinhTrang";
            grpTinhTrang.Size = new Size(276, 60);
            grpTinhTrang.TabIndex = 3;
            grpTinhTrang.TabStop = false;
            grpTinhTrang.Text = "Tình trạng";
            // 
            // rdoHetHang
            // 
            rdoHetHang.AutoSize = true;
            rdoHetHang.Location = new Point(140, 26);
            rdoHetHang.Name = "rdoHetHang";
            rdoHetHang.Size = new Size(91, 24);
            rdoHetHang.TabIndex = 1;
            rdoHetHang.Text = "Hết hàng";
            rdoHetHang.UseVisualStyleBackColor = true;
            // 
            // rdoConHang
            // 
            rdoConHang.AutoSize = true;
            rdoConHang.Checked = true;
            rdoConHang.Location = new Point(15, 26);
            rdoConHang.Name = "rdoConHang";
            rdoConHang.Size = new Size(93, 24);
            rdoConHang.TabIndex = 0;
            rdoConHang.TabStop = true;
            rdoConHang.Text = "Còn hàng";
            rdoConHang.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.Location = new Point(12, 378);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSua.Location = new Point(110, 378);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Location = new Point(208, 378);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(dgvSanPham);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(300, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(799, 420);
            panelRight.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colTen, colLoai, colSoLuong, colTinhTrang });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(799, 420);
            dgvSanPham.TabIndex = 0;
            // 
            // colTen
            // 
            colTen.HeaderText = "Tên sản phẩm";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            // 
            // colLoai
            // 
            colLoai.HeaderText = "Loại";
            colLoai.MinimumWidth = 6;
            colLoai.Name = "colLoai";
            colLoai.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.MinimumWidth = 6;
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTongSanPham });
            statusStrip1.Location = new Point(0, 420);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1099, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSanPham
            // 
            lblTongSanPham.Name = "lblTongSanPham";
            lblTongSanPham.Size = new Size(145, 20);
            lblTongSanPham.Text = "Tổng số sản phẩm: 0";
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 446);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(800, 400);
            Name = "QuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm cửa hàng Việt Nam";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            grpTinhTrang.ResumeLayout(false);
            grpTinhTrang.PerformLayout();
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}