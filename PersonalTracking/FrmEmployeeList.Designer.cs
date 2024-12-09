namespace PersonalTracking
{
    partial class FrmEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeList));
            this.pnlPositionList = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlEmployeeList = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPositionEL = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartmentEL = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.pnlEmployeeList2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlPositionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.pnlEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlEmployeeList2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPositionList
            // 
            this.pnlPositionList.BackColor = System.Drawing.Color.Red;
            this.pnlPositionList.Controls.Add(this.pctExit);
            this.pnlPositionList.Controls.Add(this.lblPosition);
            this.pnlPositionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPositionList.Location = new System.Drawing.Point(0, 0);
            this.pnlPositionList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPositionList.Name = "pnlPositionList";
            this.pnlPositionList.Size = new System.Drawing.Size(970, 93);
            this.pnlPositionList.TabIndex = 3;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(894, 0);
            this.pctExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(76, 67);
            this.pctExit.TabIndex = 1;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(4, 19);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(199, 38);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Employee List";
            // 
            // pnlEmployeeList
            // 
            this.pnlEmployeeList.Controls.Add(this.cmbPosition);
            this.pnlEmployeeList.Controls.Add(this.lblPositionEL);
            this.pnlEmployeeList.Controls.Add(this.btnClear);
            this.pnlEmployeeList.Controls.Add(this.btnSearch);
            this.pnlEmployeeList.Controls.Add(this.cmbDepartment);
            this.pnlEmployeeList.Controls.Add(this.lblDepartmentEL);
            this.pnlEmployeeList.Controls.Add(this.txtSurname);
            this.pnlEmployeeList.Controls.Add(this.lblSurname);
            this.pnlEmployeeList.Controls.Add(this.txtName);
            this.pnlEmployeeList.Controls.Add(this.lblName);
            this.pnlEmployeeList.Controls.Add(this.txtUserNo);
            this.pnlEmployeeList.Controls.Add(this.label1);
            this.pnlEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeList.Location = new System.Drawing.Point(0, 93);
            this.pnlEmployeeList.Name = "pnlEmployeeList";
            this.pnlEmployeeList.Size = new System.Drawing.Size(970, 174);
            this.pnlEmployeeList.TabIndex = 4;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(586, 63);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(274, 35);
            this.cmbPosition.TabIndex = 4;
            // 
            // lblPositionEL
            // 
            this.lblPositionEL.AutoSize = true;
            this.lblPositionEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblPositionEL.Location = new System.Drawing.Point(442, 71);
            this.lblPositionEL.Name = "lblPositionEL";
            this.lblPositionEL.Size = new System.Drawing.Size(86, 27);
            this.lblPositionEL.TabIndex = 7;
            this.lblPositionEL.Text = "Position";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(763, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 53);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(586, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 53);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(586, 10);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(274, 35);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblDepartmentEL
            // 
            this.lblDepartmentEL.AutoSize = true;
            this.lblDepartmentEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentEL.Location = new System.Drawing.Point(442, 18);
            this.lblDepartmentEL.Name = "lblDepartmentEL";
            this.lblDepartmentEL.Size = new System.Drawing.Size(123, 27);
            this.lblDepartmentEL.TabIndex = 7;
            this.lblDepartmentEL.Text = "Department";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtSurname.Location = new System.Drawing.Point(148, 123);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(251, 34);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(25, 126);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(94, 27);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(148, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(25, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserNo.Location = new System.Drawing.Point(148, 11);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(251, 34);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserNo";
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 267);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(970, 413);
            this.dgvEmployeeList.TabIndex = 5;
            // 
            // pnlEmployeeList2
            // 
            this.pnlEmployeeList2.Controls.Add(this.btnDelete);
            this.pnlEmployeeList2.Controls.Add(this.btnUpdate);
            this.pnlEmployeeList2.Controls.Add(this.btnNew);
            this.pnlEmployeeList2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmployeeList2.Location = new System.Drawing.Point(0, 583);
            this.pnlEmployeeList2.Name = "pnlEmployeeList2";
            this.pnlEmployeeList2.Size = new System.Drawing.Size(970, 97);
            this.pnlEmployeeList2.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(586, 18);
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
            this.btnUpdate.Location = new System.Drawing.Point(416, 18);
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
            this.btnNew.Location = new System.Drawing.Point(246, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 67);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 680);
            this.Controls.Add(this.pnlEmployeeList2);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.pnlEmployeeList);
            this.Controls.Add(this.pnlPositionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployeeList";
            this.Load += new System.EventHandler(this.FrmEmployeeList_Load);
            this.pnlPositionList.ResumeLayout(false);
            this.pnlPositionList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.pnlEmployeeList.ResumeLayout(false);
            this.pnlEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlEmployeeList2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPositionList;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel pnlEmployeeList;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Panel pnlEmployeeList2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPositionEL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartmentEL;
    }
}