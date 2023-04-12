using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using TaskPlanner.Departments;
using TaskPlanner.Entities;
using TaskPlanner.Entities.Users;
using TaskPlanner.Persistance;
using TaskPlanner.Projects;
using TaskPlanner.Users;

namespace TaskPlanner
{
    public partial class TaskPlanner : Form
    {
        private DataContext dataContext;
        private User activeUser;
        TrackedTime trackedTime = new TrackedTime();

        public TaskPlanner(DataContext dataContext)
        {
            InitializeComponent();
            this.dataContext = dataContext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this.dataContext);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this.activeUser = loginForm.SelectedUser;
            }
            else
            {
                this.Close();
            }

            this.tsLabelUser.Text = $"Active user: {this.activeUser.Name}";
            this.dataContext.Projects.Load();
            this.projectBindingSource.DataSource = dataContext.Projects.Local.ToBindingList();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                dataContext.Users.Add(addUserForm.NewUser);
                dataContext.SaveChanges();
            }
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            List<Client> clients = dataContext.Clients.ToList();
            List<Department> departments = dataContext.Departments.ToList();

            AddProjectForm addProjectForm = new AddProjectForm(clients, departments);
            if (addProjectForm.ShowDialog() == DialogResult.OK)
            {
                dataContext.Projects.Add(addProjectForm.NewProject);
                dataContext.SaveChanges();

                lbProjects.Refresh();
            }
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<User> users = dataContext.Users.ToList();
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(users);
            if (addDepartmentForm.ShowDialog() == DialogResult.OK)
            {
                dataContext.Departments.Add(addDepartmentForm.NewDepartment);
                dataContext.SaveChanges();
            }
        }

        private void lbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project selectedProject = (Project)lbProjects.SelectedItem;

            if (selectedProject == null) return;

            dataContext.Entry(selectedProject).Reference(p => p.Client).Load();
            dataContext.Entry(selectedProject).Collection(p => p.Tasks).Load();

            labelProjName.Text = selectedProject.Title;
            labelProjDesc.Text = selectedProject.Description;

            gbProjInfo.Visible = true;
            labelProjStart.Text = $"Start date: {selectedProject.Start.ToString("dd.MM.yyyy")}";
            labelProjEnd.Text = $"End date: {selectedProject.End.ToString("dd.M.yyyy")}";

            labelProjClient.Text = selectedProject.Client != null ? $"Client: {selectedProject.Client.Name}" : String.Empty;

            dgTasks.Visible = true;
            foreach (Entities.Task task in selectedProject.Tasks)
            {
                dgTasks.Rows.Add(task);
            }
        }

        private void dgTasks_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataContext.SaveChanges();
        }

        private void lbProjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lbProjects.SelectedIndex = lbProjects.IndexFromPoint(e.Location);
                if (lbProjects.SelectedIndex != -1)
                {
                    cmProjects.Show(Cursor.Position);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project selectedProject = (Project)lbProjects.SelectedItem;

            if (selectedProject == null) return;

            dataContext.Remove(selectedProject);
            dataContext.SaveChanges();
        }

        private void taskTimer_Tick(object sender, EventArgs e)
        {
            trackedTime.Interval += 1;
            tsTimeLabel.Text = $"Time tracked: {trackedTime.Interval} seconds";
        }

        private void startTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskTimer.Start();
            trackedTime.Interval = 0;
        }

        private void stopTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskTimer.Stop();

            // TODO: Insert in Task
        }
    }
}