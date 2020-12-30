
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblEsc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFoundUsers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(48, 36);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(46, 60);
            this.btnFindUser.TabIndex = 28;
            this.btnFindUser.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(48, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 45);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(206)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSearch.Location = new System.Drawing.Point(49, 360);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(259, 45);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(48, 96);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(261, 3);
            this.panelUsername.TabIndex = 23;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.HideSelection = false;
            this.tbUsername.Location = new System.Drawing.Point(101, 55);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(208, 31);
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
            this.lblEsc.Location = new System.Drawing.Point(330, 9);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(19, 20);
            this.lblEsc.TabIndex = 29;
            this.lblEsc.Text = "X";
            this.lblEsc.Click += new System.EventHandler(this.lblEsc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbFoundUsers);
            this.panel1.Controls.Add(this.lblEsc);
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.panelUsername);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 549);
            this.panel1.TabIndex = 30;
            // 
            // lbFoundUsers
            // 
            this.lbFoundUsers.FormattingEnabled = true;
            this.lbFoundUsers.ItemHeight = 20;
            this.lbFoundUsers.Items.AddRange(new object[] {
            "Found users:"});
            this.lbFoundUsers.Location = new System.Drawing.Point(48, 148);
            this.lbFoundUsers.Name = "lbFoundUsers";
            this.lbFoundUsers.Size = new System.Drawing.Size(261, 164);
            this.lbFoundUsers.TabIndex = 30;
            // 
            // FormFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(359, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblEsc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbFoundUsers;
    }
}