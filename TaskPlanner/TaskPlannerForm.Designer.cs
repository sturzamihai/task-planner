namespace TaskPlanner
{
    partial class TaskPlanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            addDepartmentToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            btnAddTask = new Button();
            Project = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lbProjects = new ListBox();
            tcProject = new TabControl();
            tpOverview = new TabPage();
            labelProjDesc = new Label();
            labelProjName = new Label();
            btnAddProj = new Button();
            menuStrip.SuspendLayout();
            tcProject.SuspendLayout();
            tpOverview.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, usersToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, addDepartmentToolStripMenuItem, manageUsersToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(161, 22);
            addUserToolStripMenuItem.Text = "Add user";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // addDepartmentToolStripMenuItem
            // 
            addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            addDepartmentToolStripMenuItem.Size = new Size(161, 22);
            addDepartmentToolStripMenuItem.Text = "Add department";
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(161, 22);
            manageUsersToolStripMenuItem.Text = "Manage users";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(12, 27);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(175, 39);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "(+) Add task";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // Project
            // 
            Project.HeaderText = "Project";
            Project.Name = "Project";
            Project.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "Projects";
            // 
            // lbProjects
            // 
            lbProjects.FormattingEnabled = true;
            lbProjects.ItemHeight = 15;
            lbProjects.Location = new Point(12, 87);
            lbProjects.Name = "lbProjects";
            lbProjects.Size = new Size(175, 319);
            lbProjects.TabIndex = 5;
            // 
            // tcProject
            // 
            tcProject.Controls.Add(tpOverview);
            tcProject.Location = new Point(193, 27);
            tcProject.Name = "tcProject";
            tcProject.SelectedIndex = 0;
            tcProject.Size = new Size(595, 411);
            tcProject.TabIndex = 6;
            // 
            // tpOverview
            // 
            tpOverview.Controls.Add(labelProjDesc);
            tpOverview.Controls.Add(labelProjName);
            tpOverview.Location = new Point(4, 24);
            tpOverview.Name = "tpOverview";
            tpOverview.Padding = new Padding(3);
            tpOverview.Size = new Size(587, 383);
            tpOverview.TabIndex = 0;
            tpOverview.Text = "Overview";
            tpOverview.UseVisualStyleBackColor = true;
            // 
            // labelProjDesc
            // 
            labelProjDesc.AutoSize = true;
            labelProjDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProjDesc.Location = new Point(9, 28);
            labelProjDesc.Name = "labelProjDesc";
            labelProjDesc.Size = new Size(218, 15);
            labelProjDesc.TabIndex = 1;
            labelProjDesc.Text = "Select a project from the list on your left";
            // 
            // labelProjName
            // 
            labelProjName.AutoSize = true;
            labelProjName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProjName.Location = new Point(6, 3);
            labelProjName.Name = "labelProjName";
            labelProjName.Size = new Size(183, 25);
            labelProjName.TabIndex = 0;
            labelProjName.Text = "No project selected";
            // 
            // btnAddProj
            // 
            btnAddProj.Location = new Point(12, 412);
            btnAddProj.Name = "btnAddProj";
            btnAddProj.Size = new Size(175, 23);
            btnAddProj.TabIndex = 7;
            btnAddProj.Text = "Create project";
            btnAddProj.UseVisualStyleBackColor = true;
            btnAddProj.Click += btnAddProj_Click;
            // 
            // TaskPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProj);
            Controls.Add(tcProject);
            Controls.Add(lbProjects);
            Controls.Add(label1);
            Controls.Add(btnAddTask);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "TaskPlanner";
            Text = "Task Planner";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tcProject.ResumeLayout(false);
            tpOverview.ResumeLayout(false);
            tpOverview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem addDepartmentToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private Button btnAddTask;
        private DataGridViewTextBoxColumn Project;
        private Label label1;
        private ListBox lbProjects;
        private TabControl tcProject;
        private TabPage tpOverview;
        private Label labelProjDesc;
        private Label labelProjName;
        private Button btnAddProj;
    }
}