using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubChat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClsoe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindUser_MouseHover(object sender, EventArgs e)
        {
            labelFindUser.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnCreateGroup_MouseHover(object sender, EventArgs e)
        {
            labelCreateGroup.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnAddSub_MouseHover(object sender, EventArgs e)
        {
            labelAddSub.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnFilter_MouseHover(object sender, EventArgs e)
        {
            labelFilterSub.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnFindUser_MouseLeave(object sender, EventArgs e)
        {
            labelFindUser.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnCreateGroup_MouseLeave(object sender, EventArgs e)
        {
            labelCreateGroup.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnAddSub_MouseLeave(object sender, EventArgs e)
        {
            labelAddSub.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnFilter_MouseLeave(object sender, EventArgs e)
        {
            labelFilterSub.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
