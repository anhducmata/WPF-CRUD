using System;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var userForm = new UserForm();
            userForm.Close();
            mainForm.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.users' table. You can move, or remove it, as needed.
            usersTableAdapter.Fill(userDataSet.users);
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            var newUser = new user
            {
                username = tbUsername.Text,
                password = tbPassword.Text
            };
            using (var ctx = new AppEntities())
            {
                ctx.users.Add(newUser);
                ctx.SaveChanges();
                usersTableAdapter.Fill(userDataSet.users);
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvUser.SelectedCells)
                if (oneCell.Selected)
                    dgvUser.Rows.RemoveAt(oneCell.RowIndex);
            usersTableAdapter.Update(userDataSet.users);
        }

        private void BtnSaveChangeUser_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(userDataSet.users);
        }

        private void DgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BtnSaveChangeUser.Enabled = true;
        }
    }
}