namespace A6_Winforms_Delegates
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.rbSquareRoot = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbCube = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter positive value";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(118, 6);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // rbSquareRoot
            // 
            this.rbSquareRoot.AutoSize = true;
            this.rbSquareRoot.Location = new System.Drawing.Point(15, 54);
            this.rbSquareRoot.Name = "rbSquareRoot";
            this.rbSquareRoot.Size = new System.Drawing.Size(80, 17);
            this.rbSquareRoot.TabIndex = 2;
            this.rbSquareRoot.TabStop = true;
            this.rbSquareRoot.Text = "Square root";
            this.rbSquareRoot.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(15, 77);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 3;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbCube
            // 
            this.rbCube.AutoSize = true;
            this.rbCube.Location = new System.Drawing.Point(15, 100);
            this.rbCube.Name = "rbCube";
            this.rbCube.Size = new System.Drawing.Size(50, 17);
            this.rbCube.TabIndex = 4;
            this.rbCube.TabStop = true;
            this.rbCube.Text = "Cube";
            this.rbCube.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(15, 132);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 180);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.rbCube);
            this.Controls.Add(this.rbSquare);
            this.Controls.Add(this.rbSquareRoot);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.RadioButton rbSquareRoot;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbCube;
        private System.Windows.Forms.Button btnCompute;
    }
}

