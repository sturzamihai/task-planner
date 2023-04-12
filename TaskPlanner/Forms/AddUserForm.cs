using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskPlanner.Entities.Users;
using TaskPlanner.Services;

namespace TaskPlanner.Users
{
    public partial class AddUserForm : Form
    {
        public User NewUser { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '•';
        }

        private bool isValidEmail(string email)
        {
            if (email == null || email == "") return false;
            try
            {
                MailAddress checker = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidEmail(tbEmail.Text))
            {
                MessageBox.Show("The entered email is not a valid email address.");
                return;
            }
            
            // TODO: Maybe more complex validation for password
            if(tbPassword.Text == null || tbPassword.Text.Length <= 3)
            {
                MessageBox.Show("Please enter a longer password.");
                return;
            }

            switch (cbRole.SelectedIndex)
            {
                case 0:
                    NewUser = new Employee() { Name = tbName.Text, Email = tbEmail.Text, Password = PasswordHasher.Hash(tbPassword.Text) };
                    break;
                case 1:
                    NewUser = new Manager() { Name = tbName.Text, Email = tbEmail.Text, Password = PasswordHasher.Hash(tbPassword.Text) };
                    break;
                case 2:
                    NewUser = new Client() { Name = tbName.Text, Email = tbEmail.Text, Password = PasswordHasher.Hash(tbPassword.Text) };
                    break;
                default:
                    MessageBox.Show("The selected role is invalid.");
                    return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
