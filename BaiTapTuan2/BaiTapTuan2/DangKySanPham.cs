using System;
using System.Windows.Forms;

namespace BaiTapTuan2
{
    public partial class DangKySanPham : Form
    {
        public DangKySanPham()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA DỮ LIỆU ĐẦU VÀO (VALIDATION)
            if (string.IsNullOrWhiteSpace(this.txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenSanPham.Focus();
                return;
            }

            if (this.cmbLoaiSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbLoaiSanPham.Focus();
                return;
            }

            // 2. THÊM DỮ LIỆU VÀO BẢNG
            this.dgvDanhSachSanPham.Rows.Add(this.txtTenSanPham.Text, this.cmbLoaiSanPham.Text, this.numSoLuong.Value);

            // 3. TỰ ĐỘNG LÀM MỚI ĐỂ CHUẨN BỊ CHO LẦN NHẬP TIẾP THEO
            ClearInputs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSachSanPham.SelectedRows.Count > 0)
            {
                // HIỂN THỊ HỘP THOẠI XÁC NHẬN TRƯỚC KHI XÓA
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.dgvDanhSachSanPham.Rows.RemoveAt(this.dgvDanhSachSanPham.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // HÀM DÙNG CHUNG ĐỂ LÀM MỚI CÁC Ô NHẬP LIỆU
        private void ClearInputs()
        {
            this.txtTenSanPham.Clear();
            this.cmbLoaiSanPham.SelectedIndex = -1;
            this.cmbLoaiSanPham.Text = "Chọn loại sản phẩm";
            this.numSoLuong.Value = 0;
            this.txtTenSanPham.Focus();
        }
    }
}