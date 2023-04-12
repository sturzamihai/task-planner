using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskPlanner.Entities.Users;
using TaskPlanner.Persistance;
using TaskPlanner.Services;

namespace TaskPlanner.Users
{
    public partial class LoginForm : Form
    {
        private DataContext dataContext;

        public User SelectedUser { get; set; }
        public LoginForm(DataContext dataContext)
        {
            InitializeComponent();
            this.dataContext = dataContext;
            tbPassword.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == null || tbEmail.Text.Length == 0)
            {
                MessageBox.Show("The email you entered is invalid.");
                return;
            }

            try
            {
                User pendingUser = dataContext.Users.Single(u => u.Email == tbEmail.Text);

                if (pendingUser == null)
                {
                    MessageBox.Show("Email or password is incorrect.");
                    return;
                }

                if (PasswordHasher.Verify(tbPassword.Text, pendingUser.Password) == false)
                {
                    MessageBox.Show("Email or password is incorrect.");
                    return;
                }

                SelectedUser = pendingUser;
                this.DialogResult = DialogResult.OK;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email or password is incorrect.");
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (dataContext.Users.Count() == 0)
            {
                MessageBox.Show("Looks like you're the first user. Let's create your own account.");
                AddUserForm addUserForm = new AddUserForm();
                if (addUserForm.ShowDialog() == DialogResult.OK)
                {
                    dataContext.Add(addUserForm.NewUser);
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
