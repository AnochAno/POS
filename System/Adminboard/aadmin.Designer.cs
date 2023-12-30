namespace System.Adminboard
{
    partial class aadmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdadmin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtbal = new System.Windows.Forms.TextBox();
            this.txtadpass = new System.Windows.Forms.TextBox();
            this.txtadphone = new System.Windows.Forms.TextBox();
            this.txtademail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.grdadmin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtbal);
            this.panel1.Controls.Add(this.txtadpass);
            this.panel1.Controls.Add(this.txtadphone);
            this.panel1.Controls.Add(this.txtademail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtadname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1771, 733);
            this.panel1.TabIndex = 1;
            // 
            // grdadmin
            // 
            this.grdadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdadmin.Location = new System.Drawing.Point(662, 127);
            this.grdadmin.Name = "grdadmin";
            this.grdadmin.RowHeadersWidth = 51;
            this.grdadmin.RowTemplate.Height = 24;
            this.grdadmin.Size = new System.Drawing.Size(1041, 532);
            this.grdadmin.TabIndex = 15;
            this.grdadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdadmin_CellContentClick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(694, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Admin Resgistration";
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(34, 607);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(145, 67);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(34, 513);
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
            this.btnupdate.Location = new System.Drawing.Point(209, 513);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 67);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtbal
            // 
            this.txtbal.Location = new System.Drawing.Point(209, 445);
            this.txtbal.Multiline = true;
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(412, 41);
            this.txtbal.TabIndex = 10;
            // 
            // txtadpass
            // 
            this.txtadpass.Location = new System.Drawing.Point(209, 382);
            this.txtadpass.Multiline = true;
            this.txtadpass.Name = "txtadpass";
            this.txtadpass.Size = new System.Drawing.Size(412, 41);
            this.txtadpass.TabIndex = 9;
            // 
            // txtadphone
            // 
            this.txtadphone.Location = new System.Drawing.Point(209, 317);
            this.txtadphone.Multiline = true;
            this.txtadphone.Name = "txtadphone";
            this.txtadphone.Size = new System.Drawing.Size(412, 41);
            this.txtadphone.TabIndex = 8;
            // 
            // txtademail
            // 
            this.txtademail.Location = new System.Drawing.Point(209, 251);
            this.txtademail.Multiline = true;
            this.txtademail.Name = "txtademail";
            this.txtademail.Size = new System.Drawing.Size(412, 41);
            this.txtademail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 44);
            this.label5.TabIndex = 6;
            this.label5.Text = "Balance: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtadname
            // 
            this.txtadname.Location = new System.Drawing.Point(209, 180);
            this.txtadname.Multiline = true;
            this.txtadname.Name = "txtadname";
            this.txtadname.Size = new System.Drawing.Size(412, 41);
            this.txtadname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(379, 513);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(145, 67);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(209, 112);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(412, 41);
            this.txtid.TabIndex = 16;
            // 
            // aadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 733);
            this.Controls.Add(this.panel1);
            this.Name = "aadmin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdadmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panel1;
        public Windows.Forms.Label label6;
        private Windows.Forms.Button btnreset;
        private Windows.Forms.Button btndel;
        private Windows.Forms.Button btnupdate;
        private Windows.Forms.TextBox txtbal;
        private Windows.Forms.TextBox txtadpass;
        private Windows.Forms.TextBox txtadphone;
        private Windows.Forms.TextBox txtademail;
        public Windows.Forms.Label label5;
        public Windows.Forms.Label label4;
        public Windows.Forms.Label label3;
        public Windows.Forms.Label label2;
        private Windows.Forms.TextBox txtadname;
        public Windows.Forms.Label label1;
        private Windows.Forms.Button btnsave;
        private Windows.Forms.DataGridView grdadmin;
        private Windows.Forms.TextBox txtid;
    }
}