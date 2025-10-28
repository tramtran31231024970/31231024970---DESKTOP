namespace BT_tuần_3
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lbl1, lbl2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(118, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(118, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(90, 92);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 27);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(110, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Tên đăng nhập:";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(39, 62);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(73, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "Mật khẩu:";
            lbl2.Click += lbl2_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(300, 140);
            Controls.Add(lbl1);
            Controls.Add(txtUsername);
            Controls.Add(lbl2);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
