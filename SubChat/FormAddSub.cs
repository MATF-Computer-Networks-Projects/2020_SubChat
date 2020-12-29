using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubChat
{
    public partial class FormAddSub : Form
    {
        public FormAddSub()
        {
            InitializeComponent();
        }

       
        private void btnClsoe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            lbSelect.ForeColor = Color.FromArgb(78, 184, 206);
            labelSelect.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void lbSelect_MouseLeave(object sender, EventArgs e)
        {
            lbSelect.ForeColor = Color.FromArgb(255, 255, 255);
            labelSelect.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            tbAdd.Clear();
            tbAdd.ForeColor = Color.FromArgb(255, 255, 255);
            panelAdd.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
    
}
