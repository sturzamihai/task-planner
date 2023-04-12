using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskPlanner.Entities;
using TaskPlanner.Entities.Users;

namespace TaskPlanner.Projects
{
    public partial class AddProjectForm : Form
    {
        private List<Client> clients;
        private List<Department> departments;

        public Project NewProject { get; set; }

        public AddProjectForm(List<Client> clients, List<Department> departments)
        {
            InitializeComponent();

            this.clients = clients;
            foreach (Client client in clients)
            {
                cbClient.Items.Add(client.Name);
            }

            this.departments = departments;
            foreach (Department department in departments)
            {
                clbDepartments.Items.Add(department.Name);
            }
        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text == "")
            {
                MessageBox.Show("The name of the project should not be null.");
                return;
            }

            if (departments.Count > 0 && clbDepartments.CheckedIndices.Count == 0)
            {
                MessageBox.Show("You should select at least one department.");
                return;
            }

            if (dtStart.Checked == false || dtEnd.Checked == false)
            {
                MessageBox.Show("The dates you entered are invalid.");
                return;
            }

            if (dtStart.Value >= dtEnd.Value)
            {
                MessageBox.Show("The start date can't be later or in the same day as the end date.");
                return;
            }

            List<Department> selectedDepartments = new List<Department>();
            foreach (int i in clbDepartments.CheckedIndices)
            {
                selectedDepartments.Add(departments[i]);
            }

            Client? selectedClient = null;
            if (cbClient.SelectedIndex >= 0)
            {
                selectedClient = clients[cbClient.SelectedIndex];
            }

            NewProject = new Project()
            {
                Title = tbName.Text,
                Description = tbDescription.Text,
                Start = dtStart.Value,
                End = dtEnd.Value,
                Departments = selectedDepartments,
                Tasks = new List<Entities.Task>(),
                Client = selectedClient
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
