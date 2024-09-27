namespace LibraryManagement
{
    partial class rbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eksit = new System.Windows.Forms.Button();
            this.refesh = new System.Windows.Forms.Button();
            this.btnsarch = new System.Windows.Forms.Button();
            this.txtsarchol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.retun = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bkdin = new System.Windows.Forms.TextBox();
            this.bknaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.eksit);
            this.panel1.Controls.Add(this.refesh);
            this.panel1.Controls.Add(this.btnsarch);
            this.panel1.Controls.Add(this.txtsarchol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 408);
            this.panel1.TabIndex = 0;
            // 
            // eksit
            // 
            this.eksit.Location = new System.Drawing.Point(144, 359);
            this.eksit.Name = "eksit";
            this.eksit.Size = new System.Drawing.Size(79, 33);
            this.eksit.TabIndex = 0;
            this.eksit.Text = "Exit";
            this.eksit.UseVisualStyleBackColor = true;
            this.eksit.Click += new System.EventHandler(this.button3_Click);
            // 
            // refesh
            // 
            this.refesh.Location = new System.Drawing.Point(24, 359);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(79, 33);
            this.refesh.TabIndex = 0;
            this.refesh.Text = "Refresh";
            this.refesh.UseVisualStyleBackColor = true;
            this.refesh.Click += new System.EventHandler(this.refesh_Click);
            // 
            // btnsarch
            // 
            this.btnsarch.Location = new System.Drawing.Point(52, 269);
            this.btnsarch.Name = "btnsarch";
            this.btnsarch.Size = new System.Drawing.Size(140, 42);
            this.btnsarch.TabIndex = 1;
            this.btnsarch.Text = "Search Student";
            this.btnsarch.UseVisualStyleBackColor = true;
            this.btnsarch.Click += new System.EventHandler(this.btnsarch_Click);
            // 
            // txtsarchol
            // 
            this.txtsarchol.Location = new System.Drawing.Point(24, 211);
            this.txtsarchol.Name = "txtsarchol";
            this.txtsarchol.Size = new System.Drawing.Size(199, 22);
            this.txtsarchol.TabIndex = 0;
            this.txtsarchol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Enrollment No. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.cancel);
            this.panel3.Controls.Add(this.retun);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.bkdin);
            this.panel3.Controls.Add(this.bknaam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(274, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 323);
            this.panel3.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(551, 168);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(81, 29);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // retun
            // 
            this.retun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retun.Location = new System.Drawing.Point(551, 108);
            this.retun.Name = "retun";
            this.retun.Size = new System.Drawing.Size(81, 30);
            this.retun.TabIndex = 6;
            this.retun.Text = "Return";
            this.retun.UseVisualStyleBackColor = true;
            this.retun.Click += new System.EventHandler(this.retun_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // bkdin
            // 
            this.bkdin.Location = new System.Drawing.Point(305, 112);
            this.bkdin.Name = "bkdin";
            this.bkdin.Size = new System.Drawing.Size(200, 22);
            this.bkdin.TabIndex = 4;
            // 
            // bknaam
            // 
            this.bknaam.Location = new System.Drawing.Point(305, 59);
            this.bknaam.Name = "bknaam";
            this.bknaam.Size = new System.Drawing.Size(200, 22);
            this.bknaam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Book Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 298);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rbook";
            this.Load += new System.EventHandler(this.rbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button eksit;
        private System.Windows.Forms.Button refesh;
        private System.Windows.Forms.Button btnsarch;
        private System.Windows.Forms.TextBox txtsarchol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button retun;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox bkdin;
        private System.Windows.Forms.TextBox bknaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}