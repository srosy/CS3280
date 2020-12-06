namespace MDIFormAndMenu
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentLocation = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbDepartmentLocation = new System.Windows.Forms.TextBox();
            this.dgDepartments = new System.Windows.Forms.DataGridView();
            this.btnDepartmentSubmit = new System.Windows.Forms.Button();
            this.tbContactPersonPhone = new System.Windows.Forms.TextBox();
            this.tbContactPersonName = new System.Windows.Forms.TextBox();
            this.lblContactPersonPhoneNumber = new System.Windows.Forms.Label();
            this.lblContactPersonName = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Department Information Form";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(24, 68);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(39, 13);
            this.lblDepartmentName.TabIndex = 36;
            this.lblDepartmentName.Text = "Name";
            // 
            // lblDepartmentLocation
            // 
            this.lblDepartmentLocation.AutoSize = true;
            this.lblDepartmentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLocation.Location = new System.Drawing.Point(24, 118);
            this.lblDepartmentLocation.Name = "lblDepartmentLocation";
            this.lblDepartmentLocation.Size = new System.Drawing.Size(56, 13);
            this.lblDepartmentLocation.TabIndex = 37;
            this.lblDepartmentLocation.Text = "Location";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(27, 85);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(142, 20);
            this.tbDepartmentName.TabIndex = 38;
            // 
            // tbDepartmentLocation
            // 
            this.tbDepartmentLocation.Location = new System.Drawing.Point(27, 134);
            this.tbDepartmentLocation.Name = "tbDepartmentLocation";
            this.tbDepartmentLocation.Size = new System.Drawing.Size(142, 20);
            this.tbDepartmentLocation.TabIndex = 39;
            // 
            // dgDepartments
            // 
            this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartments.Location = new System.Drawing.Point(27, 176);
            this.dgDepartments.Name = "dgDepartments";
            this.dgDepartments.Size = new System.Drawing.Size(749, 150);
            this.dgDepartments.TabIndex = 40;
            // 
            // btnDepartmentSubmit
            // 
            this.btnDepartmentSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDepartmentSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentSubmit.Location = new System.Drawing.Point(348, 505);
            this.btnDepartmentSubmit.Name = "btnDepartmentSubmit";
            this.btnDepartmentSubmit.Size = new System.Drawing.Size(94, 32);
            this.btnDepartmentSubmit.TabIndex = 42;
            this.btnDepartmentSubmit.Text = "Submit";
            this.btnDepartmentSubmit.UseVisualStyleBackColor = false;
            this.btnDepartmentSubmit.Click += new System.EventHandler(this.btnDepartmentSubmit_Click);
            // 
            // tbContactPersonPhone
            // 
            this.tbContactPersonPhone.Location = new System.Drawing.Point(202, 134);
            this.tbContactPersonPhone.Name = "tbContactPersonPhone";
            this.tbContactPersonPhone.Size = new System.Drawing.Size(150, 20);
            this.tbContactPersonPhone.TabIndex = 46;
            // 
            // tbContactPersonName
            // 
            this.tbContactPersonName.Location = new System.Drawing.Point(202, 85);
            this.tbContactPersonName.Name = "tbContactPersonName";
            this.tbContactPersonName.Size = new System.Drawing.Size(150, 20);
            this.tbContactPersonName.TabIndex = 45;
            // 
            // lblContactPersonPhoneNumber
            // 
            this.lblContactPersonPhoneNumber.AutoSize = true;
            this.lblContactPersonPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPersonPhoneNumber.Location = new System.Drawing.Point(199, 118);
            this.lblContactPersonPhoneNumber.Name = "lblContactPersonPhoneNumber";
            this.lblContactPersonPhoneNumber.Size = new System.Drawing.Size(181, 13);
            this.lblContactPersonPhoneNumber.TabIndex = 44;
            this.lblContactPersonPhoneNumber.Text = "Contact Person Phone Number";
            // 
            // lblContactPersonName
            // 
            this.lblContactPersonName.AutoSize = true;
            this.lblContactPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPersonName.Location = new System.Drawing.Point(199, 68);
            this.lblContactPersonName.Name = "lblContactPersonName";
            this.lblContactPersonName.Size = new System.Drawing.Size(130, 13);
            this.lblContactPersonName.TabIndex = 43;
            this.lblContactPersonName.Text = "Contact Person Name";
            // 
            // tbOutput
            // 
            this.tbOutput.Enabled = false;
            this.tbOutput.Location = new System.Drawing.Point(27, 332);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(749, 150);
            this.tbOutput.TabIndex = 48;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(686, 19);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(90, 20);
            this.tbFilter.TabIndex = 49;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchIcon.Image")));
            this.pbSearchIcon.Location = new System.Drawing.Point(658, 16);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(22, 23);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchIcon.TabIndex = 50;
            this.pbSearchIcon.TabStop = false;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 569);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbContactPersonPhone);
            this.Controls.Add(this.tbContactPersonName);
            this.Controls.Add(this.lblContactPersonPhoneNumber);
            this.Controls.Add(this.lblContactPersonName);
            this.Controls.Add(this.btnDepartmentSubmit);
            this.Controls.Add(this.dgDepartments);
            this.Controls.Add(this.tbDepartmentLocation);
            this.Controls.Add(this.tbDepartmentName);
            this.Controls.Add(this.lblDepartmentLocation);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentLocation;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.TextBox tbDepartmentLocation;
        private System.Windows.Forms.DataGridView dgDepartments;
        private System.Windows.Forms.Button btnDepartmentSubmit;
        private System.Windows.Forms.TextBox tbContactPersonPhone;
        private System.Windows.Forms.TextBox tbContactPersonName;
        private System.Windows.Forms.Label lblContactPersonPhoneNumber;
        private System.Windows.Forms.Label lblContactPersonName;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbFilter;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pbSearchIcon;
    }
}