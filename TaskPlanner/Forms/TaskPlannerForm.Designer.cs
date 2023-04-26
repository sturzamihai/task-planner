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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            addDepartmentToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            manageTaskStatusesToolStripMenuItem = new ToolStripMenuItem();
            btnAddTask = new Button();
            Project = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lbProjects = new ListBox();
            projectBindingSource = new BindingSource(components);
            cmProjects = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tcProject = new TabControl();
            tpOverview = new TabPage();
            gbProjInfo = new GroupBox();
            labelProjClient = new Label();
            labelProjEnd = new Label();
            labelProjStart = new Label();
            dgTasks = new DataGridView();
            labelProjDesc = new Label();
            labelProjName = new Label();
            tbInsights = new TabPage();
            btnAddProj = new Button();
            statusStrip = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            startTrackingToolStripMenuItem = new ToolStripMenuItem();
            stopTrackingToolStripMenuItem = new ToolStripMenuItem();
            tsTimeLabel = new ToolStripStatusLabel();
            tsLabelUser = new ToolStripStatusLabel();
            taskTimer = new System.Windows.Forms.Timer(components);
            colId = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAsignee = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewButtonColumn();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            cmProjects.SuspendLayout();
            tcProject.SuspendLayout();
            tpOverview.SuspendLayout();
            gbProjInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTasks).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, projectsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
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
            addDepartmentToolStripMenuItem.Click += addDepartmentToolStripMenuItem_Click;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(161, 22);
            manageUsersToolStripMenuItem.Text = "Manage users";
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageTaskStatusesToolStripMenuItem });
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(61, 20);
            projectsToolStripMenuItem.Text = "Projects";
            // 
            // manageTaskStatusesToolStripMenuItem
            // 
            manageTaskStatusesToolStripMenuItem.Name = "manageTaskStatusesToolStripMenuItem";
            manageTaskStatusesToolStripMenuItem.Size = new Size(186, 22);
            manageTaskStatusesToolStripMenuItem.Text = "Manage task statuses";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(12, 27);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(175, 39);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "(+) Add task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
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
            lbProjects.DataSource = projectBindingSource;
            lbProjects.DisplayMember = "Title";
            lbProjects.FormattingEnabled = true;
            lbProjects.ItemHeight = 15;
            lbProjects.Location = new Point(12, 87);
            lbProjects.Name = "lbProjects";
            lbProjects.Size = new Size(175, 319);
            lbProjects.TabIndex = 5;
            lbProjects.SelectedIndexChanged += lbProjects_SelectedIndexChanged;
            lbProjects.MouseDown += lbProjects_MouseDown;
            // 
            // projectBindingSource
            // 
            projectBindingSource.DataSource = typeof(Entities.Project);
            // 
            // cmProjects
            // 
            cmProjects.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, deleteToolStripMenuItem });
            cmProjects.Name = "cmProjects";
            cmProjects.Size = new Size(117, 48);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(116, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tcProject
            // 
            tcProject.Controls.Add(tpOverview);
            tcProject.Controls.Add(tbInsights);
            tcProject.Location = new Point(193, 27);
            tcProject.Name = "tcProject";
            tcProject.SelectedIndex = 0;
            tcProject.Size = new Size(595, 411);
            tcProject.TabIndex = 6;
            // 
            // tpOverview
            // 
            tpOverview.Controls.Add(gbProjInfo);
            tpOverview.Controls.Add(dgTasks);
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
            // gbProjInfo
            // 
            gbProjInfo.Controls.Add(labelProjClient);
            gbProjInfo.Controls.Add(labelProjEnd);
            gbProjInfo.Controls.Add(labelProjStart);
            gbProjInfo.Location = new Point(9, 56);
            gbProjInfo.Name = "gbProjInfo";
            gbProjInfo.Size = new Size(572, 40);
            gbProjInfo.TabIndex = 3;
            gbProjInfo.TabStop = false;
            gbProjInfo.Text = "Project Information";
            gbProjInfo.Visible = false;
            // 
            // labelProjClient
            // 
            labelProjClient.AutoSize = true;
            labelProjClient.Location = new Point(339, 19);
            labelProjClient.Name = "labelProjClient";
            labelProjClient.Size = new Size(38, 15);
            labelProjClient.TabIndex = 2;
            labelProjClient.Text = "Client";
            // 
            // labelProjEnd
            // 
            labelProjEnd.AutoSize = true;
            labelProjEnd.Location = new Point(185, 19);
            labelProjEnd.Name = "labelProjEnd";
            labelProjEnd.Size = new Size(53, 15);
            labelProjEnd.TabIndex = 1;
            labelProjEnd.Text = "End date";
            // 
            // labelProjStart
            // 
            labelProjStart.AutoSize = true;
            labelProjStart.Location = new Point(6, 19);
            labelProjStart.Name = "labelProjStart";
            labelProjStart.Size = new Size(57, 15);
            labelProjStart.TabIndex = 0;
            labelProjStart.Text = "Start date";
            // 
            // dgTasks
            // 
            dgTasks.AllowUserToAddRows = false;
            dgTasks.AllowUserToDeleteRows = false;
            dgTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTasks.Columns.AddRange(new DataGridViewColumn[] { colId, colStatus, colTitle, colAsignee, colActions });
            dgTasks.Location = new Point(9, 119);
            dgTasks.Name = "dgTasks";
            dgTasks.ReadOnly = true;
            dgTasks.RowTemplate.Height = 25;
            dgTasks.Size = new Size(572, 150);
            dgTasks.TabIndex = 2;
            dgTasks.Visible = false;
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
            // tbInsights
            // 
            tbInsights.Location = new Point(4, 24);
            tbInsights.Name = "tbInsights";
            tbInsights.Padding = new Padding(3);
            tbInsights.Size = new Size(587, 383);
            tbInsights.TabIndex = 1;
            tbInsights.Text = "Insights";
            tbInsights.UseVisualStyleBackColor = true;
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
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, tsTimeLabel, tsLabelUser });
            statusStrip.Location = new Point(0, 447);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 8;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { startTrackingToolStripMenuItem, stopTrackingToolStripMenuItem });
            toolStripSplitButton1.Image = Properties.Resources.TimeTrackerIcon;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // startTrackingToolStripMenuItem
            // 
            startTrackingToolStripMenuItem.Name = "startTrackingToolStripMenuItem";
            startTrackingToolStripMenuItem.Size = new Size(144, 22);
            startTrackingToolStripMenuItem.Text = "Start tracking";
            startTrackingToolStripMenuItem.Click += startTrackingToolStripMenuItem_Click;
            // 
            // stopTrackingToolStripMenuItem
            // 
            stopTrackingToolStripMenuItem.Name = "stopTrackingToolStripMenuItem";
            stopTrackingToolStripMenuItem.Size = new Size(144, 22);
            stopTrackingToolStripMenuItem.Text = "Stop tracking";
            stopTrackingToolStripMenuItem.Click += stopTrackingToolStripMenuItem_Click;
            // 
            // tsTimeLabel
            // 
            tsTimeLabel.Name = "tsTimeLabel";
            tsTimeLabel.Size = new Size(183, 17);
            tsTimeLabel.Text = "Time tracked: <No timer started>";
            // 
            // tsLabelUser
            // 
            tsLabelUser.Name = "tsLabelUser";
            tsLabelUser.Size = new Size(570, 17);
            tsLabelUser.Spring = true;
            tsLabelUser.Text = "Active user: <Loading...>";
            tsLabelUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taskTimer
            // 
            taskTimer.Interval = 1000;
            taskTimer.Tick += taskTimer_Tick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAsignee
            // 
            colAsignee.HeaderText = "Asignee";
            colAsignee.Name = "colAsignee";
            colAsignee.ReadOnly = true;
            // 
            // colActions
            // 
            colActions.HeaderText = "Actions";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Text = "";
            // 
            // TaskPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(statusStrip);
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
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).EndInit();
            cmProjects.ResumeLayout(false);
            tcProject.ResumeLayout(false);
            tpOverview.ResumeLayout(false);
            tpOverview.PerformLayout();
            gbProjInfo.ResumeLayout(false);
            gbProjInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgTasks).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
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
        private BindingSource projectBindingSource;
        private DataGridView dgTasks;
        private GroupBox gbProjInfo;
        private Label labelProjClient;
        private Label labelProjEnd;
        private Label labelProjStart;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsTimeLabel;
        private System.Windows.Forms.Timer taskTimer;
        private ContextMenuStrip cmProjects;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripStatusLabel tsLabelUser;
        private TabPage tbInsights;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem startTrackingToolStripMenuItem;
        private ToolStripMenuItem stopTrackingToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem manageTaskStatusesToolStripMenuItem;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAsignee;
        private DataGridViewButtonColumn colActions;
    }
}