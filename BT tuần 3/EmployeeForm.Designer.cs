namespace BT_tuần_3
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridView1;
        private TextBox txtId, txtName, txtPosition;
        private Button btnAdd, btnUpdate, btnDelete;
        private Label lblId, lblName, lblPosition;
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
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPosition = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblId = new Label();
            lblName = new Label();
            lblPosition = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(460, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 268);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 302);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 4;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(330, 268);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(140, 27);
            txtPosition.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(160, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblId
            // 
            lblId.Location = new Point(10, 270);
            lblId.Name = "lblId";
            lblId.Size = new Size(46, 23);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.Location = new Point(10, 305);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Họ tên";
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(260, 270);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(64, 23);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "Chức vụ";
            // 
            // EmployeeForm
            // 
            ClientSize = new Size(480, 400);
            Controls.Add(dataGridView1);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPosition);
            Controls.Add(txtPosition);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "EmployeeForm";
            Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}