namespace payrol_with_overtime
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
            this.txthourworked = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthourpayrate = new System.Windows.Forms.TextBox();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hours Worked:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthourworked
            // 
            this.txthourworked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourworked.Location = new System.Drawing.Point(295, 128);
            this.txthourworked.Name = "txthourworked";
            this.txthourworked.Size = new System.Drawing.Size(367, 35);
            this.txthourworked.TabIndex = 0;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(197, 317);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(136, 69);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "&Calculat Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gross Pay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hourly Pay Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthourpayrate
            // 
            this.txthourpayrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourpayrate.Location = new System.Drawing.Point(295, 180);
            this.txthourpayrate.Name = "txthourpayrate";
            this.txthourpayrate.Size = new System.Drawing.Size(367, 35);
            this.txthourpayrate.TabIndex = 1;
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblgrosspay.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(290, 234);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(372, 46);
            this.lblgrosspay.TabIndex = 8;
            this.lblgrosspay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(375, 317);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(136, 69);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(554, 317);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(136, 69);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 498);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txthourpayrate);
            this.Controls.Add(this.txthourworked);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthourworked;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthourpayrate;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

