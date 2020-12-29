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
    }
}
