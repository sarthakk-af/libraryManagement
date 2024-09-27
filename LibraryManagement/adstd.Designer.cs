namespace LibraryManagement
{
    partial class adstd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adstd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stdsem = new System.Windows.Forms.ComboBox();
            this.eksit = new System.Windows.Forms.Button();
            this.sev = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.stdeml = new System.Windows.Forms.TextBox();
            this.stdcon = new System.Windows.Forms.TextBox();
            this.stddep = new System.Windows.Forms.TextBox();
            this.stden = new System.Windows.Forms.TextBox();
            this.stdn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.scon = new System.Windows.Forms.Label();
            this.ssem = new System.Windows.Forms.Label();
            this.sdprt = new System.Windows.Forms.Label();
            this.snum = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, -31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.stdsem);
            this.panel2.Controls.Add(this.eksit);
            this.panel2.Controls.Add(this.sev);
            this.panel2.Controls.Add(this.btnrefresh);
            this.panel2.Controls.Add(this.stdeml);
            this.panel2.Controls.Add(this.stdcon);
            this.panel2.Controls.Add(this.stddep);
            this.panel2.Controls.Add(this.stden);
            this.panel2.Controls.Add(this.stdn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.scon);
            this.panel2.Controls.Add(this.ssem);
            this.panel2.Controls.Add(this.sdprt);
            this.panel2.Controls.Add(this.snum);
            this.panel2.Controls.Add(this.sname);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(323, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 428);
            this.panel2.TabIndex = 2;
            // 
            // stdsem
            // 
            this.stdsem.FormattingEnabled = true;
            this.stdsem.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 2",
            "Semester 3",
            "Semester 4",
            "Semester 5",
            "Semester 6",
            "Semester 7",
            "Semester 8"});
            this.stdsem.Location = new System.Drawing.Point(286, 183);
            this.stdsem.Name = "stdsem";
            this.stdsem.Size = new System.Drawing.Size(182, 33);
            this.stdsem.TabIndex = 15;
            this.stdsem.SelectedIndexChanged += new System.EventHandler(this.stdsem_SelectedIndexChanged);
            // 
            // eksit
            // 
            this.eksit.Location = new System.Drawing.Point(384, 360);
            this.eksit.Name = "eksit";
            this.eksit.Size = new System.Drawing.Size(101, 38);
            this.eksit.TabIndex = 14;
            this.eksit.Text = "Exit";
            this.eksit.UseVisualStyleBackColor = true;
            this.eksit.Click += new System.EventHandler(this.eksit_Click);
            // 
            // sev
            // 
            this.sev.Location = new System.Drawing.Point(226, 360);
            this.sev.Name = "sev";
            this.sev.Size = new System.Drawing.Size(101, 38);
            this.sev.TabIndex = 13;
            this.sev.Text = "Save ";
            this.sev.UseVisualStyleBackColor = true;
            this.sev.Click += new System.EventHandler(this.sev_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(54, 360);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(101, 38);
            this.btnrefresh.TabIndex = 12;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // stdeml
            // 
            this.stdeml.Location = new System.Drawing.Point(286, 283);
            this.stdeml.Name = "stdeml";
            this.stdeml.Size = new System.Drawing.Size(182, 30);
            this.stdeml.TabIndex = 11;
            this.stdeml.TextChanged += new System.EventHandler(this.stdeml_TextChanged);
            // 
            // stdcon
            // 
            this.stdcon.Location = new System.Drawing.Point(286, 230);
            this.stdcon.Name = "stdcon";
            this.stdcon.Size = new System.Drawing.Size(182, 30);
            this.stdcon.TabIndex = 10;
            this.stdcon.TextChanged += new System.EventHandler(this.stdcon_TextChanged);
            // 
            // stddep
            // 
            this.stddep.Location = new System.Drawing.Point(286, 135);
            this.stddep.Name = "stddep";
            this.stddep.Size = new System.Drawing.Size(182, 30);
            this.stddep.TabIndex = 8;
            // 
            // stden
            // 
            this.stden.Location = new System.Drawing.Point(286, 89);
            this.stden.Name = "stden";
            this.stden.Size = new System.Drawing.Size(182, 30);
            this.stden.TabIndex = 7;
            // 
            // stdn
            // 
            this.stdn.Location = new System.Drawing.Point(286, 39);
            this.stdn.Name = "stdn";
            this.stdn.Size = new System.Drawing.Size(182, 30);
            this.stdn.TabIndex = 6;
            this.stdn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Student Email";
            // 
            // scon
            // 
            this.scon.AutoSize = true;
            this.scon.Location = new System.Drawing.Point(72, 233);
            this.scon.Name = "scon";
            this.scon.Size = new System.Drawing.Size(153, 25);
            this.scon.TabIndex = 4;
            this.scon.Text = "Student Contact";
            // 
            // ssem
            // 
            this.ssem.AutoSize = true;
            this.ssem.Location = new System.Drawing.Point(72, 186);
            this.ssem.Name = "ssem";
            this.ssem.Size = new System.Drawing.Size(169, 25);
            this.ssem.TabIndex = 3;
            this.ssem.Text = "Student Semester";
            // 
            // sdprt
            // 
            this.sdprt.AutoSize = true;
            this.sdprt.Location = new System.Drawing.Point(72, 138);
            this.sdprt.Name = "sdprt";
            this.sdprt.Size = new System.Drawing.Size(113, 25);
            this.sdprt.TabIndex = 2;
            this.sdprt.Text = "Department";
            // 
            // snum
            // 
            this.snum.AutoSize = true;
            this.snum.Location = new System.Drawing.Point(72, 92);
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(139, 25);
            this.snum.TabIndex = 1;
            this.snum.Text = "Enrollment No.";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(72, 42);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(137, 25);
            this.sname.TabIndex = 0;
            this.sname.Text = "Student Name";
            // 
            // adstd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adstd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adstd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox stdeml;
        private System.Windows.Forms.TextBox stdcon;
        private System.Windows.Forms.TextBox stddep;
        private System.Windows.Forms.TextBox stden;
        private System.Windows.Forms.TextBox stdn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label scon;
        private System.Windows.Forms.Label ssem;
        private System.Windows.Forms.Label sdprt;
        private System.Windows.Forms.Label snum;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Button eksit;
        private System.Windows.Forms.Button sev;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ComboBox stdsem;
    }
}