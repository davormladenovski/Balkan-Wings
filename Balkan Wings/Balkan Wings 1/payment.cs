using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Balkan_Wings_1
{
    public partial class payment : Form
    {
        public booked_flight current_booked_flight;
        public payment(booked_flight bookedflights)
        {
            InitializeComponent();
            
            current_booked_flight = bookedflights;
            
            toolTip1.SetToolTip(tb_date, "Enter the expiration date in MM/yyyy format");
        }

        private void payment_Load(object sender, EventArgs e)
        {
            lb_num_flight.Text = current_booked_flight.flight.FlightNumber;
            lb_total.Text = (current_booked_flight.num_tickets * current_booked_flight.flight.Price).ToString()+" $";
        }

        private void bt_paynow_Click(object sender, EventArgs e)
        {
            string creditCardNumber = tb_card_number.Text.Trim();
            string expirationDate = tb_date.Text;
            string cvv = tb_sec_code.Text.Trim();
            string name = tb_name_on_card.Text;

            if  (IsValidCVV(cvv) && IsExpirationDateValid(expirationDate) && !string.IsNullOrEmpty(creditCardNumber) && !string.IsNullOrEmpty(name) )
            {
                
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Payment failed. Please check your payment details and try again.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool IsValidCVV(string cvv)
        {
            return cvv.Length == 3 && cvv.All(char.IsDigit);
        }

        private bool IsExpirationDateValid(string expirationDate)
        {
           
            if (DateTime.TryParseExact(expirationDate, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

               
                if (int.TryParse(expirationDate.Substring(0, 2), out int enteredMonth) && int.TryParse(expirationDate.Substring(3), out int enteredYear))
                {
                    
                    return enteredMonth >= 1 && enteredMonth <= 12 && enteredYear >= currentYear && (enteredYear != currentYear || enteredMonth >= currentMonth);
                }
            }
            return false;
        }

        private void picture_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_card_number_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
