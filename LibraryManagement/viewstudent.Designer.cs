namespace LibraryManagement
{
    partial class viewstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewstudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsarch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.updt = new System.Windows.Forms.Button();
            this.depart = new System.Windows.Forms.Label();
            this.sems = new System.Windows.Forms.Label();
            this.emaild = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.Label();
            this.enroln = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.smail = new System.Windows.Forms.TextBox();
            this.ssem = new System.Windows.Forms.TextBox();
            this.sdep = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.senrol = new System.Windows.Forms.TextBox();
            this.scon = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 138);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtsarch
            // 
            this.txtsarch.Location = new System.Drawing.Point(324, 156);
            this.txtsarch.Name = "txtsarch";
            this.txtsarch.Size = new System.Drawing.Size(166, 22);
            this.txtsarch.TabIndex = 1;
            this.txtsarch.TextChanged += new System.EventHandler(this.txtsarch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enrollment No.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 328);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.del);
            this.panel2.Controls.Add(this.updt);
            this.panel2.Controls.Add(this.depart);
            this.panel2.Controls.Add(this.sems);
            this.panel2.Controls.Add(this.emaild);
            this.panel2.Controls.Add(this.cont);
            this.panel2.Controls.Add(this.enroln);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.smail);
            this.panel2.Controls.Add(this.ssem);
            this.panel2.Controls.Add(this.sdep);
            this.panel2.Controls.Add(this.sname);
            this.panel2.Controls.Add(this.senrol);
            this.panel2.Controls.Add(this.scon);
            this.panel2.Location = new System.Drawing.Point(12, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 342);
            this.panel2.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(588, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 37);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(450, 275);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(121, 37);
            this.del.TabIndex = 13;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // updt
            // 
            this.updt.Location = new System.Drawing.Point(300, 275);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(121, 37);
            this.updt.TabIndex = 12;
            this.updt.Text = "Update";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // depart
            // 
            this.depart.AutoSize = true;
            this.depart.Location = new System.Drawing.Point(92, 212);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(77, 16);
            this.depart.TabIndex = 11;
            this.depart.Text = "Department";
            // 
            // sems
            // 
            this.sems.AutoSize = true;
            this.sems.Location = new System.Drawing.Point(494, 52);
            this.sems.Name = "sems";
            this.sems.Size = new System.Drawing.Size(65, 16);
            this.sems.TabIndex = 10;
            this.sems.Text = "Semester";
            // 
            // emaild
            // 
            this.emaild.AutoSize = true;
            this.emaild.Location = new System.Drawing.Point(494, 212);
            this.emaild.Name = "emaild";
            this.emaild.Size = new System.Drawing.Size(57, 16);
            this.emaild.TabIndex = 9;
            this.emaild.Text = "Email ID";
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Location = new System.Drawing.Point(494, 135);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(76, 16);
            this.cont.TabIndex = 8;
            this.cont.Text = "Contact No.";
            // 
            // enroln
            // 
            this.enroln.AutoSize = true;
            this.enroln.Location = new System.Drawing.Point(92, 135);
            this.enroln.Name = "enroln";
            this.enroln.Size = new System.Drawing.Size(94, 16);
            this.enroln.TabIndex = 7;
            this.enroln.Text = "Enrollment No.";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(92, 52);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(92, 16);
            this.name.TabIndex = 6;
            this.name.Text = "Student Name";
            // 
            // smail
            // 
            this.smail.Location = new System.Drawing.Point(579, 209);
            this.smail.Name = "smail";
            this.smail.Size = new System.Drawing.Size(161, 22);
            this.smail.TabIndex = 5;
            // 
            // ssem
            // 
            this.ssem.Location = new System.Drawing.Point(579, 49);
            this.ssem.Name = "ssem";
            this.ssem.Size = new System.Drawing.Size(161, 22);
            this.ssem.TabIndex = 4;
            // 
            // sdep
            // 
            this.sdep.Location = new System.Drawing.Point(192, 209);
            this.sdep.Name = "sdep";
            this.sdep.Size = new System.Drawing.Size(163, 22);
            this.sdep.TabIndex = 3;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(192, 49);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(163, 22);
            this.sname.TabIndex = 2;
            // 
            // senrol
            // 
            this.senrol.Location = new System.Drawing.Point(192, 132);
            this.senrol.Name = "senrol";
            this.senrol.Size = new System.Drawing.Size(163, 22);
            this.senrol.TabIndex = 1;
            // 
            // scon
            // 
            this.scon.Location = new System.Drawing.Point(579, 132);
            this.scon.Name = "scon";
            this.scon.Size = new System.Drawing.Size(161, 22);
            this.scon.TabIndex = 0;
            // 
            // viewstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsarch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "viewstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewstudent";
            this.Load += new System.EventHandler(this.viewstudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsarch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label depart;
        private System.Windows.Forms.Label sems;
        private System.Windows.Forms.Label emaild;
        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Label enroln;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox smail;
        private System.Windows.Forms.TextBox ssem;
        private System.Windows.Forms.TextBox sdep;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox senrol;
        private System.Windows.Forms.TextBox scon;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button updt;
    }
}