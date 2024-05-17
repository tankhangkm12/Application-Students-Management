namespace Management_application
{
    partial class Addstudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addstudent));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxmajor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxidcard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxnumberphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxgender = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textfullname = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.labelbirthday = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.labelfullname = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonupload = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.pictureBoxgirl = new System.Windows.Forms.PictureBox();
            this.pictureBoxboy = new System.Windows.Forms.PictureBox();
            this.pictureavt = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxboy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureavt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1094, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS PROFILE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxmajor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxidcard);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxemail);
            this.groupBox1.Controls.Add(this.textBoxnumberphone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBoxgender);
            this.groupBox1.Controls.Add(this.textfullname);
            this.groupBox1.Controls.Add(this.birthday);
            this.groupBox1.Controls.Add(this.labelbirthday);
            this.groupBox1.Controls.Add(this.labelgender);
            this.groupBox1.Controls.Add(this.labelfullname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(78, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 655);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entered Information Student here             ";
            // 
            // comboBoxmajor
            // 
            this.comboBoxmajor.FormattingEnabled = true;
            this.comboBoxmajor.Items.AddRange(new object[] {
            "Kỹ thuật Điện tử Viễn thông - KTDEVT",
            "Kỹ thuật Viễn thông - KTVTH",
            "Kỹ thuật Mạng - KTMANG",
            "Kỹ thuật Phần mềm - KTPHANM",
            "Kỹ thuật Máy tính - KTMAYT",
            "Kỹ thuật Tin học - KTTINH",
            "Kỹ thuật Hệ thống thông tin - KTHSTT",
            "Kỹ thuật Truyền thông và Mạng máy tính - KTTRMANG",
            "Kỹ thuật Điện - KTDIEN",
            "Kỹ thuật Điều khiển và Tự động hóa - KTDDKTDH",
            "Kỹ thuật Điện tử - KTDE",
            "Kỹ thuật Điện tử - Viễn thông - KTDEVT",
            "Kỹ thuật Công nghệ thông tin - KTCNTT",
            "Kinh doanh Quốc tế - KINQUOC",
            "Quản trị Kinh doanh - QTRIKD",
            "Quản lý Kinh doanh - QLKD",
            "Kinh doanh và Quản lý Dự án - KDAQDAN",
            "Marketing - MARKT",
            "Tài chính - Ngân hàng - TAICHNH",
            "Quản lý Tài chính - QLTAICH",
            "Kế toán - KETOAN",
            "Quản trị Du lịch và Dịch vụ - QTRIDULICH",
            "Quản trị Khách sạn - QTRIKSAN",
            "Quản trị Nhân sự - QTRINHSU",
            "Quản trị Nhà nước - QTRINHNUC",
            "Quản lý Kinh doanh Điện tử - QLKDE",
            "Kinh doanh Bất động sản - KINBATD",
            "Quản trị Chuỗi cung ứng - QTRICU",
            "Kinh doanh và Thương mại Điện tử - KINVD",
            "Quản trị Hệ thống Thông tin Kinh doanh - QTRHTT"});
            this.comboBoxmajor.Location = new System.Drawing.Point(164, 616);
            this.comboBoxmajor.Name = "comboBoxmajor";
            this.comboBoxmajor.Size = new System.Drawing.Size(551, 35);
            this.comboBoxmajor.TabIndex = 21;
            this.comboBoxmajor.SelectedIndexChanged += new System.EventHandler(this.comboBoxmajor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "Major";
            // 
            // textBoxidcard
            // 
            this.textBoxidcard.Location = new System.Drawing.Point(164, 548);
            this.textBoxidcard.Name = "textBoxidcard";
            this.textBoxidcard.Size = new System.Drawing.Size(551, 33);
            this.textBoxidcard.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID Card";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(164, 465);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(551, 33);
            this.textBoxemail.TabIndex = 17;
            // 
            // textBoxnumberphone
            // 
            this.textBoxnumberphone.Location = new System.Drawing.Point(256, 400);
            this.textBoxnumberphone.Multiline = true;
            this.textBoxnumberphone.Name = "textBoxnumberphone";
            this.textBoxnumberphone.Size = new System.Drawing.Size(459, 33);
            this.textBoxnumberphone.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number Phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 315);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 33);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 315);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 33);
            this.textBox2.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ (thành phố trực thuộc trung ương)",
            "Cao Bằng",
            "Đà Nẵng (thành phố trực thuộc trung ương)",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội (thành phố trực thuộc trung ương)",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng (thành phố trực thuộc trung ương)",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.comboBox2.Location = new System.Drawing.Point(555, 315);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 35);
            this.comboBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Andress";
            // 
            // groupBoxgender
            // 
            this.groupBoxgender.Controls.Add(this.radioButton3);
            this.groupBoxgender.Controls.Add(this.radioButton2);
            this.groupBoxgender.Controls.Add(this.radioButton1);
            this.groupBoxgender.Location = new System.Drawing.Point(182, 148);
            this.groupBoxgender.Name = "groupBoxgender";
            this.groupBoxgender.Size = new System.Drawing.Size(533, 38);
            this.groupBoxgender.TabIndex = 7;
            this.groupBoxgender.TabStop = false;
            this.groupBoxgender.Enter += new System.EventHandler(this.groupBoxgender_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(373, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 31);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Diffirence";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 31);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 31);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // textfullname
            // 
            this.textfullname.AccessibleDescription = "n";
            this.textfullname.Location = new System.Drawing.Point(182, 79);
            this.textfullname.Name = "textfullname";
            this.textfullname.Size = new System.Drawing.Size(533, 33);
            this.textfullname.TabIndex = 6;
            // 
            // birthday
            // 
            this.birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(188, 239);
            this.birthday.Name = "birthday";
            this.birthday.ShowCheckBox = true;
            this.birthday.Size = new System.Drawing.Size(516, 37);
            this.birthday.TabIndex = 5;
            this.birthday.Value = new System.DateTime(2024, 5, 17, 18, 37, 0, 0);
            this.birthday.ValueChanged += new System.EventHandler(this.birthday_ValueChanged);
            // 
            // labelbirthday
            // 
            this.labelbirthday.AutoSize = true;
            this.labelbirthday.Location = new System.Drawing.Point(63, 239);
            this.labelbirthday.Name = "labelbirthday";
            this.labelbirthday.Size = new System.Drawing.Size(97, 27);
            this.labelbirthday.TabIndex = 3;
            this.labelbirthday.Text = "Birthday";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(63, 157);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(85, 27);
            this.labelgender.TabIndex = 2;
            this.labelgender.Text = "Gender";
            this.labelgender.Click += new System.EventHandler(this.labelgender_Click);
            // 
            // labelfullname
            // 
            this.labelfullname.AutoSize = true;
            this.labelfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfullname.Location = new System.Drawing.Point(63, 77);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(100, 25);
            this.labelfullname.TabIndex = 0;
            this.labelfullname.Text = "Fullname";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonupload
            // 
            this.buttonupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupload.Location = new System.Drawing.Point(916, 255);
            this.buttonupload.Name = "buttonupload";
            this.buttonupload.Size = new System.Drawing.Size(112, 38);
            this.buttonupload.TabIndex = 3;
            this.buttonupload.Text = "Upload";
            this.buttonupload.UseVisualStyleBackColor = true;
            this.buttonupload.Click += new System.EventHandler(this.buttonupload_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXIT.Location = new System.Drawing.Point(864, 613);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(218, 55);
            this.buttonEXIT.TabIndex = 4;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSAVE.Location = new System.Drawing.Point(864, 500);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(218, 55);
            this.buttonSAVE.TabIndex = 5;
            this.buttonSAVE.Tag = "";
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // pictureBoxgirl
            // 
            this.pictureBoxgirl.Image = global::Management_application.Properties.Resources.dfbouue_a609b605_d553_4450_b56e_9cd7073172311;
            this.pictureBoxgirl.Location = new System.Drawing.Point(864, 96);
            this.pictureBoxgirl.Name = "pictureBoxgirl";
            this.pictureBoxgirl.Size = new System.Drawing.Size(218, 153);
            this.pictureBoxgirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgirl.TabIndex = 6;
            this.pictureBoxgirl.TabStop = false;
            this.pictureBoxgirl.Click += new System.EventHandler(this.pictureBoxgirl_Click);
            // 
            // pictureBoxboy
            // 
            this.pictureBoxboy.Image = global::Management_application.Properties.Resources._71ROrdBqoGL1;
            this.pictureBoxboy.Location = new System.Drawing.Point(864, 96);
            this.pictureBoxboy.Name = "pictureBoxboy";
            this.pictureBoxboy.Size = new System.Drawing.Size(218, 153);
            this.pictureBoxboy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxboy.TabIndex = 6;
            this.pictureBoxboy.TabStop = false;
            this.pictureBoxboy.Click += new System.EventHandler(this.pictureBoxboy_Click);
            // 
            // pictureavt
            // 
            this.pictureavt.AccessibleName = "";
            this.pictureavt.BackColor = System.Drawing.Color.White;
            this.pictureavt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureavt.Image = global::Management_application.Properties.Resources._15825212694842;
            this.pictureavt.Location = new System.Drawing.Point(864, 96);
            this.pictureavt.Name = "pictureavt";
            this.pictureavt.Size = new System.Drawing.Size(218, 153);
            this.pictureavt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureavt.TabIndex = 2;
            this.pictureavt.TabStop = false;
            this.pictureavt.Click += new System.EventHandler(this.pictureavt_Click);
            // 
            // Addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 724);
            this.Controls.Add(this.pictureBoxgirl);
            this.Controls.Add(this.pictureBoxboy);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonupload);
            this.Controls.Add(this.pictureavt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Addstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.Addstudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxgender.ResumeLayout(false);
            this.groupBoxgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxboy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureavt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelbirthday;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox textfullname;
        private System.Windows.Forms.GroupBox groupBoxgender;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxnumberphone;
        private System.Windows.Forms.TextBox textBoxidcard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonupload;
        private System.Windows.Forms.PictureBox pictureavt;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.ComboBox comboBoxmajor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxgirl;
        private System.Windows.Forms.PictureBox pictureBoxboy;
    }
}