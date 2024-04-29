namespace Balkan_Wings_1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lb_signup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_show_pass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error_empty = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_signup.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lb_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lb_signup.Location = new System.Drawing.Point(220, 409);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(81, 24);
            this.lb_signup.TabIndex = 20;
            this.lb_signup.Text = "Sign Up";
            this.lb_signup.Click += new System.EventHandler(this.lb_signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(57, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Create an account ?";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.bt_login.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_login.Location = new System.Drawing.Point(119, 328);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(124, 48);
            this.bt_login.TabIndex = 17;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_pass.Location = new System.Drawing.Point(80, 270);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(200, 28);
            this.tb_pass.TabIndex = 15;
            this.tb_pass.Text = "Password";
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_email.Location = new System.Drawing.Point(80, 213);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 28);
            this.tb_email.TabIndex = 14;
            this.tb_email.Text = "E-Mail";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_email_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(119, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // picture_show_pass
            // 
            this.picture_show_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_show_pass.Image = global::Balkan_Wings_1.Properties.Resources.show_pass;
            this.picture_show_pass.Location = new System.Drawing.Point(286, 270);
            this.picture_show_pass.Name = "picture_show_pass";
            this.picture_show_pass.Size = new System.Drawing.Size(27, 28);
            this.picture_show_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_show_pass.TabIndex = 21;
            this.picture_show_pass.TabStop = false;
            this.picture_show_pass.Click += new System.EventHandler(this.picture_show_pass_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Balkan_Wings_1.Properties.Resources.login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(143, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // error_empty
            // 
            this.error_empty.ContainerControl = this;
            // 
            // error_email
            // 
            this.error_email.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(354, 481);
            this.Controls.Add(this.picture_show_pass);
            this.Controls.Add(this.lb_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picture_show_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_show_pass;
        private System.Windows.Forms.Label lb_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error_empty;
        private System.Windows.Forms.ErrorProvider error_email;
    }
}