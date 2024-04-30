namespace Balkan_Wings_1
{
    partial class bookflight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookflight));
            this.picture_back = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_book_flight = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_flight_num_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_f_num = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_from_time = new System.Windows.Forms.TextBox();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_avail = new System.Windows.Forms.TextBox();
            this.tb_num_seats = new System.Windows.Forms.TextBox();
            this.tb_aircraft = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_to_time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_pas = new System.Windows.Forms.TextBox();
            this.tb_total_price = new System.Windows.Forms.TextBox();
            this.num_ticket = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bt_book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_book_flight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_back
            // 
            this.picture_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_back.Image = global::Balkan_Wings_1.Properties.Resources.back;
            this.picture_back.Location = new System.Drawing.Point(967, 46);
            this.picture_back.Name = "picture_back";
            this.picture_back.Size = new System.Drawing.Size(44, 41);
            this.picture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_back.TabIndex = 4;
            this.picture_back.TabStop = false;
            this.picture_back.Click += new System.EventHandler(this.picture_back_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book a Flight";
            // 
            // picture_book_flight
            // 
            this.picture_book_flight.Image = global::Balkan_Wings_1.Properties.Resources.book_flight;
            this.picture_book_flight.Location = new System.Drawing.Point(22, 28);
            this.picture_book_flight.Name = "picture_book_flight";
            this.picture_book_flight.Size = new System.Drawing.Size(60, 59);
            this.picture_book_flight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_book_flight.TabIndex = 9;
            this.picture_book_flight.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.groupBox1.Controls.Add(this.bt_book);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 552);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tb_flight_num_search
            // 
            this.tb_flight_num_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_flight_num_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_flight_num_search.Location = new System.Drawing.Point(803, 198);
            this.tb_flight_num_search.Name = "tb_flight_num_search";
            this.tb_flight_num_search.Size = new System.Drawing.Size(199, 30);
            this.tb_flight_num_search.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label2.Location = new System.Drawing.Point(799, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Flight Number:";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search.Location = new System.Drawing.Point(894, 246);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(108, 38);
            this.bt_search.TabIndex = 13;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Arial Black", 15F);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.label_name.Location = new System.Drawing.Point(6, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(712, 37);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Flight details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_to_time);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.tb_aircraft);
            this.groupBox2.Controls.Add(this.tb_num_seats);
            this.groupBox2.Controls.Add(this.tb_avail);
            this.groupBox2.Controls.Add(this.tb_to);
            this.groupBox2.Controls.Add(this.tb_from_time);
            this.groupBox2.Controls.Add(this.tb_from);
            this.groupBox2.Controls.Add(this.tb_f_num);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tb_f_num
            // 
            this.tb_f_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_f_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_f_num.Location = new System.Drawing.Point(23, 31);
            this.tb_f_num.Name = "tb_f_num";
            this.tb_f_num.ReadOnly = true;
            this.tb_f_num.Size = new System.Drawing.Size(60, 26);
            this.tb_f_num.TabIndex = 0;
            // 
            // tb_from
            // 
            this.tb_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_from.Location = new System.Drawing.Point(118, 31);
            this.tb_from.Name = "tb_from";
            this.tb_from.ReadOnly = true;
            this.tb_from.Size = new System.Drawing.Size(145, 26);
            this.tb_from.TabIndex = 1;
            // 
            // tb_from_time
            // 
            this.tb_from_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_from_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_from_time.Location = new System.Drawing.Point(118, 81);
            this.tb_from_time.Name = "tb_from_time";
            this.tb_from_time.ReadOnly = true;
            this.tb_from_time.Size = new System.Drawing.Size(98, 26);
            this.tb_from_time.TabIndex = 2;
            // 
            // tb_to
            // 
            this.tb_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_to.Location = new System.Drawing.Point(290, 31);
            this.tb_to.Name = "tb_to";
            this.tb_to.ReadOnly = true;
            this.tb_to.Size = new System.Drawing.Size(145, 26);
            this.tb_to.TabIndex = 3;
            // 
            // tb_avail
            // 
            this.tb_avail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_avail.Location = new System.Drawing.Point(612, 81);
            this.tb_avail.Name = "tb_avail";
            this.tb_avail.ReadOnly = true;
            this.tb_avail.Size = new System.Drawing.Size(68, 26);
            this.tb_avail.TabIndex = 5;
            // 
            // tb_num_seats
            // 
            this.tb_num_seats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_num_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_num_seats.Location = new System.Drawing.Point(535, 81);
            this.tb_num_seats.Name = "tb_num_seats";
            this.tb_num_seats.ReadOnly = true;
            this.tb_num_seats.Size = new System.Drawing.Size(68, 26);
            this.tb_num_seats.TabIndex = 6;
            // 
            // tb_aircraft
            // 
            this.tb_aircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_aircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_aircraft.Location = new System.Drawing.Point(535, 31);
            this.tb_aircraft.Name = "tb_aircraft";
            this.tb_aircraft.ReadOnly = true;
            this.tb_aircraft.Size = new System.Drawing.Size(145, 26);
            this.tb_aircraft.TabIndex = 7;
            // 
            // tb_price
            // 
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_price.Location = new System.Drawing.Point(570, 147);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(110, 26);
            this.tb_price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departure Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Arrival Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aircraft Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Departure Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Arrival Time";
            // 
            // tb_to_time
            // 
            this.tb_to_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_to_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_to_time.Location = new System.Drawing.Point(290, 81);
            this.tb_to_time.Name = "tb_to_time";
            this.tb_to_time.ReadOnly = true;
            this.tb_to_time.Size = new System.Drawing.Size(98, 26);
            this.tb_to_time.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Free";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Seats status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(566, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial Black", 15F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.label13.Location = new System.Drawing.Point(6, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(712, 37);
            this.label13.TabIndex = 4;
            this.label13.Text = "Personal details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.num_ticket);
            this.groupBox3.Controls.Add(this.tb_total_price);
            this.groupBox3.Controls.Add(this.tb_pas);
            this.groupBox3.Controls.Add(this.tb_phone);
            this.groupBox3.Controls.Add(this.tb_email);
            this.groupBox3.Controls.Add(this.tb_surname);
            this.groupBox3.Controls.Add(this.tb_name);
            this.groupBox3.Location = new System.Drawing.Point(12, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_name.Location = new System.Drawing.Point(23, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(145, 26);
            this.tb_name.TabIndex = 20;
            // 
            // tb_surname
            // 
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_surname.Location = new System.Drawing.Point(196, 32);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.ReadOnly = true;
            this.tb_surname.Size = new System.Drawing.Size(145, 26);
            this.tb_surname.TabIndex = 21;
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_email.Location = new System.Drawing.Point(23, 79);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(145, 26);
            this.tb_email.TabIndex = 22;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_phone.Location = new System.Drawing.Point(196, 79);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(145, 26);
            this.tb_phone.TabIndex = 23;
            // 
            // tb_pas
            // 
            this.tb_pas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_pas.Location = new System.Drawing.Point(23, 128);
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(145, 26);
            this.tb_pas.TabIndex = 24;
            // 
            // tb_total_price
            // 
            this.tb_total_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_total_price.Location = new System.Drawing.Point(570, 128);
            this.tb_total_price.Name = "tb_total_price";
            this.tb_total_price.ReadOnly = true;
            this.tb_total_price.Size = new System.Drawing.Size(110, 26);
            this.tb_total_price.TabIndex = 20;
            // 
            // num_ticket
            // 
            this.num_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.num_ticket.Location = new System.Drawing.Point(612, 79);
            this.num_ticket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ticket.Name = "num_ticket";
            this.num_ticket.Size = new System.Drawing.Size(68, 26);
            this.num_ticket.TabIndex = 25;
            this.num_ticket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ticket.ValueChanged += new System.EventHandler(this.num_ticket_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "First name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Surname";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "E-mail";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(194, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "Phone number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Passport number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(493, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Number of tickets:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(441, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "TOTAL PRICE:";
            // 
            // bt_book
            // 
            this.bt_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(93)))));
            this.bt_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_book.Font = new System.Drawing.Font("Arial Black", 7.5F);
            this.bt_book.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_book.Location = new System.Drawing.Point(461, 504);
            this.bt_book.Name = "bt_book";
            this.bt_book.Size = new System.Drawing.Size(243, 38);
            this.bt_book.TabIndex = 15;
            this.bt_book.Text = "Book";
            this.bt_book.UseVisualStyleBackColor = false;
            this.bt_book.Click += new System.EventHandler(this.bt_book_Click);
            // 
            // bookflight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1023, 672);
            this.ControlBox = false;
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_flight_num_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picture_book_flight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bookflight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book a Flight";
            this.Load += new System.EventHandler(this.bookflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_book_flight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_book_flight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_flight_num_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox tb_f_num;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_from_time;
        private System.Windows.Forms.TextBox tb_aircraft;
        private System.Windows.Forms.TextBox tb_num_seats;
        private System.Windows.Forms.TextBox tb_avail;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_to_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_book;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown num_ticket;
        private System.Windows.Forms.TextBox tb_total_price;
        private System.Windows.Forms.TextBox tb_pas;
    }
}