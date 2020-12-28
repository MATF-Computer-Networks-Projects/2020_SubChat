
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
            InitializeComponent();
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
            this.btnFindUser = new System.Windows.Forms.PictureBox();
            this.labelFilterSub = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.labelAddSub = new System.Windows.Forms.Label();
            this.btnAddSub = new System.Windows.Forms.PictureBox();
            this.labelCreateGroup = new System.Windows.Forms.Label();
            this.btnCreateGroup = new System.Windows.Forms.PictureBox();
            this.labelFindUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.Location = new System.Drawing.Point(21, 100);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(222, 605);
            this.sidePanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chatPanel
            // 
            this.chatPanel.Location = new System.Drawing.Point(258, 100);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(720, 605);
            this.chatPanel.TabIndex = 6;
            // 
            // btnClsoe
            // 
            this.btnClsoe.AutoSize = true;
            this.btnClsoe.ForeColor = System.Drawing.Color.White;
            this.btnClsoe.Location = new System.Drawing.Point(978, 7);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(18, 20);
            this.btnClsoe.TabIndex = 10;
            this.btnClsoe.Text = "X";
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnFindUser);
            this.menuPanel.Controls.Add(this.labelFilterSub);
            this.menuPanel.Controls.Add(this.btnFilter);
            this.menuPanel.Controls.Add(this.labelAddSub);
            this.menuPanel.Controls.Add(this.btnAddSub);
            this.menuPanel.Controls.Add(this.labelCreateGroup);
            this.menuPanel.Controls.Add(this.btnCreateGroup);
            this.menuPanel.Controls.Add(this.labelFindUser);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Location = new System.Drawing.Point(22, 37);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(955, 63);
            this.menuPanel.TabIndex = 11;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(267, -1);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(51, 60);
            this.btnFindUser.TabIndex = 13;
            this.btnFindUser.TabStop = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            this.btnFindUser.MouseLeave += new System.EventHandler(this.btnFindUser_MouseLeave);
            this.btnFindUser.MouseHover += new System.EventHandler(this.btnFindUser_MouseHover);
            // 
            // labelFilterSub
            // 
            this.labelFilterSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFilterSub.AutoSize = true;
            this.labelFilterSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilterSub.ForeColor = System.Drawing.Color.White;
            this.labelFilterSub.Location = new System.Drawing.Point(823, 19);
            this.labelFilterSub.Name = "labelFilterSub";
            this.labelFilterSub.Size = new System.Drawing.Size(85, 23);
            this.labelFilterSub.TabIndex = 20;
            this.labelFilterSub.Text = "Filter sub";
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(776, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(51, 60);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.TabStop = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnFilter.MouseLeave += new System.EventHandler(this.btnFilter_MouseLeave);
            this.btnFilter.MouseHover += new System.EventHandler(this.btnFilter_MouseHover);
            // 
            // labelAddSub
            // 
            this.labelAddSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddSub.AutoSize = true;
            this.labelAddSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddSub.ForeColor = System.Drawing.Color.White;
            this.labelAddSub.Location = new System.Drawing.Point(668, 19);
            this.labelAddSub.Name = "labelAddSub";
            this.labelAddSub.Size = new System.Drawing.Size(77, 23);
            this.labelAddSub.TabIndex = 18;
            this.labelAddSub.Text = "Add sub";
            // 
            // btnAddSub
            // 
            this.btnAddSub.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSub.Image")));
            this.btnAddSub.Location = new System.Drawing.Point(628, 6);
            this.btnAddSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(46, 53);
            this.btnAddSub.TabIndex = 17;
            this.btnAddSub.TabStop = false;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            this.btnAddSub.MouseLeave += new System.EventHandler(this.btnAddSub_MouseLeave);
            this.btnAddSub.MouseHover += new System.EventHandler(this.btnAddSub_MouseHover);
            // 
            // labelCreateGroup
            // 
            this.labelCreateGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreateGroup.AutoSize = true;
            this.labelCreateGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCreateGroup.ForeColor = System.Drawing.Color.White;
            this.labelCreateGroup.Location = new System.Drawing.Point(494, 19);
            this.labelCreateGroup.Name = "labelCreateGroup";
            this.labelCreateGroup.Size = new System.Drawing.Size(116, 23);
            this.labelCreateGroup.TabIndex = 16;
            this.labelCreateGroup.Text = "Create group";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateGroup.Image")));
            this.btnCreateGroup.Location = new System.Drawing.Point(447, 0);
            this.btnCreateGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(51, 60);
            this.btnCreateGroup.TabIndex = 15;
            this.btnCreateGroup.TabStop = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            this.btnCreateGroup.MouseLeave += new System.EventHandler(this.btnCreateGroup_MouseLeave);
            this.btnCreateGroup.MouseHover += new System.EventHandler(this.btnCreateGroup_MouseHover);
            // 
            // labelFindUser
            // 
            this.labelFindUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFindUser.AutoSize = true;
            this.labelFindUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFindUser.ForeColor = System.Drawing.Color.White;
            this.labelFindUser.Location = new System.Drawing.Point(324, 19);
            this.labelFindUser.Name = "labelFindUser";
            this.labelFindUser.Size = new System.Drawing.Size(83, 23);
            this.labelFindUser.TabIndex = 14;
            this.labelFindUser.Text = "Find user";
            this.labelFindUser.Click += new System.EventHandler(this.labelFindUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 3);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(999, 729);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(17, 33, 17, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubChat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGroup)).EndInit();
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