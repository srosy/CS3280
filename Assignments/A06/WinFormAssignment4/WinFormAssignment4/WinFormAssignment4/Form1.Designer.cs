namespace WinFormAssignment4
{
    partial class Form1
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
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.lblCheckOrUnchecked = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkTest
            // 
            this.chkTest.AutoSize = true;
            this.chkTest.Location = new System.Drawing.Point(208, 101);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(102, 17);
            this.chkTest.TabIndex = 0;
            this.chkTest.Text = "Test Check Box";
            this.chkTest.UseVisualStyleBackColor = true;
            // 
            // lblCheckOrUnchecked
            // 
            this.lblCheckOrUnchecked.AutoSize = true;
            this.lblCheckOrUnchecked.Location = new System.Drawing.Point(208, 140);
            this.lblCheckOrUnchecked.Name = "lblCheckOrUnchecked";
            this.lblCheckOrUnchecked.Size = new System.Drawing.Size(114, 13);
            this.lblCheckOrUnchecked.TabIndex = 1;
            this.lblCheckOrUnchecked.Text = "Unchecked Right now";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(208, 171);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Click Me!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblCheckOrUnchecked);
            this.Controls.Add(this.chkTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.Label lblCheckOrUnchecked;
        private System.Windows.Forms.Button btnTest;
    }
}

