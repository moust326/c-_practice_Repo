namespace files_assignment1
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
            this.btnreadalllines = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_createfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_readfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreadalllines
            // 
            this.btnreadalllines.BackColor = System.Drawing.Color.Yellow;
            this.btnreadalllines.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadalllines.Location = new System.Drawing.Point(21, 44);
            this.btnreadalllines.Name = "btnreadalllines";
            this.btnreadalllines.Size = new System.Drawing.Size(508, 59);
            this.btnreadalllines.TabIndex = 0;
            this.btnreadalllines.Text = "READ ALL LINES";
            this.btnreadalllines.UseVisualStyleBackColor = false;
            this.btnreadalllines.Click += new System.EventHandler(this.btnreadalllines_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndeletefile.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefile.Location = new System.Drawing.Point(21, 235);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(508, 59);
            this.btndeletefile.TabIndex = 0;
            this.btndeletefile.Text = "DELATE THE FILE";
            this.btndeletefile.UseVisualStyleBackColor = false;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndeleteitem.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitem.Location = new System.Drawing.Point(21, 337);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(508, 59);
            this.btndeleteitem.TabIndex = 0;
            this.btndeleteitem.Text = "DELETE THE ITEM FILE";
            this.btndeleteitem.UseVisualStyleBackColor = false;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(566, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(451, 580);
            this.listBox1.TabIndex = 1;
            // 
            // btn_createfile
            // 
            this.btn_createfile.BackColor = System.Drawing.Color.Lime;
            this.btn_createfile.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createfile.Location = new System.Drawing.Point(21, 440);
            this.btn_createfile.Name = "btn_createfile";
            this.btn_createfile.Size = new System.Drawing.Size(508, 54);
            this.btn_createfile.TabIndex = 2;
            this.btn_createfile.Text = "create file";
            this.btn_createfile.UseVisualStyleBackColor = false;
            this.btn_createfile.Click += new System.EventHandler(this.btn_createfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(508, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "READ LINES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_readfile
            // 
            this.btn_readfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_readfile.Font = new System.Drawing.Font("Vani", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readfile.Location = new System.Drawing.Point(21, 541);
            this.btn_readfile.Name = "btn_readfile";
            this.btn_readfile.Size = new System.Drawing.Size(508, 62);
            this.btn_readfile.TabIndex = 3;
            this.btn_readfile.Text = "read the file";
            this.btn_readfile.UseVisualStyleBackColor = false;
            this.btn_readfile.Click += new System.EventHandler(this.btn_readfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 656);
            this.Controls.Add(this.btn_readfile);
            this.Controls.Add(this.btn_createfile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreadalllines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreadalllines;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_createfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_readfile;
    }
}

