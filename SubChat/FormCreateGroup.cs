﻿using System;
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

    }
}
