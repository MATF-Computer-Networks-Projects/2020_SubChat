
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.Chat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.panelBorder = new System.Windows.Forms.FlowLayoutPanel();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-1, -3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(210, 50);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnSend);
            this.panelMain.Controls.Add(this.tbInput);
            this.panelMain.Controls.Add(this.panelChat);
            this.panelMain.Location = new System.Drawing.Point(226, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(630, 454);
            this.panelMain.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(587, 408);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(32, 32);
            this.btnSend.TabIndex = 2;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbInput.Location = new System.Drawing.Point(0, 408);
            this.tbInput.Name = "tbInput";
            this.tbInput.PlaceholderText = "Insert text";
            this.tbInput.Size = new System.Drawing.Size(579, 33);
            this.tbInput.TabIndex = 1;
            // 
            // panelChat
            // 
            this.panelChat.Controls.Add(this.Chat);
            this.panelChat.Location = new System.Drawing.Point(0, 12);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(628, 380);
            this.panelChat.TabIndex = 0;
            // 
            // Chat
            // 
            this.Chat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Chat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Chat.ColumnHeadersVisible = false;
            this.Chat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.Chat.Location = new System.Drawing.Point(-1, -1);
            this.Chat.MultiSelect = false;
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.RowHeadersVisible = false;
            this.Chat.RowTemplate.Height = 30;
            this.Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Chat.ShowCellErrors = false;
            this.Chat.ShowCellToolTips = false;
            this.Chat.ShowEditingIcon = false;
            this.Chat.ShowRowErrors = false;
            this.Chat.Size = new System.Drawing.Size(628, 378);
            this.Chat.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Other";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 302;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "me";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 302;
            // 
            // btnClsoe
            // 
            this.btnClsoe.AutoSize = true;
            this.btnClsoe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClsoe.ForeColor = System.Drawing.Color.White;
            this.btnClsoe.Location = new System.Drawing.Point(850, 4);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(15, 15);
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
            this.menuPanel.Controls.Add(this.panelUnderline);
            this.menuPanel.Controls.Add(this.Logo);
            this.menuPanel.Location = new System.Drawing.Point(19, 28);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(836, 47);
            this.menuPanel.TabIndex = 11;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(234, -1);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(45, 45);
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
            this.labelFilterSub.Location = new System.Drawing.Point(720, 14);
            this.labelFilterSub.Name = "labelFilterSub";
            this.labelFilterSub.Size = new System.Drawing.Size(66, 17);
            this.labelFilterSub.TabIndex = 20;
            this.labelFilterSub.Text = "Filter sub";
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(679, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(45, 45);
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
            this.labelAddSub.Location = new System.Drawing.Point(584, 14);
            this.labelAddSub.Name = "labelAddSub";
            this.labelAddSub.Size = new System.Drawing.Size(59, 17);
            this.labelAddSub.TabIndex = 18;
            this.labelAddSub.Text = "Add sub";
            // 
            // btnAddSub
            // 
            this.btnAddSub.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSub.Image")));
            this.btnAddSub.Location = new System.Drawing.Point(550, 4);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(40, 40);
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
            this.labelCreateGroup.Location = new System.Drawing.Point(432, 14);
            this.labelCreateGroup.Name = "labelCreateGroup";
            this.labelCreateGroup.Size = new System.Drawing.Size(88, 17);
            this.labelCreateGroup.TabIndex = 16;
            this.labelCreateGroup.Text = "Create group";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateGroup.Image")));
            this.btnCreateGroup.Location = new System.Drawing.Point(391, 0);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(45, 45);
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
            this.labelFindUser.Location = new System.Drawing.Point(284, 14);
            this.labelFindUser.Name = "labelFindUser";
            this.labelFindUser.Size = new System.Drawing.Size(65, 17);
            this.labelFindUser.TabIndex = 14;
            this.labelFindUser.Text = "Find user";
            this.labelFindUser.Click += new System.EventHandler(this.labelFindUser_Click);
            // 
            // panelUnderline
            // 
            this.panelUnderline.BackColor = System.Drawing.Color.White;
            this.panelUnderline.Location = new System.Drawing.Point(0, 45);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(835, 2);
            this.panelUnderline.TabIndex = 12;
            // 
            // panelBorder
            // 
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Location = new System.Drawing.Point(1, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(871, 545);
            this.panelBorder.TabIndex = 12;
            this.panelBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBorder_Paint);
            // 
            // Other
            // 
            this.Other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Other.DefaultCellStyle = dataGridViewCellStyle7;
            this.Other.HeaderText = "";
            this.Other.Name = "Other";
            this.Other.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Other.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Me
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Me.DefaultCellStyle = dataGridViewCellStyle8;
            this.Me.HeaderText = "";
            this.Me.Name = "Me";
            this.Me.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Me.Width = 314;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sidePanel.AutoScroll = true;
            this.sidePanel.Location = new System.Drawing.Point(18, 87);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(194, 442);
            this.sidePanel.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(15, 25, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubChat";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.panelChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
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
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label btnClsoe;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panelUnderline;
        private System.Windows.Forms.Label labelFindUser;
        private System.Windows.Forms.PictureBox btnFindUser;
        private System.Windows.Forms.Label labelFilterSub;
        private System.Windows.Forms.PictureBox btnFilter;
        private System.Windows.Forms.Label labelAddSub;
        private System.Windows.Forms.PictureBox btnAddSub;
        private System.Windows.Forms.Label labelCreateGroup;
        private System.Windows.Forms.PictureBox btnCreateGroup;
        private System.Windows.Forms.FlowLayoutPanel panelBorder;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.DataGridView Chat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
        private System.Windows.Forms.DataGridViewTextBoxColumn Me;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}