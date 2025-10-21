using System;
using System.Windows.Forms;

namespace BaiTapTuan2
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
            // Gán sự kiện SelectionChanged cho DataGridView ngay khi khởi tạo
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear(); // Xóa lỗi cũ
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                errorProvider1.SetError(txtTenSanPham, "Tên sản phẩm không được để trống");
                isValid = false;
            }

            if (numSoLuong.Value <= 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng phải lớn hơn 0");
                isValid = false;
            }

            return isValid;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string tinhTrang = rdoConHang.Checked ? "Còn hàng" : "Hết hàng";
                dgvSanPham.Rows.Add(txtTenSanPham.Text, cmbLoaiSanPham.Text, numSoLuong.Value, tinhTrang);

                UpdateStatusStrip();
                ClearInputs();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (ValidateInputs())
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin sản phẩm này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var row = dgvSanPham.SelectedRows[0];
                        row.Cells["colTen"].Value = txtTenSanPham.Text;
                        row.Cells["colLoai"].Value = cmbLoaiSanPham.Text;
                        row.Cells["colSoLuong"].Value = numSoLuong.Value;
                        row.Cells["colTinhTrang"].Value = rdoConHang.Checked ? "Còn hàng" : "Hết hàng";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dgvSanPham.Rows.RemoveAt(dgvSanPham.SelectedRows[0].Index);
                    UpdateStatusStrip();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            // Khi chọn một dòng, hiển thị thông tin lên các control
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSanPham.SelectedRows[0];
                txtTenSanPham.Text = selectedRow.Cells["colTen"].Value?.ToString();
                cmbLoaiSanPham.Text = selectedRow.Cells["colLoai"].Value?.ToString();

                // Chuyển đổi giá trị số lượng một cách an toàn
                if (decimal.TryParse(selectedRow.Cells["colSoLuong"].Value?.ToString(), out decimal soLuong))
                {
                    numSoLuong.Value = soLuong;
                }

                // Cập nhật RadioButton dựa trên tình trạng
                string tinhTrang = selectedRow.Cells["colTinhTrang"].Value?.ToString();
                if (tinhTrang == "Còn hàng")
                {
                    rdoConHang.Checked = true;
                }
                else
                {
                    rdoHetHang.Checked = true;
                }
            }
        }

        private void ClearInputs()
        {
            txtTenSanPham.Clear();
            cmbLoaiSanPham.SelectedIndex = -1;
            cmbLoaiSanPham.Text = "Chọn loại sản phẩm";
            numSoLuong.Value = 1;
            rdoConHang.Checked = true;
            errorProvider1.Clear();
            txtTenSanPham.Focus();
        }

        private void UpdateStatusStrip()
        {
            // Trừ 1 nếu có dòng "new row" ở cuối
            int count = dgvSanPham.AllowUserToAddRows ? dgvSanPham.Rows.Count - 1 : dgvSanPham.Rows.Count;
            lblTongSanPham.Text = $"Tổng số sản phẩm: {count}";
        }
    }
}