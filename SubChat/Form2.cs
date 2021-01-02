using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void labelFindUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            Form createGroupWindow = new FormCreateGroup();
            createGroupWindow.Show();
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            Form addSubWindow = new FormAddSub();
            addSubWindow.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Form filterWindow = new FormFilter();
            filterWindow.Show();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            Form findUserWindow = new FormFindUser();
            findUserWindow.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // get words from input box
            string[] text = tbInput.Text.Split(" ");

            // if user didn't write antyhing we don't write empty string so just return
            if (text.Length == 0)
                return;

            Chat.Rows.Add(" ", "Me:");

            // variables for row breaks
            int row_length = 0;
            string text_for_one_row = "";

             foreach(string word in text){

                // +1 is for space that goes behind word
                row_length += word.Length + 1;

                 // if the length of row is greater then row size
                if(row_length >= 37)
                {
                    // write row text
                    Chat.Rows.Add(" ", text_for_one_row);
                    
                    // prepare text for new row
                    text_for_one_row = "";
                    text_for_one_row += word + " ";

                    // set new row size
                    // +1 is for space
                    row_length = word.Length +1;
                }
                else
                {
                    // if the word can be stored in row without row break
                    text_for_one_row += word + " ";
                }

             }

             // write whatever has left unwritten
             Chat.Rows.Add(" " ,text_for_one_row);

            // always show last row
             Chat.FirstDisplayedScrollingRowIndex = Chat.RowCount - 1;
        }

        private void panelBorder_Paint(object sender, PaintEventArgs e)
        {
            // this is just test example, need to be removed once function for groups reading is finished
            Button btn = new Button();
            Button btn2 = new Button();
            btn2.Location = new Point(btn.Location.X, btn.Location.Y + btn.Height);

            sidePanel.Controls.Add(btn);
            sidePanel.Controls.Add(btn2);

        }
    }

    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }

}
