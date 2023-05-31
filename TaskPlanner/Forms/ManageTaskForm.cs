using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskPlanner.Entities;
using TaskPlanner.Entities.Users;

namespace TaskPlanner.Forms
{
    public partial class ManageTaskForm : Form
    {
        private List<Project> projects;
        private List<User> users;

        public Entities.Task NewTask { get; set; }
        public int SelectedProject { get; set; }

        public ManageTaskForm(List<Project> projects, List<User> users)
        {
            InitializeComponent();

            this.projects = projects;
            this.users = users;

            foreach (Project project in this.projects)
            {
                cbProject.Items.Add(project.Title);
            }

            cbStatus.Enabled = false;

            foreach (User user in users)
            {
                cbAsignee.Items.Add(user.Name);
            }
        }

        public ManageTaskForm(Entities.Task initial, List<User> users)
        {
            InitializeComponent();

            this.NewTask = initial;

            cbProject.Enabled = false;
            cbProject.Text = initial.Project.Title;

            foreach (Entities.TaskStatus status in initial.Project.AllowedStatuses)
            {
                cbStatus.Items.Add(status.Title);
            }

            cbStatus.SelectedIndex = cbStatus.Items.IndexOf(initial.Status.Title);

            tbName.Text = initial.Title;
            tbDescription.Text = initial.Description;

            this.users = users;
            foreach (User user in users)
            {
                cbAsignee.Items.Add(user.Name);
            }

            cbAsignee.SelectedIndex = cbAsignee.Items.IndexOf(initial.Asignee.Name);

            btnAdd.Text = "Update task";
            labelFormName.Text = "Update task";
            this.Text = "Update task - Task Planner";
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatus.Items.Clear();

            foreach (Entities.TaskStatus status in this.projects[cbProject.SelectedIndex].AllowedStatuses)
            {
                cbStatus.Items.Add(status.Title);
            }

            cbStatus.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbAsignee.SelectedIndex == -1 || (cbProject.Enabled && cbProject.SelectedIndex == -1) || cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields. (Marked by *)");
                return;
            }

            if (tbName.TextLength <= 0)
            {
                MessageBox.Show("Please provide a name for the task.");
                return;
            }

            if (NewTask != null)
            {
                NewTask.Title = tbName.Text;
                NewTask.Description = tbDescription.Text;
                NewTask.Asignee = this.users[cbAsignee.SelectedIndex];
                NewTask.Status = NewTask.Project.AllowedStatuses[cbStatus.SelectedIndex];
            }
            else
            {
                NewTask = new Entities.Task
                {
                    Title = tbName.Text,
                    Description = tbDescription.Text,
                    Asignee = this.users[cbAsignee.SelectedIndex],
                    Status = this.projects[cbProject.SelectedIndex].AllowedStatuses[cbStatus.SelectedIndex],
                };
            }

            SelectedProject = cbProject.SelectedIndex;

            DialogResult = DialogResult.OK;
        }
    }
}
