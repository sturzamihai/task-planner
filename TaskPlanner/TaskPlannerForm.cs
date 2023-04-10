using TaskPlanner.Departments;
using TaskPlanner.Projects;
using TaskPlanner.Users;

namespace TaskPlanner
{
    public partial class TaskPlanner : Form
    {
        private List<User> users;
        private List<Department> departments;
        private List<Project> projects;

        public TaskPlanner()
        {
            InitializeComponent();
            users = new List<User>();
            departments = new List<Department>();
            projects = new List<Project>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                users.Add(addUserForm.NewUser);
            }
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            foreach (User client in users)
            {
                if (typeof(Client).IsInstanceOfType(client))
                {
                    clients.Add((Client)client);
                }
            }

            AddProjectForm newProject = new AddProjectForm(clients, departments);
            if (newProject.ShowDialog() == DialogResult.OK)
            {
                projects.Add(newProject.NewProject);
            }

            lbProjects.Items.Clear();
            foreach (Project project in projects)
            {
                lbProjects.Items.Add(project.Title);
            }
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartmentForm newDepartment = new AddDepartmentForm(users);
            if(newDepartment.ShowDialog() == DialogResult.OK)
            {
                departments.Add(newDepartment.NewDepartment);
            }
        }
    }
}