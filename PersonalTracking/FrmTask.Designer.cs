namespace PersonalTracking
{
    partial class FrmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTask));
            this.pnlTask = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.pnl2 = new System.Windows.Forms.Panel();
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
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtTitlee = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.Red;
            this.pnlTask.Controls.Add(this.pctExit);
            this.pnlTask.Controls.Add(this.lblTask);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTask.Location = new System.Drawing.Point(0, 0);
            this.pnlTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(1153, 93);
            this.pnlTask.TabIndex = 5;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(1077, -1);
            this.pctExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(76, 67);
            this.pctExit.TabIndex = 1;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTask.Location = new System.Drawing.Point(4, 28);
            this.lblTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(77, 38);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.dgvTask);
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl1.Location = new System.Drawing.Point(692, 93);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(461, 675);
            this.pnl1.TabIndex = 6;
            // 
            // dgvTask
            // 
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 215);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 24;
            this.dgvTask.Size = new System.Drawing.Size(461, 460);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_RowEnter);
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.cmbPosition);
            this.pnl2.Controls.Add(this.lblPositionEL);
            this.pnl2.Controls.Add(this.cmbDepartment);
            this.pnl2.Controls.Add(this.lblDepartmentEL);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(461, 215);
            this.pnl2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(178, 78);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(251, 35);
            this.cmbPosition.TabIndex = 1;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // lblPositionEL
            // 
            this.lblPositionEL.AutoSize = true;
            this.lblPositionEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblPositionEL.Location = new System.Drawing.Point(34, 86);
            this.lblPositionEL.Name = "lblPositionEL";
            this.lblPositionEL.Size = new System.Drawing.Size(86, 27);
            this.lblPositionEL.TabIndex = 15;
            this.lblPositionEL.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(178, 21);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(251, 35);
            this.cmbDepartment.TabIndex = 0;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblDepartmentEL
            // 
            this.lblDepartmentEL.AutoSize = true;
            this.lblDepartmentEL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentEL.Location = new System.Drawing.Point(34, 29);
            this.lblDepartmentEL.Name = "lblDepartmentEL";
            this.lblDepartmentEL.Size = new System.Drawing.Size(123, 27);
            this.lblDepartmentEL.TabIndex = 16;
            this.lblDepartmentEL.Text = "Department";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtSurname.Location = new System.Drawing.Point(169, 227);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(342, 34);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(25, 230);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(94, 27);
            this.lblSurname.TabIndex = 12;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(169, 172);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(342, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(25, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 27);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserNo.Location = new System.Drawing.Point(169, 115);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.ReadOnly = true;
            this.txtUserNo.Size = new System.Drawing.Size(342, 34);
            this.txtUserNo.TabIndex = 0;
            // 
            // lblUserNoTL
            // 
            this.lblUserNoTL.AutoSize = true;
            this.lblUserNoTL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserNoTL.Location = new System.Drawing.Point(25, 122);
            this.lblUserNoTL.Name = "lblUserNoTL";
            this.lblUserNoTL.Size = new System.Drawing.Size(83, 27);
            this.lblUserNoTL.TabIndex = 14;
            this.lblUserNoTL.Text = "UserNo";
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(169, 285);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(342, 35);
            this.cmbTaskState.TabIndex = 3;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaskState.Location = new System.Drawing.Point(25, 293);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(106, 27);
            this.lblTaskState.TabIndex = 16;
            this.lblTaskState.Text = "Task State";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(25, 345);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(55, 27);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.Text = "Title";
            // 
            // txtTitlee
            // 
            this.txtTitlee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitlee.Location = new System.Drawing.Point(169, 342);
            this.txtTitlee.Name = "txtTitlee";
            this.txtTitlee.Size = new System.Drawing.Size(342, 34);
            this.txtTitlee.TabIndex = 4;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblContent.Location = new System.Drawing.Point(25, 403);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(85, 27);
            this.lblContent.TabIndex = 12;
            this.lblContent.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtContent.Location = new System.Drawing.Point(169, 400);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(502, 281);
            this.txtContent.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(547, 698);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 768);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTaskState);
            this.Controls.Add(this.lblTaskState);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtTitlee);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.lblUserNoTL);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnlTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTask";
            this.Load += new System.EventHandler(this.FrmTask_Load);
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.DataGridView dgvTask;
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
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtTitlee;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
    }
}