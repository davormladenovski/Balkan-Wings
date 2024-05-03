namespace Balkan_Wings_1
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.bt_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.error_non_digit = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_show_pass = new System.Windows.Forms.PictureBox();
            this.error_empty = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_non_digit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_name.Location = new System.Drawing.Point(30, 212);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(120, 28);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "First name";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_surname.Location = new System.Drawing.Point(199, 212);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(120, 28);
            this.tb_surname.TabIndex = 2;
            this.tb_surname.Text = "Surname";
            this.tb_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_surname_KeyPress);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_email.Location = new System.Drawing.Point(74, 281);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 28);
            this.tb_email.TabIndex = 3;
            this.tb_email.Text = "E-Mail";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_email_KeyPress);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_pass.Location = new System.Drawing.Point(74, 338);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(200, 28);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.Text = "Password";
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_phone.Location = new System.Drawing.Point(74, 396);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(200, 28);
            this.tb_phone.TabIndex = 5;
            this.tb_phone.Text = "Phone number";
            this.tb_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            // 
            // bt_signup
            // 
            this.bt_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.bt_signup.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_signup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_signup.Location = new System.Drawing.Point(113, 459);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(124, 48);
            this.bt_signup.TabIndex = 6;
            this.bt_signup.Text = "Sign Up";
            this.bt_signup.UseVisualStyleBackColor = false;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(43, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Already have an account ?";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_login.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lb_login.Location = new System.Drawing.Point(264, 533);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(60, 24);
            this.lb_login.TabIndex = 9;
            this.lb_login.Text = "Login";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // error_non_digit
            // 
            this.error_non_digit.ContainerControl = this;
            // 
            // error_email
            // 
            this.error_email.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Balkan_Wings_1.Properties.Resources.signup_icon;
            this.pictureBox1.Location = new System.Drawing.Point(137, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picture_show_pass
            // 
            this.picture_show_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_show_pass.Image = global::Balkan_Wings_1.Properties.Resources.show_pass;
            this.picture_show_pass.Location = new System.Drawing.Point(280, 338);
            this.picture_show_pass.Name = "picture_show_pass";
            this.picture_show_pass.Size = new System.Drawing.Size(27, 28);
            this.picture_show_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_show_pass.TabIndex = 10;
            this.picture_show_pass.TabStop = false;
            this.picture_show_pass.Click += new System.EventHandler(this.picture_show_pass_Click);
            // 
            // error_empty
            // 
            this.error_empty.ContainerControl = this;
            // 
            // signup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(354, 586);
            this.Controls.Add(this.picture_show_pass);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_non_digit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.ErrorProvider error_non_digit;
        private System.Windows.Forms.ErrorProvider error_email;
        private System.Windows.Forms.PictureBox picture_show_pass;
        private System.Windows.Forms.ErrorProvider error_empty;
    }
}