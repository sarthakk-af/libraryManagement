using System.Windows.Forms;

namespace LibraryManagement
{
    partial class AddBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
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
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // panel2
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtc);
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
            this.panel2.Location = new System.Drawing.Point(431, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 641);
            this.panel2.TabIndex = 1;

            // cancel
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(291, 536);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(127, 52);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);

            // save
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(89, 536);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 52);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);

            // txtdate
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(230, 271);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(237, 30);
            this.txtdate.TabIndex = 11;

            // txtprice
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(230, 391);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(237, 30);
            this.txtprice.TabIndex = 10;

            // txtquan
            this.txtquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquan.Location = new System.Drawing.Point(230, 331);
            this.txtquan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(237, 30);
            this.txtquan.TabIndex = 9;

            // txtpub
            this.txtpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpub.Location = new System.Drawing.Point(230, 214);
            this.txtpub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(237, 30);
            this.txtpub.TabIndex = 8;

            // txtauth
            this.txtauth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauth.Location = new System.Drawing.Point(230, 161);
            this.txtauth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtauth.Name = "txtauth";
            this.txtauth.Size = new System.Drawing.Size(237, 30);
            this.txtauth.TabIndex = 7;

            // txtname
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(230, 103);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 30);
            this.txtname.TabIndex = 6;

            // bprice
            this.bprice.AutoSize = true;
            this.bprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprice.Location = new System.Drawing.Point(44, 396);
            this.bprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(116, 25);
            this.bprice.TabIndex = 5;
            this.bprice.Text = "Book Price";

            // bdate
            this.bdate.AutoSize = true;
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Location = new System.Drawing.Point(44, 276);
            this.bdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(154, 25);
            this.bdate.TabIndex = 4;
            this.bdate.Text = "Purchase Date";

            // bquan
            this.bquan.AutoSize = true;
            this.bquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquan.Location = new System.Drawing.Point(44, 334);
            this.bquan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bquan.Name = "bquan";
            this.bquan.Size = new System.Drawing.Size(148, 25);
            this.bquan.TabIndex = 3;
            this.bquan.Text = "Book Quantity";

            // bauth
            this.bauth.AutoSize = true;
            this.bauth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bauth.Location = new System.Drawing.Point(44, 166);
            this.bauth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bauth.Name = "bauth";
            this.bauth.Size = new System.Drawing.Size(131, 25);
            this.bauth.TabIndex = 2;
            this.bauth.Text = "Book Author";

            // bpub
            this.bpub.AutoSize = true;
            this.bpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpub.Location = new System.Drawing.Point(44, 219);
            this.bpub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bpub.Name = "bpub";
            this.bpub.Size = new System.Drawing.Size(157, 25);
            this.bpub.TabIndex = 1;
            this.bpub.Text = "Book Publisher";

            // bname
            this.bname.AutoSize = true;
            this.bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.Location = new System.Drawing.Point(44, 108);
            this.bname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(123, 25);
            this.bname.TabIndex = 0;
            this.bname.Text = "Book Name";

            // txtc
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(230, 454);
            this.txtc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(237, 30);
            this.txtc.TabIndex = 14;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Book Code";

            // AddBook
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtc;
    }
}