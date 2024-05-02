namespace Balkan_Wings_1
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_card_number = new System.Windows.Forms.TextBox();
            this.tb_name_on_card = new System.Windows.Forms.TextBox();
            this.tb_sec_code = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_paynow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_num_flight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.picture_back = new System.Windows.Forms.PictureBox();
            this.tb_date = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Balkan_Wings_1.Properties.Resources.payment;
            this.pictureBox1.Location = new System.Drawing.Point(136, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tb_card_number
            // 
            this.tb_card_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_card_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_card_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_card_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_card_number.Location = new System.Drawing.Point(26, 255);
            this.tb_card_number.Name = "tb_card_number";
            this.tb_card_number.Size = new System.Drawing.Size(302, 28);
            this.tb_card_number.TabIndex = 10;
            this.tb_card_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_card_number.TextChanged += new System.EventHandler(this.tb_card_number_TextChanged);
            // 
            // tb_name_on_card
            // 
            this.tb_name_on_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_name_on_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name_on_card.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name_on_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_name_on_card.Location = new System.Drawing.Point(26, 329);
            this.tb_name_on_card.Name = "tb_name_on_card";
            this.tb_name_on_card.Size = new System.Drawing.Size(302, 28);
            this.tb_name_on_card.TabIndex = 11;
            this.tb_name_on_card.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sec_code
            // 
            this.tb_sec_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_sec_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sec_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sec_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_sec_code.Location = new System.Drawing.Point(210, 405);
            this.tb_sec_code.Name = "tb_sec_code";
            this.tb_sec_code.Size = new System.Drawing.Size(118, 28);
            this.tb_sec_code.TabIndex = 13;
            this.tb_sec_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(21, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "Card number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name on card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(22, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Expiry date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(206, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Security code";
            // 
            // bt_paynow
            // 
            this.bt_paynow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.bt_paynow.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_paynow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_paynow.Location = new System.Drawing.Point(25, 567);
            this.bt_paynow.Name = "bt_paynow";
            this.bt_paynow.Size = new System.Drawing.Size(303, 48);
            this.bt_paynow.TabIndex = 36;
            this.bt_paynow.Text = "Pay now";
            this.bt_paynow.UseVisualStyleBackColor = false;
            this.bt_paynow.Click += new System.EventHandler(this.bt_paynow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Controls.Add(this.lb_num_flight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Location = new System.Drawing.Point(25, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 90);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lb_total.Location = new System.Drawing.Point(216, 60);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(76, 24);
            this.lb_total.TabIndex = 41;
            this.lb_total.Text = "123456";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_num_flight
            // 
            this.lb_num_flight.AutoSize = true;
            this.lb_num_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_num_flight.Location = new System.Drawing.Point(220, 18);
            this.lb_num_flight.Name = "lb_num_flight";
            this.lb_num_flight.Size = new System.Drawing.Size(63, 20);
            this.lb_num_flight.TabIndex = 40;
            this.lb_num_flight.Text = "123456";
            this.lb_num_flight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "TOTAL:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb.Location = new System.Drawing.Point(6, 18);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(138, 20);
            this.lb.TabIndex = 38;
            this.lb.Text = "Number of Flight:";
            // 
            // picture_back
            // 
            this.picture_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_back.Image = global::Balkan_Wings_1.Properties.Resources.back;
            this.picture_back.Location = new System.Drawing.Point(298, 12);
            this.picture_back.Name = "picture_back";
            this.picture_back.Size = new System.Drawing.Size(44, 41);
            this.picture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_back.TabIndex = 38;
            this.picture_back.TabStop = false;
            this.picture_back.Click += new System.EventHandler(this.picture_back_Click);
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.tb_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_date.Location = new System.Drawing.Point(25, 405);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(100, 28);
            this.tb_date.TabIndex = 39;
            this.tb_date.Text = "mm/yyyy";
            this.tb_date.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(354, 632);
            this.ControlBox = false;
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.picture_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_paynow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_sec_code);
            this.Controls.Add(this.tb_name_on_card);
            this.Controls.Add(this.tb_card_number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_card_number;
        private System.Windows.Forms.TextBox tb_name_on_card;
        private System.Windows.Forms.TextBox tb_sec_code;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_paynow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_num_flight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_back;
        private System.Windows.Forms.MaskedTextBox tb_date;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}