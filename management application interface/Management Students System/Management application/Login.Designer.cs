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
            this.labellogin = new System.Windows.Forms.Label();
            this.labelshowverification = new System.Windows.Forms.Label();
            this.labelverification = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.textBoxverification = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitlelogin = new System.Windows.Forms.Panel();
            this.labeltitlelogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelenteredlogin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltitlelogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panelenteredlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.paneltitlelogin);
            this.panel1.Name = "panel1";
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
            this.panelenteredlogin.Controls.Add(this.buttonregister);
            this.panelenteredlogin.Controls.Add(this.buttonlogin);
            resources.ApplyResources(this.panelenteredlogin, "panelenteredlogin");
            this.panelenteredlogin.ForeColor = System.Drawing.Color.Snow;
            this.panelenteredlogin.Name = "panelenteredlogin";
            // 
            // labellogin
            // 
            resources.ApplyResources(this.labellogin, "labellogin");
            this.labellogin.ForeColor = System.Drawing.Color.Snow;
            this.labellogin.Name = "labellogin";
            // 
            // labelshowverification
            // 
            resources.ApplyResources(this.labelshowverification, "labelshowverification");
            this.labelshowverification.BackColor = System.Drawing.Color.White;
            this.labelshowverification.CausesValidation = false;
            this.labelshowverification.ForeColor = System.Drawing.Color.Black;
            this.labelshowverification.Name = "labelshowverification";
            this.labelshowverification.Tag = "";
            this.labelshowverification.Click += new System.EventHandler(this.labelshowverification_Click);
            // 
            // labelverification
            // 
            resources.ApplyResources(this.labelverification, "labelverification");
            this.labelverification.ForeColor = System.Drawing.Color.Snow;
            this.labelverification.Name = "labelverification";
            this.labelverification.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelpassword
            // 
            resources.ApplyResources(this.labelpassword, "labelpassword");
            this.labelpassword.ForeColor = System.Drawing.Color.Snow;
            this.labelpassword.Name = "labelpassword";
            // 
            // labelusername
            // 
            resources.ApplyResources(this.labelusername, "labelusername");
            this.labelusername.ForeColor = System.Drawing.Color.Snow;
            this.labelusername.Name = "labelusername";
            // 
            // textBoxverification
            // 
            resources.ApplyResources(this.textBoxverification, "textBoxverification");
            this.textBoxverification.Name = "textBoxverification";
            // 
            // textBoxpassword
            // 
            resources.ApplyResources(this.textBoxpassword, "textBoxpassword");
            this.textBoxpassword.Name = "textBoxpassword";
            // 
            // textBoxusername
            // 
            resources.ApplyResources(this.textBoxusername, "textBoxusername");
            this.textBoxusername.Name = "textBoxusername";
            // 
            // buttonexit
            // 
            resources.ApplyResources(this.buttonexit, "buttonexit");
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.ForeColor = System.Drawing.Color.Snow;
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonregister, "buttonregister");
            this.buttonregister.ForeColor = System.Drawing.Color.Snow;
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.buttonlogin, "buttonlogin");
            this.buttonlogin.ForeColor = System.Drawing.Color.Snow;
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Management_application.Properties.Resources._3094352;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // paneltitlelogin
            // 
            this.paneltitlelogin.Controls.Add(this.labeltitlelogin);
            resources.ApplyResources(this.paneltitlelogin, "paneltitlelogin");
            this.paneltitlelogin.Name = "paneltitlelogin";
            // 
            // labeltitlelogin
            // 
            this.labeltitlelogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.labeltitlelogin, "labeltitlelogin");
            this.labeltitlelogin.ForeColor = System.Drawing.Color.Red;
            this.labeltitlelogin.Name = "labeltitlelogin";
            this.labeltitlelogin.Click += new System.EventHandler(this.labeltitlelogin_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Management_application.Properties.Resources._9145838;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
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
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttonlogin;
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

