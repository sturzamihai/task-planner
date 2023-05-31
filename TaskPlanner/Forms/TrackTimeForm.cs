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

namespace TaskPlanner.Forms
{
    public partial class TrackTimeForm : Form
    {
        private List<Entities.Task> tasks;
        private TrackedTime time;
        private bool formFinished;

        public TrackTimeForm(List<Entities.Task> tasks, TrackedTime time)
        {
            InitializeComponent();

            this.tasks = tasks;
            this.time = time;
            this.formFinished = false;

            foreach (Entities.Task task in tasks)
            {
                cbTasks.Items.Add(task.Title);
            }

            labelStart.Text = time.StartTime.ToString();
            labelEnd.Text = time.EndTime.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cbTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task");
                return;
            }

            this.tasks[cbTasks.SelectedIndex].TimesTracked.Add(time);
            this.DialogResult = DialogResult.OK;
            this.formFinished = true;
        }

        private void TrackTimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.formFinished)
            {
                if (MessageBox.Show("If you leave, you'll lose the tracked time.", "Are you sure you want to cancel?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
