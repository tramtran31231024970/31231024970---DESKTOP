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
    public partial class ProductForm : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private string currentUser;

        public ProductForm(string username)
        {
            currentUser = username;
            InitializeComponent();
            InitTree();
            PopulateSampleData();
        }

        private void InitTree()
        {
            treeViewCategories.Nodes.Clear();
            treeViewCategories.Nodes.Add("Thực phẩm");
            treeViewCategories.Nodes.Add("Đồ uống");
            treeViewCategories.Nodes.Add("Gia vị");
            treeViewCategories.Nodes.Add("Đồ gia dụng");
            treeViewCategories.AfterSelect += TreeViewCategories_AfterSelect;
        }

        private void PopulateSampleData()
        {
            products.Add(new Product("P01", "Gạo", 50000, 50, "Thực phẩm"));
            products.Add(new Product("P02", "Cà phê", 45000, 300, "Đồ uống"));
            products.Add(new Product("P03", "Đường mía", 30000, 200, "Gia vị"));
            products.Add(new Product("P04", "Bộ ấm chén", 3000000, 15, "Đồ gia dụng"));
            RefreshList();
        }

        private void TreeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshList(e.Node.Text);
        }

        private void RefreshList(string category = null)
        {
            listViewProducts.Items.Clear();
            var list = string.IsNullOrEmpty(category) ? products : products.Where(p => p.Category == category);
            foreach (var p in list)
            {
                var li = new ListViewItem(new string[] { p.Code, p.Name, p.Price.ToString("N0"), p.Stock.ToString() });
                li.Tag = p;
                listViewProducts.Items.Add(li);
            }
        }


        private void listViewProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewProducts.FocusedItem != null && listViewProducts.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var p = (Product)listViewProducts.SelectedItems[0].Tag;
                MessageBox.Show($"Mã: {p.Code}\nTên: {p.Name}\nGiá: {p.Price}\nTồn kho: {p.Stock}\nDanh mục: {p.Category}", "Chi tiết");
            }
        }

        private void xóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // only Admin can delete
            if (currentUser != "Admin")
            {
                MessageBox.Show("Bạn không có quyền xóa (cần Admin).", "Quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var p = (Product)listViewProducts.SelectedItems[0].Tag;
                if (MessageBox.Show($"Xóa sản phẩm {p.Name}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    products.Remove(p);
                    RefreshList();
                }
            }
        }

        public void SearchProduct(string q)
        {
            if (string.IsNullOrWhiteSpace(q)) { RefreshList(); return; }
            var list = products.Where(p => p.Name.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 || p.Code.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);
            listViewProducts.Items.Clear();
            foreach (var p in list)
            {
                var li = new ListViewItem(new string[] { p.Code, p.Name, p.Price.ToString("N0"), p.Stock.ToString() });
                li.Tag = p;
                listViewProducts.Items.Add(li);
            }
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            var path = openFileDialog1.FileName;
            try
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string code = parts[0].Trim();
                        string name = parts[1].Trim();
                        decimal price = 0; int stock = 0;
                        decimal.TryParse(parts[2].Trim(), out price);
                        int.TryParse(parts[3].Trim(), out stock);
                        string cat = parts.Length >= 5 ? parts[4].Trim() : "Uncategorized";

                        // tránh duplicate nếu đã có mã
                        if (!products.Any(p => p.Code == code))
                        {
                            products.Add(new Product(code, name, price, stock, cat));
                        }
                    }
                }
                RefreshList(); // update ListView
                MessageBox.Show("Import CSV thành công.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi import: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportReportButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var path = saveFileDialog1.FileName;
            try
            {
                // tạo header: Code,Name,Price,Stock,Revenue
                var lines = products.Select(p =>
                {
                    decimal revenue = p.Price * p.Stock; // hoặc tính từ orders nếu có
                    return $"{p.Code},{p.Name},{p.Price},{p.Stock},{revenue}";
                }).ToList();

                // thêm header
                lines.Insert(0, "Code,Name,Price,Stock,Revenue");
                File.WriteAllLines(path, lines);
                MessageBox.Show("Export báo cáo doanh thu thành công.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi export: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3) Mô phỏng Export - ProgressBar, mỗi sản phẩm delay 1s
        private async void simulateExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                simulateExportButton.Enabled = false;
                importButton.Enabled = false;
                exportReportButton.Enabled = false;

                int total = products.Count;
                if (total == 0)
                {
                    MessageBox.Show("Không có sản phẩm để export.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simulateExportButton.Enabled = true;
                    importButton.Enabled = true;
                    exportReportButton.Enabled = true;
                    return;
                }

                progressBarExport.Value = 0;
                progressBarExport.Maximum = total;

                for (int i = 0; i < total; i++)
                {
                    // Mô phỏng xử lý 1 sản phẩm
                    await Task.Delay(1000);

                    // Cập nhật progress
                    if (progressBarExport.Value < progressBarExport.Maximum) progressBarExport.Value++;
                    int percent = (int)((double)progressBarExport.Value / progressBarExport.Maximum * 100);
                    labelExportPercent.Text = percent + " %";

                    // optional: highlight item trên listView (nếu muốn)
                    try
                    {
                        if (i < listViewProducts.Items.Count)
                        {
                            listViewProducts.Items[i].BackColor = System.Drawing.Color.LightYellow;
                        }
                    }
                    catch { }
                }

                MessageBox.Show("Mô phỏng export hoàn tất.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mô phỏng: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                simulateExportButton.Enabled = true;
                importButton.Enabled = true;
                exportReportButton.Enabled = true;
                labelExportPercent.Text = "100 %";
            }
        }
        private Product GetSelectedProduct()
        {
            if (listViewProducts.SelectedItems.Count == 0) return null;
            return listViewProducts.SelectedItems[0].Tag as Product;
        }
        private void xemChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string info = $"Mã: {p.Code}\nTên: {p.Name}\nGiá: {p.Price.ToString("N0")}\nTồn kho: {p.Stock}\nDanh mục: {p.Category}";
            MessageBox.Show(info, "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
