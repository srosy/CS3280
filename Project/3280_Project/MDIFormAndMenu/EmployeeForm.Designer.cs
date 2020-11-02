namespace MDIFormAndMenu
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.tbAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cbIsMarried = new System.Windows.Forms.CheckBox();
            this.rbSalaried = new System.Windows.Forms.RadioButton();
            this.rbBaseCommission = new System.Windows.Forms.RadioButton();
            this.rbTier1 = new System.Windows.Forms.RadioButton();
            this.rbTier2 = new System.Windows.Forms.RadioButton();
            this.rbTier3 = new System.Windows.Forms.RadioButton();
            this.gbEmployeeType = new System.Windows.Forms.GroupBox();
            this.rbCommission = new System.Windows.Forms.RadioButton();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommissionRate = new System.Windows.Forms.Label();
            this.tbCommissionRate = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.tbSales = new System.Windows.Forms.TextBox();
            this.btnEmployeeSubmit = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTierNumber = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbAddr2 = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbEmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.gbTierNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(24, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(27, 79);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(173, 78);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(170, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(27, 132);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(121, 20);
            this.tbSSN.TabIndex = 5;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(24, 116);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(32, 13);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN";
            // 
            // tbAddr1
            // 
            this.tbAddr1.Location = new System.Drawing.Point(27, 182);
            this.tbAddr1.Name = "tbAddr1";
            this.tbAddr1.Size = new System.Drawing.Size(121, 20);
            this.tbAddr1.TabIndex = 7;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr1.Location = new System.Drawing.Point(24, 166);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(91, 13);
            this.lblAddr1.TabIndex = 6;
            this.lblAddr1.Text = "Address Line 1";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(27, 296);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(121, 20);
            this.tbZipCode.TabIndex = 9;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(24, 280);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "Zipcode";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(170, 219);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 13);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Utah",
            "California",
            "Nevada",
            "Oregon",
            "Washington",
            "Colorado",
            "New York"});
            this.cmbState.Location = new System.Drawing.Point(173, 235);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 11;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // cbIsMarried
            // 
            this.cbIsMarried.AutoSize = true;
            this.cbIsMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsMarried.Location = new System.Drawing.Point(173, 134);
            this.cbIsMarried.Name = "cbIsMarried";
            this.cbIsMarried.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbIsMarried.Size = new System.Drawing.Size(68, 17);
            this.cbIsMarried.TabIndex = 13;
            this.cbIsMarried.Text = "Married";
            this.cbIsMarried.UseVisualStyleBackColor = true;
            this.cbIsMarried.CheckedChanged += new System.EventHandler(this.cbIsMarried_CheckedChanged);
            // 
            // rbSalaried
            // 
            this.rbSalaried.AutoSize = true;
            this.rbSalaried.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalaried.Location = new System.Drawing.Point(10, 19);
            this.rbSalaried.Name = "rbSalaried";
            this.rbSalaried.Size = new System.Drawing.Size(63, 17);
            this.rbSalaried.TabIndex = 14;
            this.rbSalaried.TabStop = true;
            this.rbSalaried.Text = "Salaried";
            this.rbSalaried.UseVisualStyleBackColor = true;
            this.rbSalaried.CheckedChanged += new System.EventHandler(this.rbSalaried_CheckedChanged);
            // 
            // rbBaseCommission
            // 
            this.rbBaseCommission.AutoSize = true;
            this.rbBaseCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaseCommission.Location = new System.Drawing.Point(183, 19);
            this.rbBaseCommission.Name = "rbBaseCommission";
            this.rbBaseCommission.Size = new System.Drawing.Size(110, 17);
            this.rbBaseCommission.TabIndex = 15;
            this.rbBaseCommission.TabStop = true;
            this.rbBaseCommission.Text = "Base+Commission";
            this.rbBaseCommission.UseVisualStyleBackColor = true;
            this.rbBaseCommission.CheckedChanged += new System.EventHandler(this.rbBaseCommission_CheckedChanged);
            // 
            // rbTier1
            // 
            this.rbTier1.AutoSize = true;
            this.rbTier1.Location = new System.Drawing.Point(10, 19);
            this.rbTier1.Name = "rbTier1";
            this.rbTier1.Size = new System.Drawing.Size(52, 17);
            this.rbTier1.TabIndex = 18;
            this.rbTier1.TabStop = true;
            this.rbTier1.Text = "Tier 1";
            this.rbTier1.UseVisualStyleBackColor = true;
            // 
            // rbTier2
            // 
            this.rbTier2.AutoSize = true;
            this.rbTier2.Location = new System.Drawing.Point(87, 19);
            this.rbTier2.Name = "rbTier2";
            this.rbTier2.Size = new System.Drawing.Size(52, 17);
            this.rbTier2.TabIndex = 19;
            this.rbTier2.TabStop = true;
            this.rbTier2.Text = "Tier 2";
            this.rbTier2.UseVisualStyleBackColor = true;
            // 
            // rbTier3
            // 
            this.rbTier3.AutoSize = true;
            this.rbTier3.Location = new System.Drawing.Point(183, 19);
            this.rbTier3.Name = "rbTier3";
            this.rbTier3.Size = new System.Drawing.Size(52, 17);
            this.rbTier3.TabIndex = 20;
            this.rbTier3.TabStop = true;
            this.rbTier3.Text = "Tier 3";
            this.rbTier3.UseVisualStyleBackColor = true;
            // 
            // gbEmployeeType
            // 
            this.gbEmployeeType.Controls.Add(this.rbBaseCommission);
            this.gbEmployeeType.Controls.Add(this.rbSalaried);
            this.gbEmployeeType.Controls.Add(this.rbCommission);
            this.gbEmployeeType.Location = new System.Drawing.Point(413, 163);
            this.gbEmployeeType.Name = "gbEmployeeType";
            this.gbEmployeeType.Size = new System.Drawing.Size(330, 50);
            this.gbEmployeeType.TabIndex = 21;
            this.gbEmployeeType.TabStop = false;
            this.gbEmployeeType.Text = "Employee Type";
            // 
            // rbCommission
            // 
            this.rbCommission.AutoSize = true;
            this.rbCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommission.Location = new System.Drawing.Point(87, 19);
            this.rbCommission.Name = "rbCommission";
            this.rbCommission.Size = new System.Drawing.Size(80, 17);
            this.rbCommission.TabIndex = 16;
            this.rbCommission.TabStop = true;
            this.rbCommission.Text = "Commission";
            this.rbCommission.UseVisualStyleBackColor = true;
            this.rbCommission.CheckedChanged += new System.EventHandler(this.rbCommission_CheckedChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(416, 293);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 22;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(415, 277);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(115, 13);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommissionRate
            // 
            this.lblCommissionRate.AutoSize = true;
            this.lblCommissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommissionRate.Location = new System.Drawing.Point(551, 277);
            this.lblCommissionRate.Name = "lblCommissionRate";
            this.lblCommissionRate.Size = new System.Drawing.Size(103, 13);
            this.lblCommissionRate.TabIndex = 25;
            this.lblCommissionRate.Text = "Commission Rate";
            // 
            // tbCommissionRate
            // 
            this.tbCommissionRate.Location = new System.Drawing.Point(552, 293);
            this.tbCommissionRate.Name = "tbCommissionRate";
            this.tbCommissionRate.Size = new System.Drawing.Size(100, 20);
            this.tbCommissionRate.TabIndex = 24;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(684, 277);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(38, 13);
            this.lblSales.TabIndex = 27;
            this.lblSales.Text = "Sales";
            // 
            // tbSales
            // 
            this.tbSales.Location = new System.Drawing.Point(685, 293);
            this.tbSales.Name = "tbSales";
            this.tbSales.Size = new System.Drawing.Size(100, 20);
            this.tbSales.TabIndex = 26;
            // 
            // btnEmployeeSubmit
            // 
            this.btnEmployeeSubmit.BackColor = System.Drawing.Color.Coral;
            this.btnEmployeeSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSubmit.Location = new System.Drawing.Point(302, 506);
            this.btnEmployeeSubmit.Name = "btnEmployeeSubmit";
            this.btnEmployeeSubmit.Size = new System.Drawing.Size(94, 32);
            this.btnEmployeeSubmit.TabIndex = 28;
            this.btnEmployeeSubmit.Text = "Submit";
            this.btnEmployeeSubmit.UseVisualStyleBackColor = false;
            this.btnEmployeeSubmit.Click += new System.EventHandler(this.btnEmployeeSubmit_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Utah",
            "California",
            "Nevada",
            "Oregon",
            "Washington",
            "Colorado",
            "New York"});
            this.cmbDepartment.Location = new System.Drawing.Point(173, 296);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 32;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(170, 280);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(72, 13);
            this.lblDepartment.TabIndex = 31;
            this.lblDepartment.Text = "Department";
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(27, 339);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(369, 150);
            this.dgEmployee.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Employee Information Form";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // gbTierNumber
            // 
            this.gbTierNumber.Controls.Add(this.rbTier3);
            this.gbTierNumber.Controls.Add(this.rbTier1);
            this.gbTierNumber.Controls.Add(this.rbTier2);
            this.gbTierNumber.Location = new System.Drawing.Point(413, 219);
            this.gbTierNumber.Name = "gbTierNumber";
            this.gbTierNumber.Size = new System.Drawing.Size(330, 49);
            this.gbTierNumber.TabIndex = 35;
            this.gbTierNumber.TabStop = false;
            this.gbTierNumber.Text = "Tier Number";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(24, 219);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 13);
            this.lblCity.TabIndex = 36;
            this.lblCity.Text = "City";
            // 
            // tbAddr2
            // 
            this.tbAddr2.Location = new System.Drawing.Point(173, 182);
            this.tbAddr2.Name = "tbAddr2";
            this.tbAddr2.Size = new System.Drawing.Size(121, 20);
            this.tbAddr2.TabIndex = 39;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr2.Location = new System.Drawing.Point(170, 166);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(91, 13);
            this.lblAddr2.TabIndex = 38;
            this.lblAddr2.Text = "Address Line 2";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(27, 235);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(121, 20);
            this.tbCity.TabIndex = 40;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(415, 106);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(61, 13);
            this.lblJoinDate.TabIndex = 44;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(412, 59);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 13);
            this.lblDOB.TabIndex = 42;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(506, 59);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 45;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Location = new System.Drawing.Point(506, 106);
            this.dtpJoinDate.MaxDate = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(200, 20);
            this.dtpJoinDate.TabIndex = 46;
            this.dtpJoinDate.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // tbOutput
            // 
            this.tbOutput.Enabled = false;
            this.tbOutput.Location = new System.Drawing.Point(418, 339);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(358, 150);
            this.tbOutput.TabIndex = 47;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(413, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 32);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 565);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddr2);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.gbTierNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnEmployeeSubmit);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.tbSales);
            this.Controls.Add(this.lblCommissionRate);
            this.Controls.Add(this.tbCommissionRate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.gbEmployeeType);
            this.Controls.Add(this.cbIsMarried);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.tbAddr1);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.tbSSN);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEmployeeType.ResumeLayout(false);
            this.gbEmployeeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.gbTierNumber.ResumeLayout(false);
            this.gbTierNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox tbAddr1;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox cbIsMarried;
        private System.Windows.Forms.RadioButton rbSalaried;
        private System.Windows.Forms.RadioButton rbBaseCommission;
        private System.Windows.Forms.RadioButton rbTier1;
        private System.Windows.Forms.RadioButton rbTier2;
        private System.Windows.Forms.RadioButton rbTier3;
        private System.Windows.Forms.GroupBox gbEmployeeType;
        private System.Windows.Forms.RadioButton rbCommission;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommissionRate;
        private System.Windows.Forms.TextBox tbCommissionRate;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox tbSales;
        private System.Windows.Forms.Button btnEmployeeSubmit;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox gbTierNumber;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddr2;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnReset;
    }
}

