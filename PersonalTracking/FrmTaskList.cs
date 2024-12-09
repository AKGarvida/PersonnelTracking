using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.DTO;
using BLL;

namespace PersonalTracking
{
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
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

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;

        void FillAllData()
        {
            dto = TaskBLL.GetAll();
            dgvTaskList.DataSource = dto.Tasks;

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

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            FillAllData();

            dgvTaskList.Columns[0].HeaderText = "Task Title";
            dgvTaskList.Columns[1].HeaderText = "User Number";
            dgvTaskList.Columns[2].HeaderText = "Name";
            dgvTaskList.Columns[3].HeaderText = "Surname";
            dgvTaskList.Columns[4].HeaderText = "Start Date";
            dgvTaskList.Columns[5].HeaderText = "Delivery Date";
            dgvTaskList.Columns[6].HeaderText = "Task State";   
            dgvTaskList.Columns[7].Visible = false;
            dgvTaskList.Columns[8].Visible = false;
            dgvTaskList.Columns[9].Visible = false;
            dgvTaskList.Columns[10].Visible = false;
            dgvTaskList.Columns[11].Visible = false;
            dgvTaskList.Columns[12].Visible = false;
            dgvTaskList.Columns[13].Visible = false;
            dgvTaskList.Columns[14].Visible = false;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
             
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dto.Tasks;
            if (txtUserNo.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();

            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();

            if (txtSurname.Text.Trim() != "")
                list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();

            if (cmbDepartment.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();

            if (cmbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();

            if (rbStartDate.Checked)
                list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(dpStart.Value) && 
                x.TaskStartDate < Convert.ToDateTime(dpEnd.Value)).ToList();

            if (rbDeliveryDate.Checked)
                list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(dpStart.Value) &&
                x.TaskDeliveryDate < Convert.ToDateTime(dpEnd.Value)).ToList();

            if (cmbTaskState.SelectedIndex != -1)
                list = list.Where(x => x.taskStateID == Convert.ToInt32(cmbTaskState.SelectedValue)).ToList();
            dgvTaskList.DataSource = list;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtUserNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            rbDeliveryDate.Checked = false;
            rbStartDate.Checked = false;
            cmbTaskState.SelectedIndex = -1;
            dgvTaskList.DataSource = dto.Tasks;
        }
    }
}
