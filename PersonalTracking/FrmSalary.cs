using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmSalary : Form
    {
        public FrmSalary()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            string message = "Would you like to close window?";
            string messagetitle = "Exit Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, messagetitle, buttons, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        SalaryDTO dto = new SalaryDTO();
        private bool combofull;

        private void FrmSalary_Load(object sender, EventArgs e)
        {
            dto = SalaryBLL.GetAll();
            dgvSalary.DataSource = dto.Employees;
            dgvSalary.Columns[0].Visible = false;
            dgvSalary.Columns[1].HeaderText = "User Number";
            dgvSalary.Columns[2].HeaderText = "Name";
            dgvSalary.Columns[3].HeaderText = "Surname";
            dgvSalary.Columns[4].Visible = false;
            dgvSalary.Columns[5].Visible = false;
            dgvSalary.Columns[6].Visible = false;
            dgvSalary.Columns[7].Visible = false;
            dgvSalary.Columns[8].Visible = false;
            dgvSalary.Columns[9].Visible = false;
            dgvSalary.Columns[10].Visible = false;
            dgvSalary.Columns[11].Visible = false;
            dgvSalary.Columns[12].Visible = false;
            dgvSalary.Columns[13].Visible = false;

            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;

            if (dto.Departments.Count > 0)
            combofull = true;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;

        }

        SALARY salary = new SALARY();
        private void dgvSalary_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dgvSalary.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvSalary.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dgvSalary.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtYear.Text = DateTime.Today.Year.ToString();
            txtSalary.Text = dgvSalary.Rows[e.RowIndex].Cells[8].Value.ToString();
            salary.EmployeeID = Convert.ToInt32(dgvSalary.Rows[e.RowIndex].Cells[0].Value);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Trim() == "")
                MessageBox.Show("Please fill the year");

            else if (cmbMonth.SelectedIndex == -1)
                MessageBox.Show("Please select a month");

            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Please fill the salary");

            else if (txtUserNo.Text == "")
                MessageBox.Show("Please select an employee from the table");

            else
            {
                salary.Year = Convert.ToInt32(txtYear.Text);
                salary.MonthID = Convert.ToInt32(cmbMonth.SelectedValue);
                salary.Amount = Convert.ToInt32(txtSalary.Text);
                SalaryBLL.AddSalary(salary);
                MessageBox.Show("Salary was added");
                cmbMonth.SelectedIndex = -1;
            }
        }
    }
}
