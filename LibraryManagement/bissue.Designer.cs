namespace LibraryManagement
{
    partial class bissue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bissue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btni = new System.Windows.Forms.Button();
            this.txtbn = new System.Windows.Forms.ComboBox();
            this.txtd = new System.Windows.Forms.DateTimePicker();
            this.txtem = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtsem = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eksit = new System.Windows.Forms.Button();
            this.sarchstd = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.sarchno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 120);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(460, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btni);
            this.panel2.Controls.Add(this.txtbn);
            this.panel2.Controls.Add(this.txtd);
            this.panel2.Controls.Add(this.txtem);
            this.panel2.Controls.Add(this.txtcon);
            this.panel2.Controls.Add(this.txtsem);
            this.panel2.Controls.Add(this.txtdep);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(282, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 453);
            this.panel2.TabIndex = 1;
            // 
            // btni
            // 
            this.btni.BackColor = System.Drawing.Color.Transparent;
            this.btni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btni.Location = new System.Drawing.Point(196, 334);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(113, 36);
            this.btni.TabIndex = 16;
            this.btni.Text = "Issue Book";
            this.btni.UseVisualStyleBackColor = false;
            this.btni.Click += new System.EventHandler(this.btni_Click);
            // 
            // txtbn
            // 
            this.txtbn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbn.FormattingEnabled = true;
            this.txtbn.Location = new System.Drawing.Point(251, 236);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(200, 24);
            this.txtbn.TabIndex = 15;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(251, 284);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(200, 22);
            this.txtd.TabIndex = 14;
            // 
            // txtem
            // 
            this.txtem.Location = new System.Drawing.Point(252, 195);
            this.txtem.Name = "txtem";
            this.txtem.ReadOnly = true;
            this.txtem.Size = new System.Drawing.Size(200, 22);
            this.txtem.TabIndex = 12;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(252, 145);
            this.txtcon.Name = "txtcon";
            this.txtcon.ReadOnly = true;
            this.txtcon.Size = new System.Drawing.Size(201, 22);
            this.txtcon.TabIndex = 11;
            this.txtcon.TextChanged += new System.EventHandler(this.txtcon_TextChanged);
            // 
            // txtsem
            // 
            this.txtsem.Location = new System.Drawing.Point(252, 99);
            this.txtsem.Name = "txtsem";
            this.txtsem.ReadOnly = true;
            this.txtsem.Size = new System.Drawing.Size(200, 22);
            this.txtsem.TabIndex = 10;
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(252, 61);
            this.txtdep.Name = "txtdep";
            this.txtdep.ReadOnly = true;
            this.txtdep.Size = new System.Drawing.Size(201, 22);
            this.txtdep.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(252, 19);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(64, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(409, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Maximum 3 Books Can be ISSUED to 1 Student";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Student Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Student Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Student Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.eksit);
            this.panel3.Controls.Add(this.sarchstd);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.sarchno);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 453);
            this.panel3.TabIndex = 2;
            // 
            // eksit
            // 
            this.eksit.Location = new System.Drawing.Point(157, 334);
            this.eksit.Name = "eksit";
            this.eksit.Size = new System.Drawing.Size(82, 32);
            this.eksit.TabIndex = 1;
            this.eksit.Text = "Exit";
            this.eksit.UseVisualStyleBackColor = true;
            this.eksit.Click += new System.EventHandler(this.eksit_Click);
            // 
            // sarchstd
            // 
            this.sarchstd.Location = new System.Drawing.Point(52, 239);
            this.sarchstd.Name = "sarchstd";
            this.sarchstd.Size = new System.Drawing.Size(144, 49);
            this.sarchstd.TabIndex = 0;
            this.sarchstd.Text = "Search Student";
            this.sarchstd.UseVisualStyleBackColor = true;
            this.sarchstd.Click += new System.EventHandler(this.sarchstd_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(25, 334);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(82, 31);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // sarchno
            // 
            this.sarchno.Location = new System.Drawing.Point(25, 178);
            this.sarchno.Name = "sarchno";
            this.sarchno.Size = new System.Drawing.Size(214, 22);
            this.sarchno.TabIndex = 0;
            this.sarchno.TextChanged += new System.EventHandler(this.sarchno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Enrollement No.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 93);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bissue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "bissue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bissue";
            this.Load += new System.EventHandler(this.bissue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button eksit;
        private System.Windows.Forms.Button sarchstd;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox sarchno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtem;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtsem;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btni;
        private System.Windows.Forms.ComboBox txtbn;
        private System.Windows.Forms.DateTimePicker txtd;
    }
}