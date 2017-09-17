using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class PostForm : Form
    {
        public PostForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet3.users' table. You can move, or remove it, as needed.
            usersTableAdapter.Fill(appDataSet3.users);
            // TODO: This line of code loads data into the 'appDataSet2.posts' table. You can move, or remove it, as needed.
            postsTableAdapter.Fill(appDataSet2.posts);
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            var cbStatus = 0;
            if (cbPublish.Checked)
                cbStatus = cbStatus == 0 ? 1 : 0;

            var newPost = new post
            {
                post_author = int.Parse(cbbUser.SelectedValue.ToString()),
                post_content = tbContent.Text,
                post_title = tbTitle.Text,
                status = cbStatus,
                date_created = DateTime.Now,
                date_updated = DateTime.Now
            };
            try
            {
                using (var ctx = new AppEntities())
                {
                    ctx.posts.Add(newPost);
                    ctx.SaveChanges();
                    tbTitle.Clear();
                    tbContent.Clear();
                    cbPublish.Checked = false;
                    postsTableAdapter.Fill(appDataSet2.posts);
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine(@"Entity of type {0} in state {1} has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                        Console.WriteLine(@"- Property: {0}, Error: {1}",
                            ve.PropertyName, ve.ErrorMessage);
                }
                throw;
            }
        }

        private void BtnDeletePost_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvPost.SelectedCells)
                if (oneCell.Selected)
                    dgvPost.Rows.RemoveAt(oneCell.RowIndex);
            postsTableAdapter.Update(appDataSet2.posts);
        }

        private void DgvPost_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSavePost.Enabled = true;
        }

        private void BtnSavePost_Click(object sender, EventArgs e)
        {
            postsTableAdapter.Update(appDataSet2.posts);
        }

        private void PostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var postForm = new PostForm();
            postForm.Close();
            mainForm.Show();
        }
    }
}