namespace Balkan_Wings_1
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picture_my_profile = new System.Windows.Forms.PictureBox();
            this.picture_logout = new System.Windows.Forms.PictureBox();
            this.Main_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_my_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F);
            this.label1.Location = new System.Drawing.Point(225, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello,";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label_name.Location = new System.Drawing.Point(232, 131);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(307, 48);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name Surname";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(187)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picture_my_profile);
            this.groupBox1.Controls.Add(this.picture_logout);
            this.groupBox1.Controls.Add(this.Main_logo);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, -20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label2.Location = new System.Drawing.Point(770, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "My profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label3.Location = new System.Drawing.Point(908, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Logout";
            // 
            // picture_my_profile
            // 
            this.picture_my_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_my_profile.Image = global::Balkan_Wings_1.Properties.Resources.my_profile;
            this.picture_my_profile.Location = new System.Drawing.Point(775, 99);
            this.picture_my_profile.Name = "picture_my_profile";
            this.picture_my_profile.Size = new System.Drawing.Size(83, 80);
            this.picture_my_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_my_profile.TabIndex = 4;
            this.picture_my_profile.TabStop = false;
            this.picture_my_profile.Click += new System.EventHandler(this.picture_my_profile_Click);
            // 
            // picture_logout
            // 
            this.picture_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_logout.Image = global::Balkan_Wings_1.Properties.Resources.exit;
            this.picture_logout.Location = new System.Drawing.Point(898, 99);
            this.picture_logout.Name = "picture_logout";
            this.picture_logout.Size = new System.Drawing.Size(83, 80);
            this.picture_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_logout.TabIndex = 3;
            this.picture_logout.TabStop = false;
            this.picture_logout.Click += new System.EventHandler(this.picture_logout_Click);
            // 
            // Main_logo
            // 
            this.Main_logo.Image = global::Balkan_Wings_1.Properties.Resources.logo;
            this.Main_logo.Location = new System.Drawing.Point(15, 32);
            this.Main_logo.Name = "Main_logo";
            this.Main_logo.Size = new System.Drawing.Size(204, 191);
            this.Main_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_logo.TabIndex = 2;
            this.Main_logo.TabStop = false;
            // 
            // dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1023, 672);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_my_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox Main_logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picture_logout;
        private System.Windows.Forms.PictureBox picture_my_profile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}