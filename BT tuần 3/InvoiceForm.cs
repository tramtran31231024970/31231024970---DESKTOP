using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tuần_3
{
    public partial class InvoiceForm : Form
    {
        private PrintDocument printDocument2;
        private List<Product> invoiceProducts = new List<Product>();
        private string customerName = "Khách hàng lẻ";
        private DataTable dtInvoice;
        private decimal currentTotal = 0m;
        private string logoPath = "logo.png"; // đặt logo.png cạnh file exe hoặc cho path tuyệt đối
        private Color brandColor = Color.FromArgb(0, 120, 70); // màu thương hiệu (xanh lá)

        public InvoiceForm(string username = "Guest")
        {
            InitializeComponent();
            InitializeInvoiceTable();
            lblBrandTitle.ForeColor = brandColor;
            this.BackColor = Color.WhiteSmoke;

          
            try
            {
                if (File.Exists(logoPath))
                {
                    picLogo.Image = Image.FromFile(logoPath);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
               
                    picLogo.BackColor = brandColor;
                }
            }
            catch
            {
                picLogo.BackColor = brandColor;
            }

            UpdateTotalLabel();
        }

        private void InitializeInvoiceTable()
        {
            dtInvoice = new DataTable();
            dtInvoice.Columns.Add("Code", typeof(string));
            dtInvoice.Columns.Add("Name", typeof(string));
            dtInvoice.Columns.Add("Qty", typeof(int));
            dtInvoice.Columns.Add("Price", typeof(decimal));
            dtInvoice.Columns.Add("Amount", typeof(decimal), "Qty * Price");

            printDocument2 = new PrintDocument();
            printDocument2.PrintPage += printDocument2_PrintPage;

            dgvInvoice.DataSource = dtInvoice;

            // ----- BẮT ĐẦU PHẦN CĂN CHỈNH -----

            // 1. Cấu hình HeaderText
            dgvInvoice.Columns["Code"].HeaderText = "Mã";
            dgvInvoice.Columns["Name"].HeaderText = "Tên sản phẩm";
            dgvInvoice.Columns["Qty"].HeaderText = "Số lượng";
            dgvInvoice.Columns["Price"].HeaderText = "Đơn giá";
            dgvInvoice.Columns["Amount"].HeaderText = "Thành tiền";

            // 2. Cấu hình Độ rộng
            dgvInvoice.Columns["Code"].Width = 80;
            dgvInvoice.Columns["Qty"].Width = 70;
            dgvInvoice.Columns["Price"].Width = 100;
            dgvInvoice.Columns["Amount"].Width = 120;
            // Cho cột "Name" tự dãn ra lấp đầy khoảng trống
            dgvInvoice.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 3. Cấu hình Căn lề
            // Căn giữa cho cột Mã
            dgvInvoice.Columns["Code"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn phải cho các cột SỐ
            dgvInvoice.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoice.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoice.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Căn giữa cho TẤT CẢ tiêu đề cột (Header)
            dgvInvoice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 4. Cấu hình Format (như cũ)
            dgvInvoice.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvInvoice.Columns["Amount"].DefaultCellStyle.Format = "N0";

            // ----- KẾT THÚC PHẦN CĂN CHỈNH -----

            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.MultiSelect = false;

            // Thêm dòng này để các cột không bị tự động thay đổi
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddItemDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // thêm vào bảng
                    dtInvoice.Rows.Add(dlg.ProductCode, dlg.ProductName, dlg.Quantity, dlg.Price);
                    UpdateTotalLabel();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow == null) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            dgvInvoice.Rows.RemoveAt(dgvInvoice.CurrentRow.Index);
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            currentTotal = 0m;
            foreach (DataRow r in dtInvoice.Rows)
            {
                currentTotal += Convert.ToDecimal(r["Amount"]);
            }
            lblTotalValue.Text = currentTotal.ToString("N0") + " VNĐ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtInvoice.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong hóa đơn.", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files|*.csv";
                sfd.FileName = $"HoaDon_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine($"Tên khách hàng,{txtCustomer.Text}");
                    sb.AppendLine($"Ngày,{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sb.AppendLine();

                    // header
                    sb.AppendLine("Mã,Tên,Số lượng,Đơn giá,Thành tiền");
                    foreach (DataRow r in dtInvoice.Rows)
                    {
                        sb.AppendLine($"{r["Code"]},{EscapeCsv(r["Name"].ToString())},{r["Qty"]},{r["Price"]},{r["Amount"]}");
                    }
                    sb.AppendLine($",,,Tổng,{currentTotal}");
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Đã lưu hóa đơn.", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string EscapeCsv(string input)
        {
            if (input.Contains(",") || input.Contains("\"") || input.Contains("\n"))
            {
                return $"\"{input.Replace("\"", "\"\"")}\"";
            }
            return input;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtInvoice.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để in.", "In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = printDocument2;
                dlg.Width = 800; dlg.Height = 600;
                dlg.ShowDialog();
            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int left = 40;
            int y = 20;

            // Logo
            if (picLogo.Image != null)
            {
                try
                {
                    g.DrawImage(picLogo.Image, new Rectangle(left, y, 80, 80));
                }
                catch { /* ignore drawing logo errors */ }
            }
            // Brand title
            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(brandColor))
            {
                g.DrawString("QUẢN LÝ CỬA HÀNG MINI", titleFont, brush, left + 100, y + 10);
            }

            y += 100;

            using (Font f = new Font("Arial", 10))
            {
                g.DrawString($"Tên khách hàng: {txtCustomer.Text}", f, Brushes.Black, left, y);
                y += 20;
                g.DrawString($"Ngày: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", f, Brushes.Black, left, y);
                y += 25;

                // header line
                using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
                {
                    g.DrawString("STT", headerFont, Brushes.Black, left, y);
                    g.DrawString("Tên sản phẩm", headerFont, Brushes.Black, left + 40, y);
                    g.DrawString("SL", headerFont, Brushes.Black, left + 300, y);
                    g.DrawString("Đơn giá", headerFont, Brushes.Black, left + 350, y);
                    g.DrawString("Thành tiền", headerFont, Brushes.Black, left + 430, y);
                }
                y += 18;
                g.DrawLine(Pens.Black, left, y, left + 520, y);
                y += 6;

                int stt = 1;
                foreach (DataRow r in dtInvoice.Rows)
                {
                    if (y > e.MarginBounds.Bottom - 50) // new page if not enough space
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    string name = r["Name"].ToString();
                    int qty = Convert.ToInt32(r["Qty"]);
                    decimal price = Convert.ToDecimal(r["Price"]);
                    decimal amount = Convert.ToDecimal(r["Amount"]);

                    g.DrawString(stt.ToString(), f, Brushes.Black, left, y);
                    g.DrawString(name, f, Brushes.Black, left + 40, y);
                    g.DrawString(qty.ToString(), f, Brushes.Black, left + 300, y);
                    g.DrawString(price.ToString("N0"), f, Brushes.Black, left + 350, y);
                    g.DrawString(amount.ToString("N0"), f, Brushes.Black, left + 430, y);
                    y += 20;
                    stt++;
                }

                y += 10;
                g.DrawLine(Pens.Black, left, y, left + 520, y);
                y += 10;
                using (Font totalFont = new Font("Arial", 11, FontStyle.Bold))
                {
                    g.DrawString("TỔNG: " + currentTotal.ToString("N0") + " VNĐ", totalFont, Brushes.Red, left + 300, y);
                }
            }

            e.HasMorePages = false;
        }

        // ---------- small dialog class để nhập sản phẩm ----------
        private class AddItemDialog : Form
        {
            public string ProductCode { get; private set; }
            public string ProductName { get; private set; }
            public int Quantity { get; private set; }
            public decimal Price { get; private set; }

            private TextBox txtCode, txtName, txtQty, txtPrice;
            private Button btnOk, btnCancel;

            public AddItemDialog()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.Text = "Thêm sản phẩm";
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.ClientSize = new Size(360, 200);
                this.StartPosition = FormStartPosition.CenterParent;

                Label lb1 = new Label() { Text = "Mã:", Left = 10, Top = 20, AutoSize = true };
                txtCode = new TextBox() { Left = 100, Top = 18, Width = 240 };

                Label lb2 = new Label() { Text = "Tên:", Left = 10, Top = 55, AutoSize = true };
                txtName = new TextBox() { Left = 100, Top = 52, Width = 240 };

                Label lb3 = new Label() { Text = "Số lượng:", Left = 10, Top = 90, AutoSize = true };
                txtQty = new TextBox() { Left = 100, Top = 88, Width = 100, Text = "1" };

                Label lb4 = new Label() { Text = "Đơn giá:", Left = 210, Top = 90, AutoSize = true };
                txtPrice = new TextBox() { Left = 270, Top = 88, Width = 70, Text = "0" };

                btnOk = new Button() { Text = "OK", Left = 100, Top = 140, Width = 80 };
                btnCancel = new Button() { Text = "Hủy", Left = 200, Top = 140, Width = 80 };
                btnOk.Click += BtnOk_Click;
                //btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
                this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;

                this.Controls.AddRange(new Control[] { lb1, txtCode, lb2, txtName, lb3, txtQty, lb4, txtPrice, btnOk, btnCancel });
            }

            private void BtnOk_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã và tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQty.Text.Trim(), out int q) || q <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal p) || p < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductCode = txtCode.Text.Trim();
                ProductName = txtName.Text.Trim();
                Quantity = q;
                Price = p;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void lblBrandTitle_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
