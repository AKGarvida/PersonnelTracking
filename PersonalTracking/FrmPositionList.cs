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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        List<PositionDTO> positionList = new List<PositionDTO>();
        void FillGrid()
        {
            positionList = PositionBLL.GetPositions();
            dgvPositionList.DataSource = positionList;
        }

        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            FillGrid();
            dgvPositionList.Columns[1].Visible = false;
            dgvPositionList.Columns[3].Visible = false;
            dgvPositionList.Columns[0].HeaderText = "Department Name";
            dgvPositionList.Columns[2].HeaderText = "Position Name";

        }
    }
}
