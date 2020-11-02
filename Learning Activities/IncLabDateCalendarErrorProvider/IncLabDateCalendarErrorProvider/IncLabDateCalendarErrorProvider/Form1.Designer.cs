namespace IncLabDateCalendarErrorProvider
{
    partial class DateCalendarError
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
            this.bDayPicker = new System.Windows.Forms.DateTimePicker();
            this.dtClassPicker = new System.Windows.Forms.MonthCalendar();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBirthdayCheck = new System.Windows.Forms.Button();
            this.btnValidateSSN = new System.Windows.Forms.Button();
            this.validation = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.validation)).BeginInit();
            this.SuspendLayout();
            // 
            // bDayPicker
            // 
            this.bDayPicker.Location = new System.Drawing.Point(159, 28);
            this.bDayPicker.Name = "bDayPicker";
            this.bDayPicker.Size = new System.Drawing.Size(200, 20);
            this.bDayPicker.TabIndex = 0;
            // 
            // dtClassPicker
            // 
            this.dtClassPicker.Location = new System.Drawing.Point(159, 86);
            this.dtClassPicker.Name = "dtClassPicker";
            this.dtClassPicker.TabIndex = 1;
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(159, 54);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(100, 20);
            this.tbSSN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSN";
            // 
            // btnBirthdayCheck
            // 
            this.btnBirthdayCheck.Location = new System.Drawing.Point(51, 294);
            this.btnBirthdayCheck.Name = "btnBirthdayCheck";
            this.btnBirthdayCheck.Size = new System.Drawing.Size(75, 23);
            this.btnBirthdayCheck.TabIndex = 4;
            this.btnBirthdayCheck.Text = "IsMyBirthday";
            this.btnBirthdayCheck.UseVisualStyleBackColor = true;
            this.btnBirthdayCheck.Click += new System.EventHandler(this.btnBirthdayCheck_Click);
            // 
            // btnValidateSSN
            // 
            this.btnValidateSSN.Location = new System.Drawing.Point(184, 294);
            this.btnValidateSSN.Name = "btnValidateSSN";
            this.btnValidateSSN.Size = new System.Drawing.Size(75, 23);
            this.btnValidateSSN.TabIndex = 5;
            this.btnValidateSSN.Text = "IsValidSSN";
            this.btnValidateSSN.UseVisualStyleBackColor = true;
            this.btnValidateSSN.Click += new System.EventHandler(this.btnValidateSSN_Click);
            // 
            // validation
            // 
            this.validation.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(311, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CS 3550 Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Your Birthday";
            // 
            // DateCalendarError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidateSSN);
            this.Controls.Add(this.btnBirthdayCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSSN);
            this.Controls.Add(this.dtClassPicker);
            this.Controls.Add(this.bDayPicker);
            this.Name = "DateCalendarError";
            this.Text = "DateCalendarError";
            ((System.ComponentModel.ISupportInitialize)(this.validation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bDayPicker;
        private System.Windows.Forms.MonthCalendar dtClassPicker;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBirthdayCheck;
        private System.Windows.Forms.Button btnValidateSSN;
        private System.Windows.Forms.ErrorProvider validation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

