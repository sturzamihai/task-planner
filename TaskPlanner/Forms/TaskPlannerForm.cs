using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using TaskPlanner.Departments;
using TaskPlanner.Entities;
using TaskPlanner.Entities.Users;
using TaskPlanner.Forms;
using TaskPlanner.Persistance;
using TaskPlanner.Projects;
using TaskPlanner.Users;

namespace TaskPlanner
{
    public partial class TaskPlanner : Form
    {
        private DataContext dataContext;
        private User activeUser;
        private Project selectedProject;
        TrackedTime trackedTime;

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
                return;
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
            selectedProject = (Project)lbProjects.SelectedItem;

            if (selectedProject == null) return;

            refreshProjectDisplay();
        }

        private void refreshProjectDisplay()
        {
            dataContext.Entry(selectedProject).Reference(p => p.Client).Load();
            dataContext.Entry(selectedProject).Collection(p => p.Tasks).Load();
            dataContext.Entry(selectedProject).Collection(p => p.AllowedStatuses).Load();

            labelProjName.Text = selectedProject.Title;
            labelProjDesc.Text = selectedProject.Description;

            gbProjInfo.Visible = true;
            labelProjStart.Text = $"Start date: {selectedProject.Start.ToString("dd.MM.yyyy")}";
            labelProjEnd.Text = $"End date: {selectedProject.End.ToString("dd.M.yyyy")}";

            labelProjClient.Text = selectedProject.Client != null ? $"Client: {selectedProject.Client.Name}" : String.Empty;

            dgTasks.Visible = true;
            dgTasks.Rows.Clear();
            foreach (Entities.Task task in selectedProject.Tasks)
            {
                dataContext.Entry(task).Reference(t => t.Status).Load();
                dataContext.Entry(task).Reference(t => t.Asignee).Load();
                dataContext.Entry(task).Collection(t => t.TimesTracked).Load();
                dgTasks.Rows.Add(new String[] { task.Status.Title, task.Title, task.Asignee.Name, task.CalculateTrackedTime().ToString(), "Edit" });
            }
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
            selectedProject = (Project)lbProjects.SelectedItem;

            if (selectedProject == null) return;

            dataContext.Remove(selectedProject);
            dataContext.SaveChanges();
        }

        private void taskTimer_Tick(object sender, EventArgs e)
        {
            trackedTime.EndTime = DateTime.Now;
            tsTimeLabel.Text = $"Time tracked: {trackedTime.Interval()}";
        }

        private void startTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskTimer.Start();
            trackedTime = new TrackedTime();
            trackedTime.StartTime = DateTime.Now;
        }

        private void stopTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskTimer.Stop();

            if (trackedTime == null)
            {
                MessageBox.Show("You have not started a timer yet.");
                return;
            }

            trackedTime.EndTime = DateTime.Now;
            trackedTime.User = activeUser;

            TrackTimeForm trackTimeForm = new TrackTimeForm(dataContext.Tasks.ToList(), trackedTime);
            if (trackTimeForm.ShowDialog() == DialogResult.OK)
            {
                dataContext.SaveChanges();
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            List<Project> projects = dataContext.Projects.ToList();
            projects.ForEach(project => dataContext.Entry(project).Collection(p => p.AllowedStatuses).Load());

            ManageTaskForm addTaskForm = new ManageTaskForm(projects, dataContext.Users.ToList());
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                projects[addTaskForm.SelectedProject].Tasks.Add(addTaskForm.NewTask);
                dataContext.SaveChanges();
            }
        }

        private void dgTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderDG = (DataGridView)sender;

            if (senderDG.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && selectedProject.Tasks.Count > e.RowIndex)
            {
                ManageTaskForm editTaskForm = new ManageTaskForm(selectedProject.Tasks[e.RowIndex], dataContext.Users.ToList());
                if (editTaskForm.ShowDialog() == DialogResult.OK)
                {
                    dataContext.SaveChanges();
                    refreshProjectDisplay();
                }
            }
        }
    }
}