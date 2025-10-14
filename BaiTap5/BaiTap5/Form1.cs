using System;
using System.Windows.Forms;

namespace BaiTap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện cho các control
            buttonCalculate.Click += buttonCalculate_Click;
            buttonClear.Click += buttonClear_Click;
            buttonExit.Click += buttonExit_Click;

            // Chỉ cho phép nhập số vào 2 TextBox
            textNumberA.KeyPress += NumberInput_KeyPress;
            textNumberB.KeyPress += NumberInput_KeyPress;
        }

        private void NumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số (IsDigit) hoặc các phím điều khiển (IsControl) như Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy giá trị từ TextBox
            if (!int.TryParse(textNumberA.Text, out int a) || !int.TryParse(textNumberB.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện tính toán dựa trên lựa chọn của RadioButton
            if (radioGCD.Checked)
            {
                textResult.Text = CalculateGCD(a, b).ToString();
            }
            else if (radioLCM.Checked)
            {
                // Cải tiến: Xử lý trường hợp đặc biệt khi cả hai số là 0
                if (a == 0 && b == 0)
                {
                    textResult.Text = "0";
                }
                else
                {
                    textResult.Text = CalculateLCM(a, b).ToString();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textNumberA.Clear();
            textNumberB.Clear();
            textResult.Clear();
            radioGCD.Checked = true; // Reset lựa chọn về mặc định
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // --- CÁC HÀM TÍNH TOÁN ---

        // Hàm tính Ước số chung lớn nhất (sử dụng thuật toán Euclid)
        private int CalculateGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tính Bội số chung nhỏ nhất (dựa trên USCLN)
        private long CalculateLCM(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            // Dùng long để tránh tràn số khi a*b quá lớn
            return Math.Abs((long)a * b) / CalculateGCD(a, b);
        }
    }
}
