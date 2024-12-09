using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmTask : Form
    {
        public FrmTask()
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

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;

        private void FrmTask_Load(object sender, EventArgs e)
        {
            lblTaskState.Visible = false;
            cmbTaskState.Visible = false;

            dto = TaskBLL.GetAll();

            dgvTask.DataSource = dto.Employees;
            dgvTask.Columns[0].Visible = false;
            dgvTask.Columns[1].HeaderText = "User Number";
            dgvTask.Columns[2].HeaderText = "Name";
            dgvTask.Columns[3].HeaderText = "Surname";
            dgvTask.Columns[4].Visible = false;
            dgvTask.Columns[5].Visible = false;
            dgvTask.Columns[6].Visible = false;
            dgvTask.Columns[7].Visible = false;
            dgvTask.Columns[8].Visible = false;
            dgvTask.Columns[9].Visible = false;
            dgvTask.Columns[10].Visible = false;
            dgvTask.Columns[11].Visible = false;
            dgvTask.Columns[12].Visible = false;
            dgvTask.Columns[13].Visible = false;
           
            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "Department Name";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "Position Name";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbTaskState.DataSource = dto.TaskStates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.ValueMember = "ID";
            cmbTaskState.SelectedIndex = -1;


        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
                List<EmployeeDetailDTO> list = dto.Employees;
                dgvTask.DataSource = list.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }
        }

        private void dgvTask_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dgvTask.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvTask.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dgvTask.Rows[e.RowIndex].Cells[3].Value.ToString();
            task.EmployeeID = Convert.ToInt32(dgvTask.Rows[e.RowIndex].Cells[0].Value);
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
               
                List<EmployeeDetailDTO> list = dto.Employees;
                dgvTask.DataSource = list.Where(x => x.PositionID ==
                Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }
        }

        TASK task = new TASK();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (task.EmployeeID == 0)
                MessageBox.Show("Please select an employee on the table");

            else if (txtTitlee.Text.Trim() == "")
                MessageBox.Show("Task Title is empty");

            else if (txtContent.Text.Trim() == "")
                MessageBox.Show("Content is empty");

            else
            {
                task.TaskTitle = txtTitlee.Text;
                task.TaskContent = txtContent.Text;
                task.TaskStartDate = DateTime.Today;
                task.TaskState = 1;
                TaskBLL.AddTask(task);
                MessageBox.Show("Task was added");

                txtTitlee.Clear();
                txtContent.Clear();
                task = new TASK();

            }
        }
    }
}
