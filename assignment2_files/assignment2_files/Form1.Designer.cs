namespace assignment2_files
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
            this.oprnfile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // oprnfile
            // 
            this.oprnfile.Font = new System.Drawing.Font("Vani", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprnfile.Location = new System.Drawing.Point(32, 124);
            this.oprnfile.Name = "oprnfile";
            this.oprnfile.Size = new System.Drawing.Size(413, 66);
            this.oprnfile.TabIndex = 1;
            this.oprnfile.Text = "OPEN FILE DIALOG";
            this.oprnfile.UseVisualStyleBackColor = true;
            this.oprnfile.Click += new System.EventHandler(this.oprnfile_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vani", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "SAVE FILE DIALOG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Vani", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(32, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(413, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Vani", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 45);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Vani", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(518, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 323);
            this.listBox1.TabIndex = 4;
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.oprnfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oprnfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog savefile;
    }
}

