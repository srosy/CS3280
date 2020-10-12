namespace LMS_WinForm
{
    partial class formSLS
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
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.cbClone = new System.Windows.Forms.CheckBox();
            this.tbCloneQuantity = new System.Windows.Forms.TextBox();
            this.lblCloneQuantity = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFormInstructions = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLibraryItemInfo = new System.Windows.Forms.Label();
            this.tbLibraryItemInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Items.AddRange(new object[] {
            "- select -",
            "Book",
            "Magazine",
            "Journal"});
            this.cmbItemType.Location = new System.Drawing.Point(214, 42);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(177, 21);
            this.cmbItemType.TabIndex = 0;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.CmbItemType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(231, 22);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(135, 17);
            this.lblItemType.TabIndex = 1;
            this.lblItemType.Text = "Library Item Type";
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(15, 96);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(578, 296);
            this.pnl.TabIndex = 2;
            // 
            // cbClone
            // 
            this.cbClone.AutoSize = true;
            this.cbClone.Location = new System.Drawing.Point(540, 23);
            this.cbClone.Name = "cbClone";
            this.cbClone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbClone.Size = new System.Drawing.Size(53, 17);
            this.cbClone.TabIndex = 3;
            this.cbClone.Text = "Clone";
            this.cbClone.UseVisualStyleBackColor = true;
            this.cbClone.CheckedChanged += new System.EventHandler(this.cbClone_CheckedChanged);
            // 
            // tbCloneQuantity
            // 
            this.tbCloneQuantity.Location = new System.Drawing.Point(559, 46);
            this.tbCloneQuantity.Name = "tbCloneQuantity";
            this.tbCloneQuantity.Size = new System.Drawing.Size(34, 20);
            this.tbCloneQuantity.TabIndex = 4;
            this.tbCloneQuantity.Visible = false;
            // 
            // lblCloneQuantity
            // 
            this.lblCloneQuantity.AutoSize = true;
            this.lblCloneQuantity.Location = new System.Drawing.Point(504, 49);
            this.lblCloneQuantity.Name = "lblCloneQuantity";
            this.lblCloneQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblCloneQuantity.TabIndex = 5;
            this.lblCloneQuantity.Text = "Quantity:";
            this.lblCloneQuantity.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(316, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFormInstructions
            // 
            this.lblFormInstructions.AutoSize = true;
            this.lblFormInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblFormInstructions.Location = new System.Drawing.Point(231, 80);
            this.lblFormInstructions.Name = "lblFormInstructions";
            this.lblFormInstructions.Size = new System.Drawing.Size(144, 13);
            this.lblFormInstructions.TabIndex = 7;
            this.lblFormInstructions.Text = "Please fill out the form below.";
            this.lblFormInstructions.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 414);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLibraryItemInfo
            // 
            this.lblLibraryItemInfo.AutoSize = true;
            this.lblLibraryItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryItemInfo.Location = new System.Drawing.Point(211, 467);
            this.lblLibraryItemInfo.Name = "lblLibraryItemInfo";
            this.lblLibraryItemInfo.Size = new System.Drawing.Size(180, 17);
            this.lblLibraryItemInfo.TabIndex = 9;
            this.lblLibraryItemInfo.Text = "Library Item Information";
            // 
            // tbLibraryItemInfo
            // 
            this.tbLibraryItemInfo.BackColor = System.Drawing.Color.White;
            this.tbLibraryItemInfo.Location = new System.Drawing.Point(118, 497);
            this.tbLibraryItemInfo.Multiline = true;
            this.tbLibraryItemInfo.Name = "tbLibraryItemInfo";
            this.tbLibraryItemInfo.ReadOnly = true;
            this.tbLibraryItemInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLibraryItemInfo.Size = new System.Drawing.Size(365, 83);
            this.tbLibraryItemInfo.TabIndex = 10;
            // 
            // formSLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 603);
            this.Controls.Add(this.tbLibraryItemInfo);
            this.Controls.Add(this.lblLibraryItemInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFormInstructions);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCloneQuantity);
            this.Controls.Add(this.tbCloneQuantity);
            this.Controls.Add(this.cbClone);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.cmbItemType);
            this.Name = "formSLS";
            this.Text = "Simple Library System Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.CheckBox cbClone;
        private System.Windows.Forms.TextBox tbCloneQuantity;
        private System.Windows.Forms.Label lblCloneQuantity;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFormInstructions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLibraryItemInfo;
        private System.Windows.Forms.TextBox tbLibraryItemInfo;
    }
}

