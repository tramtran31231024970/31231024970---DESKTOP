using System;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Kích hoạt các event handler
            this.Load += ExerciseForm_Load;
            this.showButton.Click += ShowButton_Click;
            this.exitButton.Click += ExitButton_Click;
            this.MouseClick += ExerciseForm_MouseClick;

            // Cho phép Form nhận sự kiện phím bấm trước các control
            this.KeyPreview = true;
            this.KeyDown += ExerciseForm_KeyDown;
        }

        // 1. Xử lý sự kiện FormLoad
        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn mở ứng dụng hay không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }

        // 2. Xử lý sự kiện nhấn nút "Hiển thị"
        private void ShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.mainTextBox.Text, "Nội dung đã nhập");
        }

        // 3. Xử lý sự kiện nhấn tổ hợp phím ALT + H
        private void ExerciseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                this.mainTextBox.Text = "Xin chào Khoa CNTTKD";
            }
        }
        // 4. Xử lý sự kiện click chuột
        private void ExerciseForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa nhấp chuột trái!");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa nhấp chuột phải!");
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn vừa nhấp chuột giữa!");
            }
        }

        // 5. Xử lý sự kiện nhấn nút "Thoát"
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn thoát hay không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
