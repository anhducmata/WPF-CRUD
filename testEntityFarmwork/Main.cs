using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet3.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.appDataSet3.users);
            // TODO: This line of code loads data into the 'appDataSet2.posts' table. You can move, or remove it, as needed.
            this.postsTableAdapter.Fill(this.appDataSet2.posts);
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            var cbStatus = 0;
            if (cbPublish.Checked)
            {
                cbStatus = 1;
            }
            var newPost = new post
            {
                post_author = int.Parse((cbbUser.Text)),
                post_content = tbContent.Text,
                post_title = tbTitle.Text,
                status = cbStatus,
                date_created = DateTime.Now,
                date_updated = DateTime.Now
            };
            using (var ctx = new AppEntities())
            {
                if (ctx.users.Find(newPost.post_author) != null)
                {
                    ctx.posts.Add(newPost);
                    ctx.SaveChanges();
                    this.postsTableAdapter.Fill(this.appDataSet2.posts);
                }
                else
                {
                    
                }
                

            }
            
        }

        private void cbPublish_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
