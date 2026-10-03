namespace test_score_avg
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
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblavg = new System.Windows.Forms.Label();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER THREE TEST SCORE";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Score 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtscore1
            // 
            this.txtscore1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore1.Location = new System.Drawing.Point(277, 60);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(454, 35);
            this.txtscore1.TabIndex = 0;
            this.txtscore1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Test Score 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Test Score 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "AVERAGE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblavg
            // 
            this.lblavg.BackColor = System.Drawing.Color.Silver;
            this.lblavg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavg.Location = new System.Drawing.Point(327, 260);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(308, 54);
            this.lblavg.TabIndex = 1;
            this.lblavg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtscore2
            // 
            this.txtscore2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore2.Location = new System.Drawing.Point(277, 114);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(454, 35);
            this.txtscore2.TabIndex = 1;
            this.txtscore2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtscore3
            // 
            this.txtscore3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore3.Location = new System.Drawing.Point(277, 172);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(454, 35);
            this.txtscore3.TabIndex = 3;
            this.txtscore3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(106, 343);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(155, 82);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "&Calculate Avg";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(297, 343);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 39);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(297, 388);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 39);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.lblavg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

