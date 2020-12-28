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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            // TODO
            // Check1: does that user exists 
            // Check2: does he input right password

            //if(check1 & check2)
            Form2 MainWindow = new Form2(username);
            MainWindow.Show();
            this.Hide();
            

            //else
            /*
            string msg = "You need to register first!";
            string title = "Logging fails";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBox.Show(msg, title,buttons, MessageBoxIcon.Warning);
            */
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            // TODO
            // Add new user in data base of all users [ send username and password ]

            Form MainWindow = new Form2(username);
            MainWindow.Show();
            this.Hide();
            
        }

        private void lblEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
