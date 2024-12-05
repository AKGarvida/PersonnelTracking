namespace PersonalTracking
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.BackColor = System.Drawing.Color.Red;
            this.pnlDepartment.Controls.Add(this.pctExit);
            this.pnlDepartment.Controls.Add(this.lblDepartment);
            this.pnlDepartment.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(511, 99);
            this.pnlDepartment.TabIndex = 1;
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctExit.Location = new System.Drawing.Point(453, 0);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(56, 50);
            this.pctExit.TabIndex = 1;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.Location = new System.Drawing.Point(6, 30);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(170, 38);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtDepartment.Location = new System.Drawing.Point(189, 123);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(251, 34);
            this.txtDepartment.TabIndex = 0;
            // 
            // lblDepartment2
            // 
            this.lblDepartment2.AutoSize = true;
            this.lblDepartment2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartment2.Location = new System.Drawing.Point(60, 130);
            this.lblDepartment2.Name = "lblDepartment2";
            this.lblDepartment2.Size = new System.Drawing.Size(123, 27);
            this.lblDepartment2.TabIndex = 3;
            this.lblDepartment2.Text = "Department";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(316, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 285);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment2);
            this.Controls.Add(this.pnlDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment2;
        private System.Windows.Forms.Button btnSave;
    }
}