
namespace SubChat
{
    partial class FormAddSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSub));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClsoe = new System.Windows.Forms.Label();
            this.pictureNew = new System.Windows.Forms.PictureBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNew)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(206)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(71, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClsoe
            // 
            this.btnClsoe.AutoSize = true;
            this.btnClsoe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClsoe.ForeColor = System.Drawing.Color.White;
            this.btnClsoe.Location = new System.Drawing.Point(297, 9);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(15, 15);
            this.btnClsoe.TabIndex = 20;
            this.btnClsoe.Text = "X";
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // pictureNew
            // 
            this.pictureNew.Image = ((System.Drawing.Image)(resources.GetObject("pictureNew.Image")));
            this.pictureNew.Location = new System.Drawing.Point(70, 49);
            this.pictureNew.Name = "pictureNew";
            this.pictureNew.Size = new System.Drawing.Size(40, 40);
            this.pictureNew.TabIndex = 21;
            this.pictureNew.TabStop = false;
            // 
            // tbAdd
            // 
            this.tbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdd.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAdd.ForeColor = System.Drawing.Color.White;
            this.tbAdd.Location = new System.Drawing.Point(113, 60);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(181, 23);
            this.tbAdd.TabIndex = 22;
            this.tbAdd.Text = "Add new SubChat";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Location = new System.Drawing.Point(70, 87);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(228, 2);
            this.panelAdd.TabIndex = 23;
            // 
            // lbSelect
            // 
            this.lbSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lbSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelect.ForeColor = System.Drawing.Color.White;
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.ItemHeight = 21;
            this.lbSelect.Items.AddRange(new object[] {
            "User1",
            "User2",
            "User3",
            "User4"});
            this.lbSelect.Location = new System.Drawing.Point(71, 157);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelect.Size = new System.Drawing.Size(222, 147);
            this.lbSelect.Sorted = true;
            this.lbSelect.TabIndex = 24;
            this.lbSelect.MouseLeave += new System.EventHandler(this.lbSelect_MouseLeave);
            this.lbSelect.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelect.ForeColor = System.Drawing.Color.White;
            this.labelSelect.Location = new System.Drawing.Point(71, 135);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(150, 17);
            this.labelSelect.TabIndex = 25;
            this.labelSelect.Text = "Select users for SubChat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(74, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 2);
            this.panel1.TabIndex = 26;
            // 
            // FormAddSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(344, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.pictureNew);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddSub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label btnClsoe;
        private System.Windows.Forms.PictureBox pictureNew;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panel1;
    }
}