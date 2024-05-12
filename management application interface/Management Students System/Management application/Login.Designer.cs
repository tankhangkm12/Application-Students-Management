namespace Management_application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelenteredlogin = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonregister = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitlelogin = new System.Windows.Forms.Panel();
            this.labeltitlelogin = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxverification = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelverification = new System.Windows.Forms.Label();
            this.labelshowverification = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelenteredlogin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltitlelogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelenteredlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.paneltitlelogin);
            this.panel1.Location = new System.Drawing.Point(32, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 411);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelenteredlogin
            // 
            this.panelenteredlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelenteredlogin.Controls.Add(this.labellogin);
            this.panelenteredlogin.Controls.Add(this.labelshowverification);
            this.panelenteredlogin.Controls.Add(this.labelverification);
            this.panelenteredlogin.Controls.Add(this.labelpassword);
            this.panelenteredlogin.Controls.Add(this.labelusername);
            this.panelenteredlogin.Controls.Add(this.textBoxverification);
            this.panelenteredlogin.Controls.Add(this.textBoxpassword);
            this.panelenteredlogin.Controls.Add(this.textBoxusername);
            this.panelenteredlogin.Controls.Add(this.buttonexit);
            this.panelenteredlogin.Controls.Add(this.buttonlogin);
            this.panelenteredlogin.Controls.Add(this.buttonregister);
            this.panelenteredlogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelenteredlogin.ForeColor = System.Drawing.Color.Snow;
            this.panelenteredlogin.Location = new System.Drawing.Point(236, 91);
            this.panelenteredlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelenteredlogin.Name = "panelenteredlogin";
            this.panelenteredlogin.Size = new System.Drawing.Size(404, 320);
            this.panelenteredlogin.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.Color.Snow;
            this.buttonexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonexit.Location = new System.Drawing.Point(270, 245);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(92, 43);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.Snow;
            this.buttonlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonlogin.Location = new System.Drawing.Point(152, 245);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(100, 42);
            this.buttonlogin.TabIndex = 1;
            this.buttonlogin.Text = "Register";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.Lime;
            this.buttonregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.ForeColor = System.Drawing.Color.Snow;
            this.buttonregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonregister.Location = new System.Drawing.Point(35, 246);
            this.buttonregister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(101, 42);
            this.buttonregister.TabIndex = 0;
            this.buttonregister.Text = "Sign In";
            this.buttonregister.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 320);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Management_application.Properties.Resources._3094352;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneltitlelogin
            // 
            this.paneltitlelogin.Controls.Add(this.labeltitlelogin);
            this.paneltitlelogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlelogin.Location = new System.Drawing.Point(0, 0);
            this.paneltitlelogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneltitlelogin.Name = "paneltitlelogin";
            this.paneltitlelogin.Size = new System.Drawing.Size(640, 91);
            this.paneltitlelogin.TabIndex = 0;
            // 
            // labeltitlelogin
            // 
            this.labeltitlelogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labeltitlelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitlelogin.ForeColor = System.Drawing.Color.Red;
            this.labeltitlelogin.Location = new System.Drawing.Point(0, 0);
            this.labeltitlelogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltitlelogin.Name = "labeltitlelogin";
            this.labeltitlelogin.Size = new System.Drawing.Size(640, 91);
            this.labeltitlelogin.TabIndex = 0;
            this.labeltitlelogin.Text = "MANAGEMENT STUDENTS SYSTEM";
            this.labeltitlelogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeltitlelogin.Click += new System.EventHandler(this.labeltitlelogin_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.Location = new System.Drawing.Point(142, 53);
            this.textBoxusername.Multiline = true;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(220, 32);
            this.textBoxusername.TabIndex = 3;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(142, 118);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(220, 36);
            this.textBoxpassword.TabIndex = 4;
            // 
            // textBoxverification
            // 
            this.textBoxverification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxverification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxverification.Location = new System.Drawing.Point(142, 181);
            this.textBoxverification.Multiline = true;
            this.textBoxverification.Name = "textBoxverification";
            this.textBoxverification.Size = new System.Drawing.Size(100, 32);
            this.textBoxverification.TabIndex = 5;
            // 
            // labelusername
            // 
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.Snow;
            this.labelusername.Location = new System.Drawing.Point(5, 62);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(131, 23);
            this.labelusername.TabIndex = 6;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.Snow;
            this.labelpassword.Location = new System.Drawing.Point(5, 131);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(131, 23);
            this.labelpassword.TabIndex = 7;
            this.labelpassword.Text = "passwork";
            // 
            // labelverification
            // 
            this.labelverification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelverification.ForeColor = System.Drawing.Color.Snow;
            this.labelverification.Location = new System.Drawing.Point(5, 190);
            this.labelverification.Name = "labelverification";
            this.labelverification.Size = new System.Drawing.Size(131, 23);
            this.labelverification.TabIndex = 8;
            this.labelverification.Text = "Verification";
            this.labelverification.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelshowverification
            // 
            this.labelshowverification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelshowverification.BackColor = System.Drawing.Color.White;
            this.labelshowverification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowverification.Location = new System.Drawing.Point(248, 181);
            this.labelshowverification.Name = "labelshowverification";
            this.labelshowverification.Size = new System.Drawing.Size(114, 32);
            this.labelshowverification.TabIndex = 9;
            this.labelshowverification.Tag = "";
            this.labelshowverification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labellogin
            // 
            this.labellogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.Snow;
            this.labellogin.Location = new System.Drawing.Point(101, 0);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(208, 38);
            this.labellogin.TabIndex = 10;
            this.labellogin.Text = "LOGIN";
            this.labellogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Management_application.Properties.Resources._9145838;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 492);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 531);
            this.Name = "Login";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panelenteredlogin.ResumeLayout(false);
            this.panelenteredlogin.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltitlelogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paneltitlelogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelenteredlogin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Label labeltitlelogin;
        private System.Windows.Forms.Label labelverification;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textBoxverification;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelshowverification;
        private System.Windows.Forms.Label labellogin;
    }
}

