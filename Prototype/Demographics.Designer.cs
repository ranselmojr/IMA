namespace Prototype
{
    partial class Demographics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demographics));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.MaskedTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.txtDeans = new System.Windows.Forms.TextBox();
            this.lblDeans = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.txtZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUniversity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpStudent.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(74, 58);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 137);
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(68, 248);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(193, 25);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID Number";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(316, 242);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStudent.Mask = "000000";
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(176, 31);
            this.txtStudent.TabIndex = 0;
            this.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(592, 238);
            this.btnView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 44);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.txtDeans);
            this.grpStudent.Controls.Add(this.lblDeans);
            this.grpStudent.Controls.Add(this.txtFirst);
            this.grpStudent.Controls.Add(this.label6);
            this.grpStudent.Controls.Add(this.txtLast);
            this.grpStudent.Controls.Add(this.label5);
            this.grpStudent.Controls.Add(this.txtCredits);
            this.grpStudent.Controls.Add(this.txtGPA);
            this.grpStudent.Controls.Add(this.txtYear);
            this.grpStudent.Controls.Add(this.label4);
            this.grpStudent.Controls.Add(this.label3);
            this.grpStudent.Controls.Add(this.label2);
            this.grpStudent.Controls.Add(this.grpGender);
            this.grpStudent.Controls.Add(this.txtZip);
            this.grpStudent.Controls.Add(this.lblZip);
            this.grpStudent.Controls.Add(this.cmbState);
            this.grpStudent.Controls.Add(this.lblState);
            this.grpStudent.Controls.Add(this.cmbCountry);
            this.grpStudent.Controls.Add(this.lblCountry);
            this.grpStudent.Controls.Add(this.txtCity);
            this.grpStudent.Controls.Add(this.lblCity);
            this.grpStudent.Controls.Add(this.txtAddress2);
            this.grpStudent.Controls.Add(this.label1);
            this.grpStudent.Controls.Add(this.lblAddress1);
            this.grpStudent.Controls.Add(this.txtAddress1);
            this.grpStudent.Location = new System.Drawing.Point(56, 317);
            this.grpStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpStudent.Size = new System.Drawing.Size(892, 515);
            this.grpStudent.TabIndex = 5;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Demographics";
            // 
            // txtDeans
            // 
            this.txtDeans.Location = new System.Drawing.Point(448, 454);
            this.txtDeans.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDeans.Name = "txtDeans";
            this.txtDeans.ReadOnly = true;
            this.txtDeans.Size = new System.Drawing.Size(98, 31);
            this.txtDeans.TabIndex = 27;
            this.txtDeans.TabStop = false;
            // 
            // lblDeans
            // 
            this.lblDeans.AutoSize = true;
            this.lblDeans.Location = new System.Drawing.Point(304, 460);
            this.lblDeans.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeans.Name = "lblDeans";
            this.lblDeans.Size = new System.Drawing.Size(118, 25);
            this.lblDeans.TabIndex = 26;
            this.lblDeans.Text = "Dean\'s List";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(610, 38);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(254, 31);
            this.txtFirst.TabIndex = 25;
            this.txtFirst.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "First Name";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(186, 38);
            this.txtLast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(268, 31);
            this.txtLast.TabIndex = 23;
            this.txtLast.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(400, 394);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.ReadOnly = true;
            this.txtCredits.Size = new System.Drawing.Size(146, 31);
            this.txtCredits.TabIndex = 19;
            this.txtCredits.TabStop = false;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(100, 454);
            this.txtGPA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(160, 31);
            this.txtGPA.TabIndex = 18;
            this.txtGPA.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 394);
            this.txtYear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(160, 31);
            this.txtYear.TabIndex = 17;
            this.txtYear.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.btnFemale);
            this.grpGender.Controls.Add(this.btnMale);
            this.grpGender.Location = new System.Drawing.Point(598, 379);
            this.grpGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Name = "grpGender";
            this.grpGender.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Size = new System.Drawing.Size(270, 85);
            this.grpGender.TabIndex = 13;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // btnFemale
            // 
            this.btnFemale.AutoCheck = false;
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(140, 37);
            this.btnFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(114, 29);
            this.btnFemale.TabIndex = 1;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoCheck = false;
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(12, 37);
            this.btnMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(90, 29);
            this.btnMale.TabIndex = 0;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // txtZip
            // 
            this.txtZip.AllowPromptAsInput = false;
            this.txtZip.Location = new System.Drawing.Point(698, 233);
            this.txtZip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtZip.Mask = "00000";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(166, 31);
            this.txtZip.TabIndex = 7;
            this.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(586, 238);
            this.lblZip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(99, 25);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip Code";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(186, 233);
            this.cmbState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(360, 33);
            this.cmbState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 238);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 25);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(186, 285);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(360, 33);
            this.cmbCountry.TabIndex = 8;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 290);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 25);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(186, 183);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(360, 31);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 188);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 25);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(186, 133);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(678, 31);
            this.txtAddress2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(12, 94);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(109, 25);
            this.lblAddress1.TabIndex = 1;
            this.lblAddress1.Text = "Address 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(186, 88);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(678, 31);
            this.txtAddress1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(774, 238);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 869);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(504, 869);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(774, 869);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 37);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(396, 464);
            this.txtNotes.TabIndex = 9;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Location = new System.Drawing.Point(1006, 317);
            this.grpNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpNotes.Size = new System.Drawing.Size(424, 515);
            this.grpNotes.TabIndex = 13;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Student Notes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1488, 44);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.Location = new System.Drawing.Point(307, 144);
            this.lblUniversity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(353, 51);
            this.lblUniversity.TabIndex = 15;
            this.lblUniversity.Text = "Unsung University";
            // 
            // Demographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 994);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Demographics";
            this.Text = "Student Demographics";
            this.Load += new System.EventHandler(this.Demographics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.MaskedTextBox txtStudent;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.MaskedTextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDeans;
        private System.Windows.Forms.Label lblDeans;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblUniversity;
    }
}