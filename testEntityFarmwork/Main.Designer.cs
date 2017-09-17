namespace testEntityFarmwork
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.dgvPost = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet2 = new testEntityFarmwork.AppDataSet2();
            this.postsTableAdapter = new testEntityFarmwork.AppDataSet2TableAdapters.postsTableAdapter();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commentTableAdapter1 = new testEntityFarmwork.AppDataSetTableAdapters.commentTableAdapter();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet3 = new testEntityFarmwork.AppDataSet3();
            this.usersTableAdapter = new testEntityFarmwork.AppDataSet3TableAdapters.usersTableAdapter();
            this.cbPublish = new System.Windows.Forms.CheckBox();
            this.ValueStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPost
            // 
            this.dgvPost.AutoGenerateColumns = false;
            this.dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.posttitleDataGridViewTextBoxColumn,
            this.postcontentDataGridViewTextBoxColumn,
            this.postauthorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datecreatedDataGridViewTextBoxColumn,
            this.dateupdatedDataGridViewTextBoxColumn});
            this.dgvPost.DataSource = this.postsBindingSource;
            this.dgvPost.Location = new System.Drawing.Point(12, 269);
            this.dgvPost.Name = "dgvPost";
            this.dgvPost.Size = new System.Drawing.Size(746, 332);
            this.dgvPost.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posttitleDataGridViewTextBoxColumn
            // 
            this.posttitleDataGridViewTextBoxColumn.DataPropertyName = "post_title";
            this.posttitleDataGridViewTextBoxColumn.HeaderText = "post_title";
            this.posttitleDataGridViewTextBoxColumn.Name = "posttitleDataGridViewTextBoxColumn";
            // 
            // postcontentDataGridViewTextBoxColumn
            // 
            this.postcontentDataGridViewTextBoxColumn.DataPropertyName = "post_content";
            this.postcontentDataGridViewTextBoxColumn.HeaderText = "post_content";
            this.postcontentDataGridViewTextBoxColumn.Name = "postcontentDataGridViewTextBoxColumn";
            // 
            // postauthorDataGridViewTextBoxColumn
            // 
            this.postauthorDataGridViewTextBoxColumn.DataPropertyName = "post_author";
            this.postauthorDataGridViewTextBoxColumn.HeaderText = "post_author";
            this.postauthorDataGridViewTextBoxColumn.Name = "postauthorDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // datecreatedDataGridViewTextBoxColumn
            // 
            this.datecreatedDataGridViewTextBoxColumn.DataPropertyName = "date_created";
            this.datecreatedDataGridViewTextBoxColumn.HeaderText = "date_created";
            this.datecreatedDataGridViewTextBoxColumn.Name = "datecreatedDataGridViewTextBoxColumn";
            // 
            // dateupdatedDataGridViewTextBoxColumn
            // 
            this.dateupdatedDataGridViewTextBoxColumn.DataPropertyName = "date_updated";
            this.dateupdatedDataGridViewTextBoxColumn.HeaderText = "date_updated";
            this.dateupdatedDataGridViewTextBoxColumn.Name = "dateupdatedDataGridViewTextBoxColumn";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "posts";
            this.postsBindingSource.DataSource = this.appDataSet2;
            // 
            // appDataSet2
            // 
            this.appDataSet2.DataSetName = "AppDataSet2";
            this.appDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost.Location = new System.Drawing.Point(655, 30);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(103, 98);
            this.btnAddPost.TabIndex = 1;
            this.btnAddPost.Text = "Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(94, 30);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(546, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(94, 56);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(546, 144);
            this.tbContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // commentTableAdapter1
            // 
            this.commentTableAdapter1.ClearBeforeFill = true;
            // 
            // cbbUser
            // 
            this.cbbUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "username", true));
            this.cbbUser.DataSource = this.usersBindingSource;
            this.cbbUser.DisplayMember = "username";
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(94, 206);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(121, 21);
            this.cbbUser.TabIndex = 7;
            this.cbbUser.ValueMember = "id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.appDataSet3;
            // 
            // appDataSet3
            // 
            this.appDataSet3.DataSetName = "AppDataSet3";
            this.appDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // cbPublish
            // 
            this.cbPublish.AutoSize = true;
            this.cbPublish.Location = new System.Drawing.Point(94, 235);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(85, 17);
            this.cbPublish.TabIndex = 8;
            this.cbPublish.Text = "Publish Now";
            this.cbPublish.UseVisualStyleBackColor = true;
            this.cbPublish.CheckedChanged += new System.EventHandler(this.cbPublish_CheckedChanged);
            // 
            // ValueStatus
            // 
            this.ValueStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueStatus.Location = new System.Drawing.Point(226, 240);
            this.ValueStatus.Name = "ValueStatus";
            this.ValueStatus.ReadOnly = true;
            this.ValueStatus.Size = new System.Drawing.Size(10, 1);
            this.ValueStatus.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 613);
            this.Controls.Add(this.ValueStatus);
            this.Controls.Add(this.cbPublish);
            this.Controls.Add(this.cbbUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.dgvPost);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPost;
        private AppDataSet2 appDataSet2;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private AppDataSet2TableAdapters.postsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posttitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AppDataSetTableAdapters.commentTableAdapter commentTableAdapter1;
        private System.Windows.Forms.ComboBox cbbUser;
        private AppDataSet3 appDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AppDataSet3TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.CheckBox cbPublish;
        private System.Windows.Forms.TextBox ValueStatus;
    }
}

