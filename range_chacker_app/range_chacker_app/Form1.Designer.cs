namespace range_chacker_app
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldecisioon = new System.Windows.Forms.Label();
            this.txtrange = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Range Checker Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter an integer iin the range of 1 to 10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Range Decision";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldecisioon
            // 
            this.lbldecisioon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldecisioon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecisioon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldecisioon.Location = new System.Drawing.Point(84, 198);
            this.lbldecisioon.Name = "lbldecisioon";
            this.lbldecisioon.Size = new System.Drawing.Size(399, 60);
            this.lbldecisioon.TabIndex = 5;
            this.lbldecisioon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrange
            // 
            this.txtrange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrange.Location = new System.Drawing.Point(89, 98);
            this.txtrange.Name = "txtrange";
            this.txtrange.Size = new System.Drawing.Size(412, 35);
            this.txtrange.TabIndex = 1;
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(107, 311);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(127, 114);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "&Check Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(279, 311);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 49);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(279, 376);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 49);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Location = new System.Drawing.Point(89, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtrange);
            this.Controls.Add(this.lbldecisioon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldecisioon;
        private System.Windows.Forms.TextBox txtrange;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

