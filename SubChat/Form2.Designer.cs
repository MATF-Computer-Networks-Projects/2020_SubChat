
namespace SubChat
{
    partial class Form2
    {
        private string _username;

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

        public Form2(string username)
        {
            _username = username;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.btnClsoe = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.labelFilterSub = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.labelAddSub = new System.Windows.Forms.Label();
            this.btnAddSub = new System.Windows.Forms.PictureBox();
            this.labelCreateGroup = new System.Windows.Forms.Label();
            this.btnCreateGroup = new System.Windows.Forms.PictureBox();
            this.labelFindUser = new System.Windows.Forms.Label();
            this.btnFindUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.Location = new System.Drawing.Point(18, 75);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(194, 454);
            this.sidePanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chatPanel
            // 
            this.chatPanel.Location = new System.Drawing.Point(226, 75);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(630, 454);
            this.chatPanel.TabIndex = 6;
            // 
            // btnClsoe
            // 
            this.btnClsoe.AutoSize = true;
            this.btnClsoe.ForeColor = System.Drawing.Color.White;
            this.btnClsoe.Location = new System.Drawing.Point(856, 5);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(14, 15);
            this.btnClsoe.TabIndex = 10;
            this.btnClsoe.Text = "X";
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.labelFilterSub);
            this.menuPanel.Controls.Add(this.btnFilter);
            this.menuPanel.Controls.Add(this.labelAddSub);
            this.menuPanel.Controls.Add(this.btnAddSub);
            this.menuPanel.Controls.Add(this.labelCreateGroup);
            this.menuPanel.Controls.Add(this.btnCreateGroup);
            this.menuPanel.Controls.Add(this.labelFindUser);
            this.menuPanel.Controls.Add(this.btnFindUser);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Location = new System.Drawing.Point(19, 28);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(836, 47);
            this.menuPanel.TabIndex = 11;
            // 
            // labelFilterSub
            // 
            this.labelFilterSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFilterSub.AutoSize = true;
            this.labelFilterSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilterSub.ForeColor = System.Drawing.Color.White;
            this.labelFilterSub.Location = new System.Drawing.Point(696, 14);
            this.labelFilterSub.Name = "labelFilterSub";
            this.labelFilterSub.Size = new System.Drawing.Size(66, 17);
            this.labelFilterSub.TabIndex = 20;
            this.labelFilterSub.Text = "Filter sub";
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(649, -1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(45, 45);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.TabStop = false;
            this.btnFilter.MouseLeave += new System.EventHandler(this.btnFilter_MouseLeave);
            this.btnFilter.MouseHover += new System.EventHandler(this.btnFilter_MouseHover);
            // 
            // labelAddSub
            // 
            this.labelAddSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddSub.AutoSize = true;
            this.labelAddSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddSub.ForeColor = System.Drawing.Color.White;
            this.labelAddSub.Location = new System.Drawing.Point(574, 14);
            this.labelAddSub.Name = "labelAddSub";
            this.labelAddSub.Size = new System.Drawing.Size(59, 17);
            this.labelAddSub.TabIndex = 18;
            this.labelAddSub.Text = "Add sub";
            // 
            // btnAddSub
            // 
            this.btnAddSub.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSub.Image")));
            this.btnAddSub.Location = new System.Drawing.Point(527, 3);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(40, 40);
            this.btnAddSub.TabIndex = 17;
            this.btnAddSub.TabStop = false;
            this.btnAddSub.MouseLeave += new System.EventHandler(this.btnAddSub_MouseLeave);
            this.btnAddSub.MouseHover += new System.EventHandler(this.btnAddSub_MouseHover);
            // 
            // labelCreateGroup
            // 
            this.labelCreateGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreateGroup.AutoSize = true;
            this.labelCreateGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCreateGroup.ForeColor = System.Drawing.Color.White;
            this.labelCreateGroup.Location = new System.Drawing.Point(429, 14);
            this.labelCreateGroup.Name = "labelCreateGroup";
            this.labelCreateGroup.Size = new System.Drawing.Size(88, 17);
            this.labelCreateGroup.TabIndex = 16;
            this.labelCreateGroup.Text = "Create group";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateGroup.Image")));
            this.btnCreateGroup.Location = new System.Drawing.Point(382, -1);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(45, 45);
            this.btnCreateGroup.TabIndex = 15;
            this.btnCreateGroup.TabStop = false;
            this.btnCreateGroup.MouseLeave += new System.EventHandler(this.btnCreateGroup_MouseLeave);
            this.btnCreateGroup.MouseHover += new System.EventHandler(this.btnCreateGroup_MouseHover);
            // 
            // labelFindUser
            // 
            this.labelFindUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFindUser.AutoSize = true;
            this.labelFindUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFindUser.ForeColor = System.Drawing.Color.White;
            this.labelFindUser.Location = new System.Drawing.Point(293, 13);
            this.labelFindUser.Name = "labelFindUser";
            this.labelFindUser.Size = new System.Drawing.Size(65, 17);
            this.labelFindUser.TabIndex = 14;
            this.labelFindUser.Text = "Find user";
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(246, -1);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(45, 45);
            this.btnFindUser.TabIndex = 13;
            this.btnFindUser.TabStop = false;
            this.btnFindUser.MouseLeave += new System.EventHandler(this.btnFindUser_MouseLeave);
            this.btnFindUser.MouseHover += new System.EventHandler(this.btnFindUser_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 2);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(15, 25, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubChat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.Label btnClsoe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFindUser;
        private System.Windows.Forms.PictureBox btnFindUser;
        private System.Windows.Forms.Label labelFilterSub;
        private System.Windows.Forms.PictureBox btnFilter;
        private System.Windows.Forms.Label labelAddSub;
        private System.Windows.Forms.PictureBox btnAddSub;
        private System.Windows.Forms.Label labelCreateGroup;
        private System.Windows.Forms.PictureBox btnCreateGroup;
    }
}