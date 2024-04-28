using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balkan_Wings_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {

            signup signup = new signup();

            if (signup.ShowDialog() == DialogResult.OK)
            {


            }

        }

        private void sing_up_picture_Click(object sender, EventArgs e)
        {
            signup signup = new signup();

            if (signup.ShowDialog() == DialogResult.OK)
            {


            }

        }
    }
}
