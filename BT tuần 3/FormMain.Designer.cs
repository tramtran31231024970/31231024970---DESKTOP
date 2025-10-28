namespace BT_tuần_3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;

        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem liênHệToolStripMenuItem;

        private ToolStrip toolStripMain;
        private ToolStripButton toolStripButtonEmployees;
        private ToolStripButton toolStripButtonProducts;
        private ToolStripButton toolStripButtonInvoices;
        private ToolStripTextBox toolStripTextBoxSearch;

        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelUser;
        private ToolStripStatusLabel toolStripStatusLabelForm;
        private ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerClock;
        private NotifyIcon notifyIcon;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new MenuStrip();
            this.hệThốngToolStripMenuItem = new ToolStripMenuItem();
            this.loginToolStripMenuItem = new ToolStripMenuItem();
            this.logoutToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();

            this.quảnLýToolStripMenuItem = new ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new ToolStripMenuItem();

            this.trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new ToolStripMenuItem();

            // ToolStrip
            /*this.toolStripMain = new ToolStrip();
            this.toolStripButtonEmployees = new ToolStripButton();
            this.toolStripButtonProducts = new ToolStripButton();
            this.toolStripButtonInvoices = new ToolStripButton();
            this.toolStripTextBoxSearch = new ToolStripTextBox();*/

            // StatusStrip
            this.statusStripMain = new StatusStrip();
            this.toolStripStatusLabelUser = new ToolStripStatusLabel();
            this.toolStripStatusLabelForm = new ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(components);
            this.notifyIcon = new NotifyIcon(components);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";

            this.loginToolStripMenuItem.Text = "Đăng nhập";
            this.loginToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            this.loginToolStripMenuItem.Click += new EventHandler(this.loginToolStripMenuItem_Click);

            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.logoutToolStripMenuItem.Click += new EventHandler(this.logoutToolStripMenuItem_Click);

            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);

            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.loginToolStripMenuItem,
                this.logoutToolStripMenuItem,
                new ToolStripSeparator(),
                this.exitToolStripMenuItem
            });

            // ---------- Quản lý ----------
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";

            this.nhânViênToolStripMenuItem.Click += new EventHandler(this.nhânViênToolStripMenuItem_Click);
            this.sảnPhẩmToolStripMenuItem.Click += new EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            this.hóaĐơnToolStripMenuItem.Click += new EventHandler(this.hóaĐơnToolStripMenuItem_Click);

            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.nhânViênToolStripMenuItem,
                this.sảnPhẩmToolStripMenuItem,
                this.hóaĐơnToolStripMenuItem
            });

            // ---------- Trợ giúp ----------
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            this.giớiThiệuToolStripMenuItem.Click += new EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            this.liênHệToolStripMenuItem.Click += new EventHandler(this.liênHệToolStripMenuItem_Click);
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.giớiThiệuToolStripMenuItem, this.liênHệToolStripMenuItem });

            // Add top-level menus
            this.menuStripMain.Items.AddRange(new ToolStripItem[] { this.hệThốngToolStripMenuItem, this.quảnLýToolStripMenuItem, this.trợGiúpToolStripMenuItem });
            this.MainMenuStrip = this.menuStripMain;

            // ---------- ToolStrip ----------
          

            // ---------- StatusStrip ----------
            this.statusStripMain.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabelUser, this.toolStripStatusLabelForm, this.toolStripStatusLabelTime });

            // ---------- Timer ----------
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new EventHandler(this.timerClock_Tick);

            // ---------- NotifyIcon ----------
            this.notifyIcon.Text = "MiniStoreManager";
            this.notifyIcon.Icon = SystemIcons.Application;
            this.notifyIcon.DoubleClick += new EventHandler(this.notifyIcon_DoubleClick);

            // ---------- Form settings ----------
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStripMain);

            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.menuStripMain.Dock = DockStyle.Top;
            //this.toolStripMain.Dock = DockStyle.Top;
            //this.toolStripMain.Location = new Point(0, this.menuStripMain.Height);

            this.Text = "Mini Store Manager";
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(this.FormMain_Resize);
        }

        #endregion
    }
}