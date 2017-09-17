namespace testEntityFarmwork
{
    public partial class MainForm
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
            this.btnShowPostForm = new System.Windows.Forms.Button();
            this.btnShowUserForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRoleForm = new System.Windows.Forms.Button();
            this.BtnComment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.ListboxPostNow = new System.Windows.Forms.ListBox();
            this.lbClock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListboxOnline = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPostForm
            // 
            this.btnShowPostForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPostForm.Location = new System.Drawing.Point(18, 90);
            this.btnShowPostForm.Name = "btnShowPostForm";
            this.btnShowPostForm.Size = new System.Drawing.Size(92, 25);
            this.btnShowPostForm.TabIndex = 0;
            this.btnShowPostForm.Text = "Post";
            this.btnShowPostForm.UseVisualStyleBackColor = true;
            this.btnShowPostForm.Click += new System.EventHandler(this.BtnShowPostForm_Click);
            // 
            // btnShowUserForm
            // 
            this.btnShowUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUserForm.Location = new System.Drawing.Point(18, 59);
            this.btnShowUserForm.Name = "btnShowUserForm";
            this.btnShowUserForm.Size = new System.Drawing.Size(92, 25);
            this.btnShowUserForm.TabIndex = 0;
            this.btnShowUserForm.Text = "User";
            this.btnShowUserForm.UseVisualStyleBackColor = true;
            this.btnShowUserForm.Click += new System.EventHandler(this.BtnShowUserForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnShowPostForm);
            this.panel1.Controls.Add(this.BtnRoleForm);
            this.panel1.Controls.Add(this.BtnComment);
            this.panel1.Controls.Add(this.btnShowUserForm);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 197);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Panel";
            // 
            // BtnRoleForm
            // 
            this.BtnRoleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoleForm.Location = new System.Drawing.Point(18, 121);
            this.BtnRoleForm.Name = "BtnRoleForm";
            this.BtnRoleForm.Size = new System.Drawing.Size(92, 25);
            this.BtnRoleForm.TabIndex = 0;
            this.BtnRoleForm.Text = "Role";
            this.BtnRoleForm.UseVisualStyleBackColor = true;
            this.BtnRoleForm.Click += new System.EventHandler(this.BtnShowUserForm_Click);
            // 
            // BtnComment
            // 
            this.BtnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComment.Location = new System.Drawing.Point(18, 152);
            this.BtnComment.Name = "BtnComment";
            this.BtnComment.Size = new System.Drawing.Size(92, 25);
            this.BtnComment.TabIndex = 0;
            this.BtnComment.Text = "Comment";
            this.BtnComment.UseVisualStyleBackColor = true;
            this.BtnComment.Click += new System.EventHandler(this.BtnShowUserForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCurrentPage);
            this.panel2.Controls.Add(this.BtnNext);
            this.panel2.Controls.Add(this.BtnPrevious);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.ListboxPostNow);
            this.panel2.Location = new System.Drawing.Point(140, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 416);
            this.panel2.TabIndex = 2;
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCurrentPage.Location = new System.Drawing.Point(277, 362);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(0, 18);
            this.lbCurrentPage.TabIndex = 5;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNext.Location = new System.Drawing.Point(303, 361);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Next →";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrevious.Location = new System.Drawing.Point(187, 361);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 4;
            this.BtnPrevious.Text = "← Previous";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(461, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(17, 16);
            this.tbSearch.MaximumSize = new System.Drawing.Size(435, 30);
            this.tbSearch.MinimumSize = new System.Drawing.Size(4, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(435, 29);
            this.tbSearch.TabIndex = 2;
            // 
            // ListboxPostNow
            // 
            this.ListboxPostNow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListboxPostNow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxPostNow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListboxPostNow.FormattingEnabled = true;
            this.ListboxPostNow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListboxPostNow.ItemHeight = 18;
            this.ListboxPostNow.Location = new System.Drawing.Point(17, 59);
            this.ListboxPostNow.Margin = new System.Windows.Forms.Padding(20);
            this.ListboxPostNow.Name = "ListboxPostNow";
            this.ListboxPostNow.Size = new System.Drawing.Size(591, 292);
            this.ListboxPostNow.Sorted = true;
            this.ListboxPostNow.TabIndex = 0;
            // 
            // lbClock
            // 
            this.lbClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClock.AutoSize = true;
            this.lbClock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClock.Location = new System.Drawing.Point(537, 10);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(0, 13);
            this.lbClock.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel3.Controls.Add(this.lbClock);
            this.panel3.Location = new System.Drawing.Point(8, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 32);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.ListboxOnline);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(5, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 213);
            this.panel4.TabIndex = 7;
            // 
            // ListboxOnline
            // 
            this.ListboxOnline.FormattingEnabled = true;
            this.ListboxOnline.Location = new System.Drawing.Point(10, 34);
            this.ListboxOnline.Name = "ListboxOnline";
            this.ListboxOnline.Size = new System.Drawing.Size(110, 173);
            this.ListboxOnline.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Online";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(776, 460);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(800, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPostForm;
        private System.Windows.Forms.Button btnShowUserForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRoleForm;
        private System.Windows.Forms.Button BtnComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ListboxPostNow;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox ListboxOnline;
        private System.Windows.Forms.Label label2;
    }
}