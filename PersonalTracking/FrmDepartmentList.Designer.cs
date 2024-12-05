namespace PersonalTracking
{
    partial class FrmDepartmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmentList));
            this.pnlDepartmentList = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblDepartmentList = new System.Windows.Forms.Label();
            this.dgvDepartmentList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDepartmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDepartmentList
            // 
            this.pnlDepartmentList.BackColor = System.Drawing.Color.Red;
            this.pnlDepartmentList.Controls.Add(this.pctExit);
            this.pnlDepartmentList.Controls.Add(this.lblDepartmentList);
            this.pnlDepartmentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDepartmentList.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartmentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDepartmentList.Name = "pnlDepartmentList";
            this.pnlDepartmentList.Size = new System.Drawing.Size(923, 109);
            this.pnlDepartmentList.TabIndex = 0;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(847, 0);
            this.pctExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(76, 67);
            this.pctExit.TabIndex = 1;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblDepartmentList
            // 
            this.lblDepartmentList.AutoSize = true;
            this.lblDepartmentList.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentList.Location = new System.Drawing.Point(4, 29);
            this.lblDepartmentList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentList.Name = "lblDepartmentList";
            this.lblDepartmentList.Size = new System.Drawing.Size(224, 38);
            this.lblDepartmentList.TabIndex = 0;
            this.lblDepartmentList.Text = "Department List";
            // 
            // dgvDepartmentList
            // 
            this.dgvDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDepartmentList.Location = new System.Drawing.Point(0, 109);
            this.dgvDepartmentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDepartmentList.Name = "dgvDepartmentList";
            this.dgvDepartmentList.RowHeadersWidth = 51;
            this.dgvDepartmentList.RowTemplate.Height = 24;
            this.dgvDepartmentList.Size = new System.Drawing.Size(923, 423);
            this.dgvDepartmentList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 102);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(211, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(381, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 67);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(551, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmDepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDepartmentList);
            this.Controls.Add(this.pnlDepartmentList);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDepartmentList";
            this.Text = "FrmDepartmentList";
            this.pnlDepartmentList.ResumeLayout(false);
            this.pnlDepartmentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepartmentList;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblDepartmentList;
        private System.Windows.Forms.DataGridView dgvDepartmentList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}