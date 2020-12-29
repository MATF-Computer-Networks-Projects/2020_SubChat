
namespace SubChat
{
    partial class FormFindUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindUser));
            this.btnFindUser = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNewUsers = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblEsc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(42, 27);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(40, 45);
            this.btnFindUser.TabIndex = 28;
            this.btnFindUser.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(42, 321);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 34);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbNewUsers
            // 
            this.tbNewUsers.AcceptsTab = true;
            this.tbNewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbNewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewUsers.ForeColor = System.Drawing.Color.White;
            this.tbNewUsers.Location = new System.Drawing.Point(43, 119);
            this.tbNewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewUsers.Multiline = true;
            this.tbNewUsers.Name = "tbNewUsers";
            this.tbNewUsers.ReadOnly = true;
            this.tbNewUsers.Size = new System.Drawing.Size(226, 113);
            this.tbNewUsers.TabIndex = 26;
            this.tbNewUsers.Text = "Users found\r\nuser1\r\nuser2\r\nuser3\r\nuser3\r\n...\r\n\r\n";
            this.tbNewUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(206)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSearch.Location = new System.Drawing.Point(43, 270);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(227, 34);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(42, 72);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(228, 2);
            this.panelUsername.TabIndex = 23;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.HideSelection = false;
            this.tbUsername.Location = new System.Drawing.Point(88, 41);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 25);
            this.tbUsername.TabIndex = 22;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Username";
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            // 
            // lblEsc
            // 
            this.lblEsc.AutoSize = true;
            this.lblEsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEsc.ForeColor = System.Drawing.Color.White;
            this.lblEsc.Location = new System.Drawing.Point(289, 7);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(15, 15);
            this.lblEsc.TabIndex = 29;
            this.lblEsc.Text = "X";
            this.lblEsc.Click += new System.EventHandler(this.lblEsc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEsc);
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbNewUsers);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.panelUsername);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 412);
            this.panel1.TabIndex = 30;
            // 
            // FormFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(314, 415);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFindUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFindUser";
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFindUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNewUsers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblEsc;
        private System.Windows.Forms.Panel panel1;
    }
}