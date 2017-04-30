namespace Prototype
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnLectures = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(48, 49);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 123);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.Location = new System.Drawing.Point(200, 132);
            this.lblUniversity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(269, 39);
            this.lblUniversity.TabIndex = 2;
            this.lblUniversity.Text = "Unsung University";
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGrades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrades.BackgroundImage")));
            this.btnGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.Location = new System.Drawing.Point(111, 271);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(272, 137);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "Grade     \r\nSheet     ";
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Location = new System.Drawing.Point(456, 271);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(272, 137);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance    \r\nSheet         ";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedule.BackgroundImage")));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.Location = new System.Drawing.Point(801, 271);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(272, 137);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule    \r\nSheet        ";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnLectures
            // 
            this.btnLectures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLectures.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLectures.BackgroundImage")));
            this.btnLectures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLectures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLectures.Location = new System.Drawing.Point(111, 471);
            this.btnLectures.Name = "btnLectures";
            this.btnLectures.Size = new System.Drawing.Size(272, 137);
            this.btnLectures.TabIndex = 6;
            this.btnLectures.Text = "Lectures    ";
            this.btnLectures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLectures.UseVisualStyleBackColor = false;
            this.btnLectures.Click += new System.EventHandler(this.btnLectures_Click);
            // 
            // btnDemographics
            // 
            this.btnDemographics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDemographics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemographics.BackgroundImage")));
            this.btnDemographics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDemographics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemographics.Location = new System.Drawing.Point(456, 471);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(272, 137);
            this.btnDemographics.TabIndex = 7;
            this.btnDemographics.Text = "Student          \r\nDemographics    ";
            this.btnDemographics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDemographics.UseVisualStyleBackColor = false;
            this.btnDemographics.Click += new System.EventHandler(this.btnDemographics_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Silver;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Location = new System.Drawing.Point(801, 471);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(272, 137);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "Academic     \r\nHistory       ";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Aqua;
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Location = new System.Drawing.Point(456, 680);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(272, 137);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "User       \r\nProfile     ";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 845);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDemographics);
            this.Controls.Add(this.btnLectures);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.picLogo);
            this.MaximumSize = new System.Drawing.Size(1189, 901);
            this.MinimumSize = new System.Drawing.Size(1189, 861);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMA Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnLectures;
        private System.Windows.Forms.Button btnDemographics;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfile;
    }
}