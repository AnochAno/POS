namespace System.Adminboard
{
    partial class product
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdproduct = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(592, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Product Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.grdproduct);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtstock);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtpname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1773, 787);
            this.panel1.TabIndex = 2;
            // 
            // grdproduct
            // 
            this.grdproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdproduct.Location = new System.Drawing.Point(740, 137);
            this.grdproduct.Name = "grdproduct";
            this.grdproduct.RowHeadersWidth = 51;
            this.grdproduct.RowTemplate.Height = 24;
            this.grdproduct.Size = new System.Drawing.Size(986, 587);
            this.grdproduct.TabIndex = 15;
            this.grdproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdproduct_CellContentClick);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(68, 597);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(145, 67);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(68, 503);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(145, 67);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(366, 503);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 67);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(283, 402);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(412, 41);
            this.txtstock.TabIndex = 10;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(283, 339);
            this.txtdiscount.Multiline = true;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(412, 41);
            this.txtdiscount.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(283, 274);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(412, 41);
            this.txtprice.TabIndex = 8;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(283, 208);
            this.txtpname.Multiline = true;
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(412, 41);
            this.txtpname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(62, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 44);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(62, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(283, 137);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(412, 41);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID: ";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(550, 503);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(145, 67);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 784);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "product";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Windows.Forms.Label label6;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Button btnreset;
        private Windows.Forms.Button btndel;
        private Windows.Forms.Button btnupdate;
        private Windows.Forms.TextBox txtstock;
        private Windows.Forms.TextBox txtdiscount;
        private Windows.Forms.TextBox txtprice;
        private Windows.Forms.TextBox txtpname;
        public Windows.Forms.Label label5;
        public Windows.Forms.Label label4;
        public Windows.Forms.Label label3;
        public Windows.Forms.Label label2;
        private Windows.Forms.TextBox txtid;
        public Windows.Forms.Label label1;
        private Windows.Forms.Button btnsave;
        private Windows.Forms.DataGridView grdproduct;
    }
}