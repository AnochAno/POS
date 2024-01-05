namespace Food_Order_App.UI
{
    partial class usereg
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
            this.btnback = new System.Windows.Forms.Button();
            this.grduser = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpho = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtbal = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grduser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(410, 196);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 111);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // grduser
            // 
            this.grduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grduser.Location = new System.Drawing.Point(1016, 309);
            this.grduser.Name = "grduser";
            this.grduser.RowHeadersWidth = 51;
            this.grduser.RowTemplate.Height = 24;
            this.grduser.Size = new System.Drawing.Size(701, 583);
            this.grduser.TabIndex = 18;
            this.grduser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grduser_CellClick);
            this.grduser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdadmin_CellContentClick);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(518, 829);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 63);
            this.btnreset.TabIndex = 17;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(363, 827);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(127, 65);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(718, 838);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(123, 54);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(869, 841);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 51);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpho
            // 
            this.txtpho.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpho.Location = new System.Drawing.Point(593, 660);
            this.txtpho.Name = "txtpho";
            this.txtpho.Size = new System.Drawing.Size(382, 34);
            this.txtpho.TabIndex = 12;
            this.txtpho.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(593, 601);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(382, 34);
            this.txtemail.TabIndex = 11;
            this.txtemail.TextChanged += new System.EventHandler(this.txtcon_TextChanged);
            // 
            // txtbal
            // 
            this.txtbal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbal.Location = new System.Drawing.Point(593, 536);
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(382, 34);
            this.txtbal.TabIndex = 10;
            this.txtbal.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(593, 480);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(382, 34);
            this.txtpass.TabIndex = 9;
            this.txtpass.TextChanged += new System.EventHandler(this.txtadd_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(593, 418);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(382, 34);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(593, 358);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(382, 34);
            this.txtid.TabIndex = 7;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Balnce";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.grduser);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtpho);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtbal);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-304, -148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1774, 907);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // usereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 756);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usereg";
            this.Text = "userorderpage";
            ((System.ComponentModel.ISupportInitialize)(this.grduser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView grduser;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtpho;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtbal;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}