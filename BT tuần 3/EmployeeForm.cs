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
    public partial class EmployeeForm : Form
    {
        private BindingList<Employee> employees = new BindingList<Employee>();
        private Employee item;

        public EmployeeForm(string username = null)
        {
            InitializeComponent();
            dataGridView1.DataSource = employees;
            // sample
            employees.Add(new Employee { Id = "E01", FullName = "Nguyễn Văn A", Position = "Thu ngân" });
            employees.Add(new Employee { Id = "E02", FullName = "Trần Thị B", Position = "Quản lý" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text)) return;
            if (employees.Any(x => x.Id == txtId.Text.Trim()))
            {
                MessageBox.Show("ID đã tồn tại");
                return;
            }
            employees.Add(new Employee { Id = txtId.Text.Trim(), FullName = txtName.Text.Trim(), Position = txtPosition.Text.Trim() });
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var emp = dataGridView1.CurrentRow.DataBoundItem as Employee;
            emp.FullName = txtName.Text.Trim();
            emp.Position = txtPosition.Text.Trim();
            dataGridView1.Refresh();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var emp = dataGridView1.CurrentRow.DataBoundItem as Employee;
            if (MessageBox.Show($"Xóa {emp.FullName}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employees.Remove(emp);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var item = dataGridView1.CurrentRow.DataBoundItem;
            if (item is Employee emp)
            {
                txtId.Text = emp.Id;
                txtName.Text = emp.FullName;
                txtPosition.Text = emp.Position;
            }
            else
            {
                var row = dataGridView1.CurrentRow;
                txtId.Text = row.Cells[0]?.Value?.ToString() ?? "";
                txtName.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtPosition.Text = row.Cells[2]?.Value?.ToString() ?? "";
            }
            txtId.Enabled = false;
        }
        private void ClearInputs()
        {
            txtId.Text = ""; txtName.Text = ""; txtPosition.Text = ""; txtId.Enabled = true;
        }
    }
}
