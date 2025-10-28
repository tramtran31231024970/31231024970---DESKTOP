



namespace BT_tuần_3
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitContainer1;
        private TreeView treeViewCategories;
        private ListView listViewProducts;
        private ColumnHeader colCode;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colStock;
        private Button importButton;
        private Button exportReportButton;
        private Button exportButton;
        private Button simulateExportButton;
        private ProgressBar progressBarExport;
        private Label labelExportPercent;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private ToolStripMenuItem xóaSảnPhẩmToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;

        private ContextMenuStrip contextMenuStripProduct;
        private ToolStripMenuItem xemChiTietToolStripMenuItem;
        private ToolStripMenuItem xoaSanPhamToolStripMenuItem;
        private EventHandler xoaSanPhamToolStripMenuItem_Click;

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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            treeViewCategories = new TreeView();
            listViewProducts = new ListView();
            colCode = new ColumnHeader();
            colName = new ColumnHeader();
            colPrice = new ColumnHeader();
            colStock = new ColumnHeader();
            importButton = new Button();
            exportButton = new Button();
            simulateExportButton = new Button();
            progressBarExport = new ProgressBar();
            labelExportPercent = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xemChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            xóaSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            exportReportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            this.contextMenuStripProduct = new ContextMenuStrip();
            this.xemChiTietToolStripMenuItem = new ToolStripMenuItem();
            this.xoaSanPhamToolStripMenuItem = new ToolStripMenuItem();

            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeViewCategories);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewProducts);
            splitContainer1.Panel2.Controls.Add(exportReportButton);
            splitContainer1.Size = new Size(1076, 553);
            splitContainer1.SplitterDistance = 363;
            splitContainer1.TabIndex = 1;
            // 
            // treeViewCategories
            // 
            treeViewCategories.Dock = DockStyle.Fill;
            treeViewCategories.Location = new Point(0, 0);
            treeViewCategories.Name = "treeViewCategories";
            treeViewCategories.Size = new Size(363, 553);
            treeViewCategories.TabIndex = 0;
            treeViewCategories.AfterSelect += treeViewCategories_AfterSelect;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { colCode, colName, colPrice, colStock });
            listViewProducts.Dock = DockStyle.Top;
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(0, 0);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(709, 333);
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.MouseClick += listViewProducts_MouseClick;

            // xemChiTietToolStripMenuItem
            // 
            this.xemChiTietToolStripMenuItem.Text = "Xem chi tiết";
            this.xemChiTietToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietToolStripMenuItem_Click);

            // 
            // xoaSanPhamToolStripMenuItem
            // 
            this.xoaSanPhamToolStripMenuItem.Text = "Xóa sản phẩm";
            this.xoaSanPhamToolStripMenuItem.Click += new System.EventHandler(this.xóaSảnPhẩmToolStripMenuItem_Click);



            // add items to contextMenu
            this.contextMenuStripProduct.Items.AddRange(new ToolStripItem[] {
            this.xemChiTietToolStripMenuItem,
            this.xoaSanPhamToolStripMenuItem
            });

            // assign to listView
            this.listViewProducts.ContextMenuStrip = this.contextMenuStripProduct;
            // 
            // colCode
            // 
            colCode.Text = "Mã";
            colCode.Width = 80;
            // 
            // colName
            // 
            colName.Text = "Tên";
            colName.Width = 180;
            // 
            // colPrice
            // 
            colPrice.Text = "Giá";
            colPrice.Width = 100;
            // 
            // colStock
            // 
            colStock.Text = "Tồn kho";
            colStock.Width = 80;
            // 
            // importButton
            // 
            importButton.Location = new Point(220, 310);
            importButton.Name = "importButton";
            importButton.Size = new Size(80, 23);
            importButton.TabIndex = 1;
            importButton.Text = "Import CSV";
            importButton.Click += importButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(0, 0);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 6;
            // 
            // simulateExportButton
            // 
            simulateExportButton.Location = new Point(420, 310);
            simulateExportButton.Name = "simulateExportButton";
            simulateExportButton.Size = new Size(120, 23);
            simulateExportButton.TabIndex = 3;
            simulateExportButton.Text = "Mô phỏng Export";
            simulateExportButton.Click += simulateExportButton_Click;
            // 
            // progressBarExport
            // 
            progressBarExport.Location = new Point(220, 350);
            progressBarExport.Name = "progressBarExport";
            progressBarExport.Size = new Size(300, 23);
            progressBarExport.TabIndex = 4;
            // 
            // labelExportPercent
            // 
            labelExportPercent.AutoSize = true;
            labelExportPercent.Location = new Point(530, 352);
            labelExportPercent.Name = "labelExportPercent";
            labelExportPercent.Size = new Size(33, 20);
            labelExportPercent.TabIndex = 5;
            labelExportPercent.Text = "0 %";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xemChiTiếtToolStripMenuItem, xóaSảnPhẩmToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 52);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            xemChiTiếtToolStripMenuItem.Size = new Size(172, 24);
            xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            xemChiTiếtToolStripMenuItem.Click += xemChiTiếtToolStripMenuItem_Click;
            // 
            // xóaSảnPhẩmToolStripMenuItem
            // 
            xóaSảnPhẩmToolStripMenuItem.Name = "xóaSảnPhẩmToolStripMenuItem";
            xóaSảnPhẩmToolStripMenuItem.Size = new Size(172, 24);
            xóaSảnPhẩmToolStripMenuItem.Text = "Xóa sản phẩm";
            xóaSảnPhẩmToolStripMenuItem.Click += xóaSảnPhẩmToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // exportReportButton
            // 
            exportReportButton.Location = new Point(3, 339);
            exportReportButton.Name = "exportReportButton";
            exportReportButton.Size = new Size(100, 33);
            exportReportButton.TabIndex = 2;
            exportReportButton.Text = "Export Report";
            exportReportButton.Click += exportReportButton_Click;
            // 
            // ProductForm
            // 
            ClientSize = new Size(1076, 553);
            Controls.Add(splitContainer1);
            Controls.Add(importButton);
            Controls.Add(exportButton);
            Controls.Add(simulateExportButton);
            Controls.Add(progressBarExport);
            Controls.Add(labelExportPercent);
            Name = "ProductForm";
            Text = "Sản phẩm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        //private void xoaSanPhamToolStripMenuItem_Click(object sender, EventArgs e) => throw new NotImplementedException();

        //private void xemChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        /*private void exportReportButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}