namespace Prototype
{
    partial class frmLogin
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblRegister1 = new System.Windows.Forms.Label();
            this.lblRegister2 = new System.Windows.Forms.Label();
            this.lblRegister3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(180, 29);
            this.picLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 154);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.Location = new System.Drawing.Point(150, 183);
            this.lblUniversity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(239, 30);
            this.lblUniversity.TabIndex = 1;
            this.lblUniversity.Text = "Unsung University";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Location = new System.Drawing.Point(80, 250);
            this.lblUserid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(89, 25);
            this.lblUserid.TabIndex = 2;
            this.lblUserid.Text = "User ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 346);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(86, 279);
            this.txtUserid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(384, 31);
            this.txtUserid.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(202, 463);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Location = new System.Drawing.Point(190, 525);
            this.lnkForgot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(186, 25);
            this.lnkForgot.TabIndex = 4;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot Password?";
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(176, 602);
            this.lnkRegister.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(92, 25);
            this.lnkRegister.TabIndex = 5;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // lblRegister1
            // 
            this.lblRegister1.AutoSize = true;
            this.lblRegister1.Location = new System.Drawing.Point(48, 577);
            this.lblRegister1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegister1.Name = "lblRegister1";
            this.lblRegister1.Size = new System.Drawing.Size(470, 25);
            this.lblRegister1.TabIndex = 9;
            this.lblRegister1.Text = "If you need access, but do not have an ID, click ";
            // 
            // lblRegister2
            // 
            this.lblRegister2.AutoSize = true;
            this.lblRegister2.Location = new System.Drawing.Point(100, 602);
            this.lblRegister2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegister2.Name = "lblRegister2";
            this.lblRegister2.Size = new System.Drawing.Size(85, 25);
            this.lblRegister2.TabIndex = 10;
            this.lblRegister2.Text = "this link";
            // 
            // lblRegister3
            // 
            this.lblRegister3.AutoSize = true;
            this.lblRegister3.Location = new System.Drawing.Point(264, 602);
            this.lblRegister3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegister3.Name = "lblRegister3";
            this.lblRegister3.Size = new System.Drawing.Size(188, 25);
            this.lblRegister3.TabIndex = 11;
            this.lblRegister3.Text = "to request access.";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 375);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(384, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 671);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRegister3);
            this.Controls.Add(this.lblRegister2);
            this.Controls.Add(this.lblRegister1);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.lnkForgot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserid);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmLogin";
            this.Text = "IMA Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblRegister1;
        private System.Windows.Forms.Label lblRegister2;
        private System.Windows.Forms.Label lblRegister3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

