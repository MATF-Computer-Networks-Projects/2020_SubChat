
namespace SubChat
{
    partial class FormFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilter));
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblEsc = new System.Windows.Forms.Label();
            this.btnFindUser = new System.Windows.Forms.PictureBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(206)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnFilter.Location = new System.Drawing.Point(61, 91);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(228, 38);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // lblEsc
            // 
            this.lblEsc.AutoSize = true;
            this.lblEsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEsc.ForeColor = System.Drawing.Color.White;
            this.lblEsc.Location = new System.Drawing.Point(327, 6);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(15, 15);
            this.lblEsc.TabIndex = 30;
            this.lblEsc.Text = "X";
            this.lblEsc.Click += new System.EventHandler(this.lblEsc_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.Location = new System.Drawing.Point(61, 27);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(40, 45);
            this.btnFindUser.TabIndex = 33;
            this.btnFindUser.TabStop = false;
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(61, 72);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(228, 2);
            this.panelUsername.TabIndex = 32;
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilter.ForeColor = System.Drawing.Color.White;
            this.tbFilter.HideSelection = false;
            this.tbFilter.Location = new System.Drawing.Point(107, 41);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(182, 25);
            this.tbFilter.TabIndex = 31;
            this.tbFilter.TabStop = false;
            this.tbFilter.Text = "Filter SubChat";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.panelUsername);
            this.panel1.Controls.Add(this.tbFilter);
            this.panel1.Controls.Add(this.lblEsc);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 156);
            this.panel1.TabIndex = 34;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(358, 158);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFilter";
            ((System.ComponentModel.ISupportInitialize)(this.btnFindUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblEsc;
        private System.Windows.Forms.PictureBox btnFindUser;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Panel panel1;
    }
}