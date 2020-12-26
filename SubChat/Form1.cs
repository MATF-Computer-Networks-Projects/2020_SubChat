using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            panelUsername.ForeColor = Color.FromArgb(78, 184, 206);
            tbUsername.ForeColor = Color.FromArgb(78, 184, 206);

        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
            tbPassword.PasswordChar = '*';
            panelPassword.ForeColor = Color.FromArgb(78, 184, 206);
            tbPassword.ForeColor = Color.FromArgb(78, 184, 206);
        }
    }
}
