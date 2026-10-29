namespace today_assignment
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lststudentinfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumberofcourse = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstcourseinfo = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(307, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(272, 38);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "student name";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(441, 458);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(138, 57);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "&calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(307, 155);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(272, 38);
            this.txtage.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(307, 99);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(272, 38);
            this.txtid.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(635, 458);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 57);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "c&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lststudentinfo
            // 
            this.lststudentinfo.FormattingEnabled = true;
            this.lststudentinfo.ItemHeight = 20;
            this.lststudentinfo.Location = new System.Drawing.Point(609, 56);
            this.lststudentinfo.Name = "lststudentinfo";
            this.lststudentinfo.Size = new System.Drawing.Size(342, 324);
            this.lststudentinfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "student age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "student id";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(833, 458);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(138, 57);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "e&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtcoursename
            // 
            this.txtcoursename.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoursename.Location = new System.Drawing.Point(307, 240);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(272, 38);
            this.txtcoursename.TabIndex = 3;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(307, 288);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(272, 38);
            this.txtprice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "course name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "course price($)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtnumberofcourse
            // 
            this.txtnumberofcourse.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofcourse.Location = new System.Drawing.Point(307, 342);
            this.txtnumberofcourse.Name = "txtnumberofcourse";
            this.txtnumberofcourse.Size = new System.Drawing.Size(272, 38);
            this.txtnumberofcourse.TabIndex = 5;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Vani", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(103, 345);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(176, 32);
            this.number.TabIndex = 1;
            this.number.Text = "number of course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "courses info";
            // 
            // lstcourseinfo
            // 
            this.lstcourseinfo.FormattingEnabled = true;
            this.lstcourseinfo.ItemHeight = 20;
            this.lstcourseinfo.Location = new System.Drawing.Point(76, 407);
            this.lstcourseinfo.Name = "lstcourseinfo";
            this.lstcourseinfo.Size = new System.Drawing.Size(257, 164);
            this.lstcourseinfo.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(59, 593);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 52);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "&ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(223, 593);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(110, 46);
            this.btnremove.TabIndex = 6;
            this.btnremove.Text = "&REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 657);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lstcourseinfo);
            this.Controls.Add(this.lststudentinfo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtnumberofcourse);
            this.Controls.Add(this.txtcoursename);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox lststudentinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumberofcourse;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstcourseinfo;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
    }
}

