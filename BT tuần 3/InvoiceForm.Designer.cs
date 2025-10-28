using System.Drawing.Printing;

namespace BT_tuần_3
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblBrandTitle;
        private Label lblCustomer;
        private TextBox txtCustomer;
        private DataGridView dgvInvoice;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnSave;
        private Button btnPrint;
        private Label lblTotal;
        private Label lblTotalValue;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument;
        private PrintDocument printDocument1;
        private SaveFileDialog saveFileDialog1;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            lblBrandTitle = new Label();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            dgvInvoice = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            lblTotalValue = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument = new PrintDocument();
            saveFileDialog1 = new SaveFileDialog();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.Green;
            lblBrandTitle.Location = new Point(301, 102);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(662, 67);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "QUẢN LÝ CỬA HÀNG MINI";
            lblBrandTitle.Click += lblBrandTitle_Click;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(453, 11);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(181, 31);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Tên khách hàng:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(640, 15);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(360, 27);
            txtCustomer.TabIndex = 3;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // dgvInvoice
            // 
            dgvInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoice.ColumnHeadersHeight = 29;
            dgvInvoice.Location = new Point(49, 215);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.Size = new Size(921, 239);
            dgvInvoice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 468);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 38);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm sản phẩm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(215, 468);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(124, 37);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Xóa sản phẩm";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(362, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu hóa đơn";
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(498, 468);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 37);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "In biên lai";
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(640, 478);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Tổng tiền:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalValue.Location = new Point(727, 475);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(62, 23);
            lblTotalValue.TabIndex = 10;
            lblTotalValue.Text = "0 VNĐ";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument2_PrintPage;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(49, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(246, 204);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // InvoiceForm
            // 
            ClientSize = new Size(1012, 518);
            Controls.Add(picLogo);
            Controls.Add(lblBrandTitle);
            Controls.Add(lblCustomer);
            Controls.Add(txtCustomer);
            Controls.Add(dgvInvoice);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(btnPrint);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalValue);
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox picLogo;
    }
}