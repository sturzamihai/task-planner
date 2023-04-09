using TaskPlanner.Projects;
using TaskPlanner.Users;

namespace TaskPlanner
{
    public partial class TaskPlanner : Form
    {
        private List<User> users;

        public TaskPlanner()
        {
            InitializeComponent();
            users = new List<User>();
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

            AddProjectForm newProject = new AddProjectForm(clients);
            newProject.ShowDialog();
        }
    }
}