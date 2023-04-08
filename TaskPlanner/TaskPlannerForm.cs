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
    }
}