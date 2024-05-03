namespace Balkan_Wings_1
{
    partial class searchflight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchflight));
            this.label1 = new System.Windows.Forms.Label();
            this.fligts_data_grid = new System.Windows.Forms.DataGridView();
            this.box_from = new System.Windows.Forms.ComboBox();
            this.box_to = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fligts_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for Flight";
            // 
            // fligts_data_grid
            // 
            this.fligts_data_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.fligts_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fligts_data_grid.GridColor = System.Drawing.SystemColors.Control;
            this.fligts_data_grid.Location = new System.Drawing.Point(22, 93);
            this.fligts_data_grid.Name = "fligts_data_grid";
            this.fligts_data_grid.ReadOnly = true;
            this.fligts_data_grid.RowHeadersWidth = 51;
            this.fligts_data_grid.RowTemplate.Height = 24;
            this.fligts_data_grid.Size = new System.Drawing.Size(724, 552);
            this.fligts_data_grid.TabIndex = 7;
            // 
            // box_from
            // 
            this.box_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_from.FormattingEnabled = true;
            this.box_from.Location = new System.Drawing.Point(864, 198);
            this.box_from.Name = "box_from";
            this.box_from.Size = new System.Drawing.Size(147, 28);
            this.box_from.TabIndex = 8;
            // 
            // box_to
            // 
            this.box_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_to.FormattingEnabled = true;
            this.box_to.Location = new System.Drawing.Point(864, 254);
            this.box_to.Name = "box_to";
            this.box_to.Size = new System.Drawing.Size(147, 28);
            this.box_to.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label2.Location = new System.Drawing.Point(793, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label3.Location = new System.Drawing.Point(793, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "To:";
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clear.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_clear.Location = new System.Drawing.Point(903, 409);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(108, 38);
            this.bt_clear.TabIndex = 13;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 8F);
            this.label4.Location = new System.Drawing.Point(756, 476);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(255, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "If you want to make a flight reservation\r\nyou must remember its number!\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search.Location = new System.Drawing.Point(903, 346);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(108, 38);
            this.bt_search.TabIndex = 12;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Balkan_Wings_1.Properties.Resources.search_flights;
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picture_back
            // 
            this.picture_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_back.Image = global::Balkan_Wings_1.Properties.Resources.back;
            this.picture_back.Location = new System.Drawing.Point(967, 46);
            this.picture_back.Name = "picture_back";
            this.picture_back.Size = new System.Drawing.Size(44, 41);
            this.picture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_back.TabIndex = 3;
            this.picture_back.TabStop = false;
            this.picture_back.Click += new System.EventHandler(this.picture_back_Click);
            // 
            // searchflight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1023, 672);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_to);
            this.Controls.Add(this.box_from);
            this.Controls.Add(this.fligts_data_grid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchflight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search for Flight";
            this.Load += new System.EventHandler(this.searchflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fligts_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView fligts_data_grid;
        private System.Windows.Forms.ComboBox box_from;
        private System.Windows.Forms.ComboBox box_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_search;
    }
}