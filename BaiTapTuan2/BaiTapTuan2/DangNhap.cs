using BaiTapTuan2;
using System;
using System.Windows.Forms;

namespace BaiTapTuan2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Xóa các thông báo lỗi cũ trước khi kiểm tra lại
            errorProvider1.Clear();

            // --- 1. KIỂM TRA DỮ LIỆU ĐẦU VÀO (VALIDATION) ---
            bool hasError = false; // Dùng biến cờ để theo dõi lỗi

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập Username!");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập Password!");
                hasError = true;
            }

            // Nếu có lỗi (ô trống), dừng hàm tại đây
            if (hasError)
            {
                return;
            }

            // --- 2. KIỂM TRA TÀI KHOẢN VÀ MẬT KHẨU ---
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form đăng ký sản phẩm (bài 3)
                // Giả sử tên Form đó là DangKySanPham
                DangKySanPham frm = new DangKySanPham();
                frm.Show();

                // Ẩn form đăng nhập hiện tại
                this.Hide();

                // Thêm sự kiện: Khi form đăng ký đóng, form đăng nhập sẽ hiện lại
                frm.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa ô mật khẩu và focus lại để người dùng nhập lại
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}