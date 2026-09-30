namespace hotel_room_booking_calculate
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.txtnmbrnight = new System.Windows.Forms.TextBox();
            this.txtpricenight = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblservice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSrviceTex = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter gues name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter room type";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter number of night";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter price per night";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(459, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(297, 30);
            this.txtname.TabIndex = 1;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomtype.Location = new System.Drawing.Point(459, 84);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(297, 30);
            this.txtroomtype.TabIndex = 1;
            // 
            // txtnmbrnight
            // 
            this.txtnmbrnight.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmbrnight.Location = new System.Drawing.Point(459, 135);
            this.txtnmbrnight.Name = "txtnmbrnight";
            this.txtnmbrnight.Size = new System.Drawing.Size(297, 30);
            this.txtnmbrnight.TabIndex = 1;
            // 
            // txtpricenight
            // 
            this.txtpricenight.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpricenight.Location = new System.Drawing.Point(459, 185);
            this.txtpricenight.Name = "txtpricenight";
            this.txtpricenight.Size = new System.Drawing.Size(297, 30);
            this.txtpricenight.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(462, 226);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(239, 54);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "calculate booking";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblservice
            // 
            this.lblservice.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblservice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice.Location = new System.Drawing.Point(75, 26);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(194, 33);
            this.lblservice.TabIndex = 3;
            this.lblservice.Text = "sevice tex(10%   :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Discount amount(5%   :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total amount     :";
            // 
            // lblSrviceTex
            // 
            this.lblSrviceTex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSrviceTex.Location = new System.Drawing.Point(419, 312);
            this.lblSrviceTex.Name = "lblSrviceTex";
            this.lblSrviceTex.Size = new System.Drawing.Size(294, 31);
            this.lblSrviceTex.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.Location = new System.Drawing.Point(419, 366);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(294, 31);
            this.lblDiscount.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmount.Location = new System.Drawing.Point(419, 415);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(294, 31);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox2.Controls.Add(this.lblservice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(145, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 214);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(942, 522);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSrviceTex);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpricenight);
            this.Controls.Add(this.txtnmbrnight);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.TextBox txtnmbrnight;
        private System.Windows.Forms.TextBox txtpricenight;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSrviceTex;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

