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
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnLectures = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(28, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 80);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGrades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrades.BackgroundImage")));
            this.btnGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.Location = new System.Drawing.Point(430, 134);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(181, 89);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "Grade   \r\nSheet   ";
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
            this.btnAttendance.Location = new System.Drawing.Point(28, 253);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(181, 89);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance   \r\nSheet   ";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click_1);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedule.BackgroundImage")));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.Location = new System.Drawing.Point(29, 134);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(181, 89);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule   \r\nSheet   ";
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
            this.btnLectures.Location = new System.Drawing.Point(228, 134);
            this.btnLectures.Margin = new System.Windows.Forms.Padding(2);
            this.btnLectures.Name = "btnLectures";
            this.btnLectures.Size = new System.Drawing.Size(181, 89);
            this.btnLectures.TabIndex = 6;
            this.btnLectures.Text = "Lecture   \r\nPreparation   ";
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
            this.btnDemographics.Location = new System.Drawing.Point(430, 253);
            this.btnDemographics.Margin = new System.Windows.Forms.Padding(2);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(181, 89);
            this.btnDemographics.TabIndex = 7;
            this.btnDemographics.Text = "Student   \r\nDemographics   ";
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
            this.btnHistory.Location = new System.Drawing.Point(228, 253);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(181, 89);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "Academic   \r\nHistory   ";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unsung University";
            // 
            // pctSettings
            // 
            this.pctSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings.Image")));
            this.pctSettings.Location = new System.Drawing.Point(581, 30);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(30, 30);
            this.pctSettings.TabIndex = 11;
            this.pctSettings.TabStop = false;
            this.pctSettings.Click += new System.EventHandler(this.pctSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(536, 87);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(638, 363);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pctSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDemographics);
            this.Controls.Add(this.btnLectures);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMA Main Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnLectures;
        private System.Windows.Forms.Button btnDemographics;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.Button btnLogout;
    }
}