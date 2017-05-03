namespace Prototype
{
    partial class StudentDemographics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDemographics));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.MaskedTextBox();
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.pctLogo.Location = new System.Drawing.Point(28, 30);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(95, 80);
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(34, 129);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(140, 19);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID Number";
            // 
            // txtStudent
            // 
            this.txtStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent.Location = new System.Drawing.Point(180, 128);
            this.txtStudent.Mask = "000000";
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(90, 22);
            this.txtStudent.TabIndex = 0;
            this.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
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
            this.grpStudent.Location = new System.Drawing.Point(28, 165);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(446, 268);
            this.grpStudent.TabIndex = 5;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Demographics";
            // 
            // txtDeans
            // 
            this.txtDeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeans.Location = new System.Drawing.Point(234, 236);
            this.txtDeans.Name = "txtDeans";
            this.txtDeans.ReadOnly = true;
            this.txtDeans.Size = new System.Drawing.Size(65, 22);
            this.txtDeans.TabIndex = 27;
            this.txtDeans.TabStop = false;
            // 
            // lblDeans
            // 
            this.lblDeans.AutoSize = true;
            this.lblDeans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeans.Location = new System.Drawing.Point(145, 237);
            this.lblDeans.Name = "lblDeans";
            this.lblDeans.Size = new System.Drawing.Size(86, 19);
            this.lblDeans.TabIndex = 26;
            this.lblDeans.Text = "Dean\'s List";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(305, 20);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(129, 22);
            this.txtFirst.TabIndex = 25;
            this.txtFirst.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "First";
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(95, 20);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(136, 22);
            this.txtLast.TabIndex = 23;
            this.txtLast.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name";
            // 
            // txtCredits
            // 
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(234, 205);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.ReadOnly = true;
            this.txtCredits.Size = new System.Drawing.Size(65, 22);
            this.txtCredits.TabIndex = 19;
            this.txtCredits.TabStop = false;
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(50, 236);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(89, 22);
            this.txtGPA.TabIndex = 18;
            this.txtGPA.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(50, 205);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(89, 22);
            this.txtYear.TabIndex = 17;
            this.txtYear.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.btnFemale);
            this.grpGender.Controls.Add(this.btnMale);
            this.grpGender.Location = new System.Drawing.Point(316, 183);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(118, 73);
            this.grpGender.TabIndex = 13;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // btnFemale
            // 
            this.btnFemale.AutoCheck = false;
            this.btnFemale.AutoSize = true;
            this.btnFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemale.Location = new System.Drawing.Point(6, 44);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(76, 23);
            this.btnFemale.TabIndex = 1;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoCheck = false;
            this.btnMale.AutoSize = true;
            this.btnMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMale.Location = new System.Drawing.Point(6, 19);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(63, 23);
            this.btnMale.TabIndex = 0;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // txtZip
            // 
            this.txtZip.AllowPromptAsInput = false;
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(349, 125);
            this.txtZip.Mask = "00000";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(85, 22);
            this.txtZip.TabIndex = 7;
            this.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(301, 124);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(30, 19);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(95, 124);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(182, 24);
            this.cmbState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(6, 124);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 19);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // cmbCountry
            // 
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(95, 151);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(182, 24);
            this.cmbCountry.TabIndex = 8;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(6, 150);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 19);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(95, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 22);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 97);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 19);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(95, 72);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(339, 22);
            this.txtAddress2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(6, 45);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(76, 19);
            this.lblAddress1.TabIndex = 1;
            this.lblAddress1.Text = "Address 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(95, 46);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(339, 22);
            this.txtAddress1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(437, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(534, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(634, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(6, 19);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 243);
            this.txtNotes.TabIndex = 9;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Location = new System.Drawing.Point(503, 165);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(212, 268);
            this.grpNotes.TabIndex = 13;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Student Notes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.Location = new System.Drawing.Point(129, 84);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(181, 26);
            this.lblUniversity.TabIndex = 15;
            this.lblUniversity.Text = "Unsung University";
            // 
            // btnViewx
            // 
            this.btnView.Location = new System.Drawing.Point(306, 128);
            this.btnView.Name = "btnViewx";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnViewx_Click);
            // 
            // btnEditx
            // 
            this.btnEdit.Location = new System.Drawing.Point(399, 128);
            this.btnEdit.Name = "btnEditx";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEditx_Click);
            // 
            // StudentDemographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(736, 497);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentDemographics";
            this.Text = "IMA Student Demographics";
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
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
    }
}