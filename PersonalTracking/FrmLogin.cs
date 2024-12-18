﻿using System;
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

namespace PersonalTracking
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Would you like to close window?";
            string messagetitle = "Exit Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, messagetitle, buttons, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserNo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                MessageBox.Show("Please fill the user number and password");
            else
            {
                List<EMPLOYEE> employeelist = EmployeeBLL.GetEmployees(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);

                if (employeelist.Count == 0)
                    MessageBox.Show("Please control your information");
                
                else
                {
                    EMPLOYEE employee = new EMPLOYEE();
                    employee = employeelist.First();
                    UserStatic.EmployeeID = employee.ID;
                    UserStatic.UserNo = employee.UserNo;
                    UserStatic.isAdmin = employee.isAdmin;

                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();

                    if (this.Visible == true)
                        frm.Close();

                    else
                        Application.Exit();
                }
            }


            
            
        }
    }
}
