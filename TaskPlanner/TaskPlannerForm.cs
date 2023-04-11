using TaskPlanner.Departments;
using TaskPlanner.Persistance;
using TaskPlanner.Projects;
using TaskPlanner.Users;

namespace TaskPlanner
{
    public partial class TaskPlanner : Form
    {
        DataContext dataContext;

        public TaskPlanner()
        {
            InitializeComponent();
            dataContext = new DataContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Project> projects = dataContext.Projects.ToList();
            foreach (Project project in projects)
            {
                lbProjects.Items.Add(project.Title);
            }
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
                lbProjects.Items.Add(addProjectForm.NewProject.Title);
                dataContext.SaveChanges();
            }
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<User> users = dataContext.Users.ToList();
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(users);
            if(addDepartmentForm.ShowDialog() == DialogResult.OK)
            {
                dataContext.Departments.Add(addDepartmentForm.NewDepartment);
                dataContext.SaveChanges();
            }
        }
    }
}