namespace PersonalTracking
{
    partial class FrmSalaryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalaryList));
            this.pnlSalaryList = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblSalaryList = new System.Windows.Forms.Label();
            this.pnlForCriteria = new System.Windows.Forms.Panel();
            this.pnlForUsers = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalaryy = new System.Windows.Forms.Label();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPositionEL = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartmentEL = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblUserNoTL = new System.Windows.Forms.Label();
            this.pnlDockDown = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvSalaryList = new System.Windows.Forms.DataGridView();
            this.pnlSalaryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.pnlForCriteria.SuspendLayout();
            this.pnlForUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.pnlDockDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalaryList
            // 
            this.pnlSalaryList.BackColor = System.Drawing.Color.Red;
            this.pnlSalaryList.Controls.Add(this.pctExit);
            this.pnlSalaryList.Controls.Add(this.lblSalaryList);
            this.pnlSalaryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalaryList.Location = new System.Drawing.Point(0, 0);
            this.pnlSalaryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSalaryList.Name = "pnlSalaryList";
            this.pnlSalaryList.Size = new System.Drawing.Size(980, 88);
            this.pnlSalaryList.TabIndex = 9;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(904, 0);
            this.pctExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(76, 67);
            this.pctExit.TabIndex = 1;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblSalaryList
            // 
            this.lblSalaryList.AutoSize = true;
            this.lblSalaryList.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblSalaryList.Location = new System.Drawing.Point(4, 19);
            this.lblSalaryList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalaryList.Name = "lblSalaryList";
            this.lblSalaryList.Size = new System.Drawing.Size(152, 38);
            this.lblSalaryList.TabIndex = 0;
            this.lblSalaryList.Text = "Salary List";
            // 
            // pnlForCriteria
            // 
            this.pnlForCriteria.Controls.Add(this.pnlForUsers);
            this.pnlForCriteria.Controls.Add(this.pnlForAdmin);
            this.pnlForCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForCriteria.Location = new System.Drawing.Point(0, 88);
            this.pnlForCriteria.Name = "pnlForCriteria";
            this.pnlForCriteria.Size = new System.Drawing.Size(980, 298);
            this.pnlForCriteria.TabIndex = 10;
            // 
            // pnlForUsers
            // 
            this.pnlForUsers.Controls.Add(this.btnClear);
            this.pnlForUsers.Controls.Add(this.btnSearch);
            this.pnlForUsers.Controls.Add(this.groupBox1);
            this.pnlForUsers.Controls.Add(this.cmbMonth);
            this.pnlForUsers.Controls.Add(this.txtYear);
            this.pnlForUsers.Controls.Add(this.lblYear);
            this.pnlForUsers.Controls.Add(this.lblMonth);
            this.pnlForUsers.Controls.Add(this.txtSalary);
            this.pnlForUsers.Controls.Add(this.lblSalaryy);
            this.pnlForUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForUsers.Location = new System.Drawing.Point(461, 0);
            this.pnlForUsers.Name = "pnlForUsers";
            this.pnlForUsers.Size = new System.Drawing.Size(519, 298);
            this.pnlForUsers.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(325, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 53);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(325, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 53);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbLess);
            this.groupBox1.Controls.Add(this.rbMore);
            this.groupBox1.Location = new System.Drawing.Point(139, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 135);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEqual.Location = new System.Drawing.Point(6, 89);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(85, 31);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equal";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLess.Location = new System.Drawing.Point(6, 52);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(73, 31);
            this.rbLess.TabIndex = 1;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Less";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMore.Location = new System.Drawing.Point(6, 15);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(82, 31);
            this.rbMore.TabIndex = 0;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(139, 68);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(342, 35);
            this.cmbMonth.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtYear.Location = new System.Drawing.Point(139, 18);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(342, 34);
            this.txtYear.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(25, 25);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 27);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(26, 76);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(74, 27);
            this.lblMonth.TabIndex = 26;
            this.lblMonth.Text = "Month";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(139, 120);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(342, 34);
            this.txtSalary.TabIndex = 2;
            // 
            // lblSalaryy
            // 
            this.lblSalaryy.AutoSize = true;
            this.lblSalaryy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalaryy.Location = new System.Drawing.Point(25, 127);
            this.lblSalaryy.Name = "lblSalaryy";
            this.lblSalaryy.Size = new System.Drawing.Size(69, 27);
            this.lblSalaryy.TabIndex = 28;
            this.lblSalaryy.Text = "Salary";
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPosition);
            this.pnlForAdmin.Controls.Add(this.lblPositionEL);
            this.pnlForAdmin.Controls.Add(this.cmbDepartment);
            this.pnlForAdmin.Controls.Add(this.lblDepartmentEL);
            this.pnlForAdmin.Controls.Add(this.txtSurname);
            this.pnlForAdmin.Controls.Add(this.lblSurname);
            this.pnlForAdmin.Controls.Add(this.txtName);
            this.pnlForAdmin.Controls.Add(this.lblName);
            this.pnlForAdmin.Controls.Add(this.txtUserNo);
            this.pnlForAdmin.Controls.Add(this.lblUserNoTL);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(461, 298);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(172, 237);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(251, 35);
            this.cmbPosition.TabIndex = 4;
            // 
            // lblPositionEL
            // 
            this.lblPositionEL.AutoSize = true;
            this.lblPositionEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblPositionEL.Location = new System.Drawing.Point(28, 245);
            this.lblPositionEL.Name = "lblPositionEL";
            this.lblPositionEL.Size = new System.Drawing.Size(86, 27);
            this.lblPositionEL.TabIndex = 21;
            this.lblPositionEL.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(172, 180);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(251, 35);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblDepartmentEL
            // 
            this.lblDepartmentEL.AutoSize = true;
            this.lblDepartmentEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentEL.Location = new System.Drawing.Point(28, 188);
            this.lblDepartmentEL.Name = "lblDepartmentEL";
            this.lblDepartmentEL.Size = new System.Drawing.Size(123, 27);
            this.lblDepartmentEL.TabIndex = 22;
            this.lblDepartmentEL.Text = "Department";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtSurname.Location = new System.Drawing.Point(172, 124);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(251, 34);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(28, 127);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(94, 27);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(172, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(28, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 27);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserNo.Location = new System.Drawing.Point(172, 12);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(251, 34);
            this.txtUserNo.TabIndex = 0;
            // 
            // lblUserNoTL
            // 
            this.lblUserNoTL.AutoSize = true;
            this.lblUserNoTL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserNoTL.Location = new System.Drawing.Point(28, 19);
            this.lblUserNoTL.Name = "lblUserNoTL";
            this.lblUserNoTL.Size = new System.Drawing.Size(83, 27);
            this.lblUserNoTL.TabIndex = 20;
            this.lblUserNoTL.Text = "UserNo";
            // 
            // pnlDockDown
            // 
            this.pnlDockDown.Controls.Add(this.btnDelete);
            this.pnlDockDown.Controls.Add(this.btnUpdate);
            this.pnlDockDown.Controls.Add(this.btnNew);
            this.pnlDockDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDockDown.Location = new System.Drawing.Point(0, 752);
            this.pnlDockDown.Name = "pnlDockDown";
            this.pnlDockDown.Size = new System.Drawing.Size(980, 93);
            this.pnlDockDown.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(586, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(416, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 67);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Red;
            this.btnNew.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(246, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 67);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvSalaryList
            // 
            this.dgvSalaryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaryList.Location = new System.Drawing.Point(0, 386);
            this.dgvSalaryList.Name = "dgvSalaryList";
            this.dgvSalaryList.RowHeadersWidth = 51;
            this.dgvSalaryList.RowTemplate.Height = 24;
            this.dgvSalaryList.Size = new System.Drawing.Size(980, 366);
            this.dgvSalaryList.TabIndex = 12;
            // 
            // FrmSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 845);
            this.Controls.Add(this.dgvSalaryList);
            this.Controls.Add(this.pnlDockDown);
            this.Controls.Add(this.pnlForCriteria);
            this.Controls.Add(this.pnlSalaryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalaryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalaryList";
            this.Load += new System.EventHandler(this.FrmSalaryList_Load);
            this.pnlSalaryList.ResumeLayout(false);
            this.pnlSalaryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.pnlForCriteria.ResumeLayout(false);
            this.pnlForUsers.ResumeLayout(false);
            this.pnlForUsers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.pnlDockDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalaryList;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblSalaryList;
        private System.Windows.Forms.Panel pnlForCriteria;
        private System.Windows.Forms.Panel pnlDockDown;
        private System.Windows.Forms.DataGridView dgvSalaryList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlForUsers;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPositionEL;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartmentEL;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label lblUserNoTL;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalaryy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}