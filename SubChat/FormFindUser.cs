using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubChat
{
    public partial class FormFindUser : Form
    {
        public FormFindUser()
        {
            InitializeComponent();
        }

      
        private void lblEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            panelUsername.ForeColor = Color.FromArgb(78, 184, 206);
            tbUsername.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Load username from tbUsername
            string username = tbUsername.Text.Trim();

            // Search for loaded username in file with all users
            // TODO serch_user(string username)
            //      return value: list of found usernames(strings)

            // Just for testing:
            List<string> foundUsers = new List<string>();
            foundUsers.Add("user123");
            foundUsers.Add("USER123");
            foundUsers.Add("uSeR123");


            // Put all found users in lbUsers
            lbFoundUsers.Items.Clear();
            foreach (string tmpUser in foundUsers)
            {
                lbFoundUsers.Items.Add(tmpUser);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO Add new user to contacts
        }
    }
}
