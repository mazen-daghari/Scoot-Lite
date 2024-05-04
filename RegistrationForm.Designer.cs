namespace learnFireBase
{
    partial class RegistrationForm
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
            this.regBtn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.UsernameTbox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.GenderCbox = new System.Windows.Forms.ComboBox();
            this.nicLabel = new System.Windows.Forms.Label();
            this.NicTbox = new System.Windows.Forms.TextBox();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.label1 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.Location = new System.Drawing.Point(134, 417);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(125, 38);
            this.regBtn.TabIndex = 9;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(129, 109);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(114, 25);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(129, 28);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(118, 25);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Username";
            // 
            // passTbox
            // 
            this.passTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTbox.Location = new System.Drawing.Point(94, 137);
            this.passTbox.Name = "passTbox";
            this.passTbox.Size = new System.Drawing.Size(188, 29);
            this.passTbox.TabIndex = 6;
            // 
            // UsernameTbox
            // 
            this.UsernameTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTbox.Location = new System.Drawing.Point(94, 56);
            this.UsernameTbox.Name = "UsernameTbox";
            this.UsernameTbox.Size = new System.Drawing.Size(188, 29);
            this.UsernameTbox.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(140, 195);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(89, 25);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(129, 271);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(108, 25);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Fullname";
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbox.Location = new System.Drawing.Point(94, 299);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(188, 29);
            this.nameTbox.TabIndex = 12;
            // 
            // GenderCbox
            // 
            this.GenderCbox.FormattingEnabled = true;
            this.GenderCbox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCbox.Location = new System.Drawing.Point(94, 223);
            this.GenderCbox.Name = "GenderCbox";
            this.GenderCbox.Size = new System.Drawing.Size(188, 21);
            this.GenderCbox.TabIndex = 14;
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLabel.Location = new System.Drawing.Point(129, 342);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(134, 25);
            this.nicLabel.TabIndex = 16;
            this.nicLabel.Text = "Nic Number";
            // 
            // NicTbox
            // 
            this.NicTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicTbox.Location = new System.Drawing.Point(94, 370);
            this.NicTbox.Name = "NicTbox";
            this.NicTbox.Size = new System.Drawing.Size(188, 29);
            this.NicTbox.TabIndex = 15;
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Material;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.SteelBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.LightGray;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(428, 555);
            this.xuiFormDesign1.TabIndex = 17;
            this.xuiFormDesign1.TitleText = "Registration Form";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.t4);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.t5);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.t1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.t3);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.t2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label5);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label4);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label3);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.button1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(428, 481);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            this.xuiFormDesign1.WorkingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiFormDesign1_WorkingArea_Paint);
            this.xuiFormDesign1.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiFormDesign1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nic Number";
            // 
            // t5
            // 
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.Location = new System.Drawing.Point(109, 355);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(188, 29);
            this.t5.TabIndex = 26;
            // 
            // t3
            // 
            this.t3.FormattingEnabled = true;
            this.t3.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.t3.Location = new System.Drawing.Point(109, 208);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(188, 21);
            this.t3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fullname";
            // 
            // t4
            // 
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.Location = new System.Drawing.Point(109, 284);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(188, 29);
            this.t4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Username";
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(109, 122);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(188, 29);
            this.t2.TabIndex = 18;
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(109, 41);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(188, 29);
            this.t1.TabIndex = 17;
            this.t1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 555);
            this.Controls.Add(this.xuiFormDesign1);
            this.Controls.Add(this.nicLabel);
            this.Controls.Add(this.NicTbox);
            this.Controls.Add(this.GenderCbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passTbox);
            this.Controls.Add(this.UsernameTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.TextBox UsernameTbox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.ComboBox GenderCbox;
        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.TextBox NicTbox;
        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.ComboBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}