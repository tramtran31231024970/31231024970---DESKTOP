using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tuần_3
{
    public partial class FormMain : Form
    {
        private string currentUser = "Guest";

        public FormMain(string username = "Guest")
        {
            InitializeComponent();
            currentUser = string.IsNullOrWhiteSpace(username) ? "Guest" : username;
            UpdateStatus();
            timerClock.Start();
        }

        private void UpdateStatus()
        {
            toolStripStatusLabelUser.Text = $"User: {currentUser}";
            toolStripStatusLabelForm.Text = "Form: -";

            // bật/tắt menu tùy quyền
            bool isGuest = string.Equals(currentUser, "Guest", StringComparison.OrdinalIgnoreCase);
            logoutToolStripMenuItem.Enabled = !isGuest;
            // có thể disable toàn bộ Quản lý nếu Guest:
            quảnLýToolStripMenuItem.Enabled = !isGuest;
        }

        // -------------------- Menu event handlers --------------------
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new LoginForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // nếu LoginForm có property Username -> dùng dlg.Username
                    // ở đây ta dò theo property hoặc textbox
                    try
                    {
                        // nếu bạn đã implement Username property
                        var prop = dlg.GetType().GetProperty("Username");
                        if (prop != null)
                        {
                            var uname = prop.GetValue(dlg) as string;
                            currentUser = string.IsNullOrWhiteSpace(uname) ? "Guest" : uname;
                        }
                        else
                        {
                            // fallback: nếu bạn dùng txtUsername public (không khuyến nghị)
                            var field = dlg.GetType().GetField("txtUsername", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                            if (field != null)
                            {
                                var txt = field.GetValue(dlg) as TextBox;
                                if (txt != null) currentUser = string.IsNullOrWhiteSpace(txt.Text) ? "Guest" : txt.Text;
                            }
                        }
                    }
                    catch
                    {
                        currentUser = "Guest";
                    }

                    UpdateStatus();
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            // reset user
            currentUser = "Guest";
            UpdateStatus();

            // đóng tất cả MDI child để ngăn truy cập
            foreach (var child in this.MdiChildren.ToArray())
            {
                child.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) Application.Exit();
        }

        // -------------------- Các event khác (nếu bạn chưa có) --------------------
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiChild(typeof(EmployeeForm));
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiChild(typeof(ProductForm));
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiChild(typeof(InvoiceForm));
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Store Manager - Demo\nAuthor: You", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: support@example.com\nPhone: +84 xxxxx", "Liên hệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // helper mở form con MDI (dùng reflection để tạo instance có constructor (string username))
        private void OpenMdiChild(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    return;
                }
            }

            Form child = null;
            try
            {
                // ưu tiên constructor nhận username
                child = (Form)Activator.CreateInstance(formType, currentUser);
            }
            catch
            {
                // fallback default constructor
                child = (Form)Activator.CreateInstance(formType);
            }
            child.MdiParent = this;
            child.Show();
            toolStripStatusLabelForm.Text = "Form: " + child.Text;
        }

        // các event phụ (notify, timer...) giữ nguyên nếu đã có
        private void timerClock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(400);
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void toolStripButtonEmployees_Click(object sender, EventArgs e) => nhânViênToolStripMenuItem_Click(sender, e);
        private void toolStripButtonProducts_Click(object sender, EventArgs e) => sảnPhẩmToolStripMenuItem_Click(sender, e);
        private void toolStripButtonInvoices_Click(object sender, EventArgs e) => hóaĐơnToolStripMenuItem_Click(sender, e);

        private void toolStripTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var q = toolStripTextBoxSearch.Text.Trim();
            if (this.ActiveMdiChild is ProductForm pf) pf.SearchProduct(q);
        }
    }
}
