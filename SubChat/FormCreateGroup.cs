using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubChat
{
    public partial class FormCreateGroup : Form
    {
        public FormCreateGroup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEsc_Click(object sender, EventArgs e)
        {
            Close();
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
            lbUsers.Items.Clear();
            foreach(string tmpUser in foundUsers){
                lbUsers.Items.Add(tmpUser);
            }
        }

        private void btnAddUserInGroup_Click(object sender, EventArgs e)
        {
            foreach(var tmp in lbUsers.SelectedItems)
            {
                lbUsersInGroup.Items.Add(tmp);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lbUsersInGroup.SelectedItems.Count - 1; i >= 0; i--)
                lbUsersInGroup.Items.Remove(lbUsersInGroup.SelectedItems[i]);
        }

        private void btnCreateNewGroup_Click(object sender, EventArgs e)
        {
            lbUsers.ClearSelected();

            List<string> newGroup = new List<string>();
            foreach (var tmp in lbUsersInGroup.Items)
            {
                newGroup.Add(tmp.ToString());
            }

            // TODO create new group chat
        }
    }
}
