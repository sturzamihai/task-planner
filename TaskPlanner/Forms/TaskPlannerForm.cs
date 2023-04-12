using Microsoft.EntityFrameworkCore;
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
        DataContext dataContext;
        public TaskPlanner(DataContext dataContext)
        {
            InitializeComponent();
            this.dataContext = dataContext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataContext.Projects.Load();
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
            int? projectId = ((Project)lbProjects.SelectedItem)?.Id;

            if (projectId == null) return;

            Project selectedProject = dataContext.Projects.Include(p => p.Client).Single(p => p.Id == projectId);

            if (selectedProject == null) return;

            labelProjName.Text = selectedProject.Title;
            labelProjDesc.Text = selectedProject.Description;

            gbProjInfo.Visible = true;
            labelProjStart.Text = $"Start date: {selectedProject.Start.ToString("dd.MM.yyyy")}";
            labelProjEnd.Text = $"End date: {selectedProject.End.ToString("dd.M.yyyy")}";

            labelProjClient.Text = selectedProject.Client != null ? $"Client: {selectedProject.Client.Name}" : String.Empty;

            dgTasks.Visible = true;

            dataContext.Entry(selectedProject).Collection(p => p.Tasks).Load();
            taskBindingSource.DataSource = dataContext.Tasks.Local.ToList();
        }

        private void dgTasks_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataContext.SaveChanges();
        }
    }
}