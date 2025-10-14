using System;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện cho các nút
            btnCong.Click += ThucHienPhepTinh_Click;
            btnTru.Click += ThucHienPhepTinh_Click;
            btnNhan.Click += ThucHienPhepTinh_Click;
            btnChia.Click += ThucHienPhepTinh_Click;
            btnXoa.Click += btnXoa_Click;

            // Gán sự kiện kiểm tra nhập liệu cho cả 2 TextBox
            txtSoThuNhat.KeyPress += KiemTraSo_KeyPress;
            txtSoThuHai.KeyPress += KiemTraSo_KeyPress;
        }

        // Yêu cầu 1: Chỉ cho phép nhập số và xóa lùi
        private void KiemTraSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số hoặc phím điều khiển
            }
        }

        // Yêu cầu 2: Xử lý các phép toán
        private void ThucHienPhepTinh_Click(object sender, EventArgs e)
        {
            if (LayGiaTriSo(out double so1, out double so2))
            {
                Button nutPhepTinh = sender as Button;
                double ketQua = 0;

                switch (nutPhepTinh.Name)
                {
                    case "btnCong":
                        ketQua = so1 + so2;
                        break;
                    case "btnTru":
                        ketQua = so1 - so2;
                        break;
                    case "btnNhan":
                        ketQua = so1 * so2;
                        break;
                    case "btnChia":
                        if (so2 == 0)
                        {
                            MessageBox.Show("Lỗi: Không thể chia cho 0!", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ketQua = so1 / so2;
                        break;
                }
                txtKetQua.Text = ketQua.ToString();
            }
        }

        // Yêu cầu 3: Xử lý nút Del
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtKetQua.Clear();
        }

        // Hàm hỗ trợ kiểm tra và lấy giá trị từ TextBox
        private bool LayGiaTriSo(out double so1, out double so2)
        {
            bool laSo1HopLe = double.TryParse(txtSoThuNhat.Text, out so1);
            bool laSo2HopLe = double.TryParse(txtSoThuHai.Text, out so2);

            if (!laSo1HopLe || !laSo2HopLe)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
