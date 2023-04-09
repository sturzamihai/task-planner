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

namespace TaskPlanner.Projects
{
    public partial class AddProjectForm : Form
    {
        private List<Client> clients;
        private List<Department> departments;
        public AddProjectForm(List<Client> clients, List<Department> departments)
        {
            InitializeComponent();

            this.clients = clients;
            foreach(Client client in clients) {
                cbClient.Items.Add(client.Name);
            }

            this.departments = departments;
            foreach(Department department in departments)
            {
                clbDepartments.Items.Add(department.Name);
            }
        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
