namespace PersonalTracking
{
    partial class FrmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosition));
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPosition
            // 
            this.pnlPosition.BackColor = System.Drawing.Color.Red;
            this.pnlPosition.Controls.Add(this.pctExit);
            this.pnlPosition.Controls.Add(this.lblPosition);
            this.pnlPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPosition.Location = new System.Drawing.Point(0, 0);
            this.pnlPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(621, 103);
            this.pnlPosition.TabIndex = 1;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(545, 0);
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
            this.lblPosition.Size = new System.Drawing.Size(122, 38);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            // 
            // lblDepartment2
            // 
            this.lblDepartment2.AutoSize = true;
            this.lblDepartment2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartment2.Location = new System.Drawing.Point(93, 171);
            this.lblDepartment2.Name = "lblDepartment2";
            this.lblDepartment2.Size = new System.Drawing.Size(86, 27);
            this.lblDepartment2.TabIndex = 5;
            this.lblDepartment2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(93, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(237, 227);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(274, 35);
            this.cmbDepartment.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtPosition.Location = new System.Drawing.Point(237, 164);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(274, 34);
            this.txtPosition.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(387, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 396);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDepartment2);
            this.Controls.Add(this.pnlPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPosition";
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnSave;
    }
}