namespace LibraryManagement
{
    partial class adbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtauth = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.bprice = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.Label();
            this.bquan = new System.Windows.Forms.Label();
            this.bauth = new System.Windows.Forms.Label();
            this.bpub = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 62);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(297, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(384, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtquan);
            this.panel2.Controls.Add(this.txtpub);
            this.panel2.Controls.Add(this.txtauth);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.bprice);
            this.panel2.Controls.Add(this.bdate);
            this.panel2.Controls.Add(this.bquan);
            this.panel2.Controls.Add(this.bauth);
            this.panel2.Controls.Add(this.bpub);
            this.panel2.Controls.Add(this.bname);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(299, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 408);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Location = new System.Drawing.Point(253, 349);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 34);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Location = new System.Drawing.Point(93, 349);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 34);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(235, 204);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(206, 27);
            this.txtdate.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(235, 300);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(206, 27);
            this.txtprice.TabIndex = 10;
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(235, 250);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(206, 27);
            this.txtquan.TabIndex = 9;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(235, 157);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(206, 27);
            this.txtpub.TabIndex = 8;
            // 
            // txtauth
            // 
            this.txtauth.Location = new System.Drawing.Point(235, 104);
            this.txtauth.Name = "txtauth";
            this.txtauth.Size = new System.Drawing.Size(206, 27);
            this.txtauth.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(206, 27);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // bprice
            // 
            this.bprice.AutoSize = true;
            this.bprice.Location = new System.Drawing.Point(60, 303);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(101, 20);
            this.bprice.TabIndex = 5;
            this.bprice.Text = "Book Price";
            // 
            // bdate
            // 
            this.bdate.AutoSize = true;
            this.bdate.Location = new System.Drawing.Point(60, 210);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(134, 20);
            this.bdate.TabIndex = 4;
            this.bdate.Text = "Purchase Date";
            // 
            // bquan
            // 
            this.bquan.AutoSize = true;
            this.bquan.Location = new System.Drawing.Point(60, 250);
            this.bquan.Name = "bquan";
            this.bquan.Size = new System.Drawing.Size(127, 20);
            this.bquan.TabIndex = 3;
            this.bquan.Text = "Book Quantity";
            // 
            // bauth
            // 
            this.bauth.AutoSize = true;
            this.bauth.Location = new System.Drawing.Point(59, 107);
            this.bauth.Name = "bauth";
            this.bauth.Size = new System.Drawing.Size(112, 20);
            this.bauth.TabIndex = 2;
            this.bauth.Text = "Book Author";
            // 
            // bpub
            // 
            this.bpub.AutoSize = true;
            this.bpub.Location = new System.Drawing.Point(60, 160);
            this.bpub.Name = "bpub";
            this.bpub.Size = new System.Drawing.Size(136, 20);
            this.bpub.TabIndex = 1;
            this.bpub.Text = "Book Publisher";
            // 
            // bname
            // 
            this.bname.AutoSize = true;
            this.bname.Location = new System.Drawing.Point(60, 52);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(105, 20);
            this.bname.TabIndex = 0;
            this.bname.Text = "Book Name";
            this.bname.Click += new System.EventHandler(this.label2_Click);
            // 
            // adbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adbook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label bprice;
        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label bquan;
        private System.Windows.Forms.Label bauth;
        private System.Windows.Forms.Label bpub;
        private System.Windows.Forms.Label bname;
        private System.Windows.Forms.TextBox txtauth;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}