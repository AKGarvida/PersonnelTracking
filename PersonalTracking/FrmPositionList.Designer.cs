namespace PersonalTracking
{
    partial class FrmPositionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPositionList));
            this.pnlPositionList = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.dgvPositionList = new System.Windows.Forms.DataGridView();
            this.pnlPositionListButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlPositionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).BeginInit();
            this.pnlPositionListButtons.SuspendLayout();
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
            this.pnlPositionList.Size = new System.Drawing.Size(809, 103);
            this.pnlPositionList.TabIndex = 2;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(733, 0);
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
            this.lblPosition.Location = new System.Drawing.Point(4, 29);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(176, 38);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position List";
            // 
            // dgvPositionList
            // 
            this.dgvPositionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPositionList.Location = new System.Drawing.Point(0, 103);
            this.dgvPositionList.Name = "dgvPositionList";
            this.dgvPositionList.RowHeadersWidth = 51;
            this.dgvPositionList.RowTemplate.Height = 24;
            this.dgvPositionList.Size = new System.Drawing.Size(809, 424);
            this.dgvPositionList.TabIndex = 3;
            // 
            // pnlPositionListButtons
            // 
            this.pnlPositionListButtons.Controls.Add(this.btnDelete);
            this.pnlPositionListButtons.Controls.Add(this.btnUpdate);
            this.pnlPositionListButtons.Controls.Add(this.btnAdd);
            this.pnlPositionListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPositionListButtons.Location = new System.Drawing.Point(0, 549);
            this.pnlPositionListButtons.Name = "pnlPositionListButtons";
            this.pnlPositionListButtons.Size = new System.Drawing.Size(809, 112);
            this.pnlPositionListButtons.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(505, 23);
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
            this.btnUpdate.Location = new System.Drawing.Point(335, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 67);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // FrmPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 661);
            this.Controls.Add(this.pnlPositionListButtons);
            this.Controls.Add(this.dgvPositionList);
            this.Controls.Add(this.pnlPositionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPositionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPositionList";
            this.pnlPositionList.ResumeLayout(false);
            this.pnlPositionList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).EndInit();
            this.pnlPositionListButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPositionList;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.DataGridView dgvPositionList;
        private System.Windows.Forms.Panel pnlPositionListButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}