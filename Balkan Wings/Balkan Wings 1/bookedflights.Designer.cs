namespace Balkan_Wings_1
{
    partial class bookedflights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookedflights));
            this.label1 = new System.Windows.Forms.Label();
            this.booked_flights_data_grid = new System.Windows.Forms.DataGridView();
            this.bt_pay = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_flight_num_search = new System.Windows.Forms.TextBox();
            this.picture_book_flight = new System.Windows.Forms.PictureBox();
            this.picture_back = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booked_flights_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_book_flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "My Booked Flights";
            // 
            // booked_flights_data_grid
            // 
            this.booked_flights_data_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.booked_flights_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booked_flights_data_grid.GridColor = System.Drawing.SystemColors.Control;
            this.booked_flights_data_grid.Location = new System.Drawing.Point(22, 93);
            this.booked_flights_data_grid.MultiSelect = false;
            this.booked_flights_data_grid.Name = "booked_flights_data_grid";
            this.booked_flights_data_grid.ReadOnly = true;
            this.booked_flights_data_grid.RowHeadersWidth = 51;
            this.booked_flights_data_grid.RowTemplate.Height = 24;
            this.booked_flights_data_grid.Size = new System.Drawing.Size(724, 552);
            this.booked_flights_data_grid.TabIndex = 13;
            // 
            // bt_pay
            // 
            this.bt_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pay.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_pay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_pay.Location = new System.Drawing.Point(763, 607);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(243, 38);
            this.bt_pay.TabIndex = 16;
            this.bt_pay.Text = "Payment";
            this.bt_pay.UseVisualStyleBackColor = false;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search.Location = new System.Drawing.Point(898, 259);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(108, 38);
            this.bt_search.TabIndex = 19;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label2.Location = new System.Drawing.Point(803, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Flight Number:";
            // 
            // tb_flight_num_search
            // 
            this.tb_flight_num_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_flight_num_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_flight_num_search.Location = new System.Drawing.Point(807, 211);
            this.tb_flight_num_search.Name = "tb_flight_num_search";
            this.tb_flight_num_search.Size = new System.Drawing.Size(199, 30);
            this.tb_flight_num_search.TabIndex = 17;
            // 
            // picture_book_flight
            // 
            this.picture_book_flight.Image = global::Balkan_Wings_1.Properties.Resources.booked_flights;
            this.picture_book_flight.Location = new System.Drawing.Point(22, 28);
            this.picture_book_flight.Name = "picture_book_flight";
            this.picture_book_flight.Size = new System.Drawing.Size(60, 59);
            this.picture_book_flight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_book_flight.TabIndex = 12;
            this.picture_book_flight.TabStop = false;
            // 
            // picture_back
            // 
            this.picture_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_back.Image = global::Balkan_Wings_1.Properties.Resources.back;
            this.picture_back.Location = new System.Drawing.Point(967, 46);
            this.picture_back.Name = "picture_back";
            this.picture_back.Size = new System.Drawing.Size(44, 41);
            this.picture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_back.TabIndex = 10;
            this.picture_back.TabStop = false;
            this.picture_back.Click += new System.EventHandler(this.picture_back_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 8F);
            this.label4.Location = new System.Drawing.Point(763, 563);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(250, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "You can only make a payment on one flight!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bookedflights
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1023, 672);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_flight_num_search);
            this.Controls.Add(this.bt_pay);
            this.Controls.Add(this.booked_flights_data_grid);
            this.Controls.Add(this.picture_book_flight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bookedflights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Booked Flights";
            this.Load += new System.EventHandler(this.bookedflights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booked_flights_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_book_flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_book_flight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_back;
        private System.Windows.Forms.DataGridView booked_flights_data_grid;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_flight_num_search;
        private System.Windows.Forms.Label label4;
    }
}