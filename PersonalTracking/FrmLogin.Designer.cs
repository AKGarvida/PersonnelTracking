namespace PersonalTracking
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLoginUser = new System.Windows.Forms.Panel();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.pnlLoginUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserNo";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserNo.Location = new System.Drawing.Point(188, 123);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(251, 34);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(188, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 34);
            this.txtPassword.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Red;
            this.btnEnter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(101, 256);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(124, 47);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(283, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLoginUser
            // 
            this.pnlLoginUser.BackColor = System.Drawing.Color.Red;
            this.pnlLoginUser.Controls.Add(this.lblLoginUser);
            this.pnlLoginUser.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginUser.Name = "pnlLoginUser";
            this.pnlLoginUser.Size = new System.Drawing.Size(518, 99);
            this.pnlLoginUser.TabIndex = 4;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.Location = new System.Drawing.Point(6, 30);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(158, 38);
            this.lblLoginUser.TabIndex = 0;
            this.lblLoginUser.Text = "Login User";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.pnlLoginUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLoginUser;
        private System.Windows.Forms.Label lblLoginUser;
    }
}

