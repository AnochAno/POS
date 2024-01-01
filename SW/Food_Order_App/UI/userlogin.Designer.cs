namespace Food_Order_App.UI
{
    partial class userlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(311, 91);
            this.label1.TabIndex = 0;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(346, 179);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(371, 51);
            this.txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(346, 245);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(371, 51);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(372, 362);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(121, 60);
            this.btnlog.TabIndex = 6;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // btncan
            // 
            this.btncan.Location = new System.Drawing.Point(533, 362);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(121, 60);
            this.btncan.TabIndex = 7;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(594, 326);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(123, 20);
            this.showpass.TabIndex = 5;
            this.showpass.Text = "show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // userlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userlogin";
            this.Text = "userlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btncan;
        public System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox showpass;
    }
}