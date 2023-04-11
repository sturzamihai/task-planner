using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskPlanner.Users;

namespace TaskPlanner.Departments
{
    public partial class AddDepartmentForm : Form
    {
        private List<User> members;

        public Department NewDepartment { get; set; }

        public AddDepartmentForm(List<User> members)
        {
            InitializeComponent();
            this.members = members;
            foreach(User member in members)
            {
                clbMembers.Items.Add(member.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text == "")
            {
                MessageBox.Show("The name of the department should not be null.");
                return;
            }

            if (members.Count > 0 && clbMembers.CheckedIndices.Count == 0)
            {
                MessageBox.Show("You should select at least one member.");
                return;
            }

            this.NewDepartment = new Department(tbName.Text);
            foreach (int i in clbMembers.CheckedIndices)
            {
                NewDepartment.Members.Add(members[i]);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
