using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    internal struct SomeData
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }

    public partial class MainForm : Form
    {
        private const int NumberPostPerPage = 20;
        private static int _realPage;
        private Timer _t;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnShowPostForm_Click(object sender, EventArgs e)
        {
            Visible = false;
            var mainForm = new MainForm();
            var postForm = new PostForm();
            mainForm.Hide();
            postForm.Show();
        }

        private void BtnShowUserForm_Click(object sender, EventArgs e)
        {
            Visible = false;
            var mainForm = new MainForm();
            var userForm = new UserForm();
            mainForm.Hide();
            userForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Close();
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartTimer();
            var listPostPagination = LoadPostPagination(_realPage, NumberPostPerPage);
            var postOut = listPostPagination.Select(post => new SomeData
                {
                    Value = post.id,
                    Text = post.post_title
                })
                .ToList();
            ListboxPostNow.DisplayMember = "Text";
            ListboxPostNow.DataSource = postOut;
            SettingPagination(_realPage, NumberPostPerPage);
        }

        private static int CountPost()
        {
            using (var ctx = new AppEntities())
            {
                return ctx.posts
                    .Count(o => o.status == 1);
            }
        }

        private static IEnumerable<post> LoadPostPagination(int realPage, int numberPostPerPage)
        {
            using (var ctx = new AppEntities())
            {
                var postPaging = ctx.posts
                    .Where(item => item.status == 1)
                    .Distinct()
                    .OrderByDescending(d => d.id)
                    .Skip(realPage * numberPostPerPage)
                    .Take(numberPostPerPage)
                    .ToList();
                return postPaging;
            }
        }

        private void StartTimer()
        {
            _t = new Timer {Interval = 1000};
            _t.Tick += T_Tick;
            _t.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("f");
        }

        private void SettingPagination(int realPage, int numberPostPerPage)
        {
            BtnPrevious.Enabled = realPage != 0;
            BtnNext.Enabled = CountPost() >= numberPostPerPage;
            lbCurrentPage.Text = realPage.ToString();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _realPage--;
            MainForm_Load(sender, e);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _realPage++;
            MainForm_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
        }
    }
}