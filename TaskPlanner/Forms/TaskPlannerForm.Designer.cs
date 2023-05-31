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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            manageDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            btnAddTask = new Button();
            Project = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lbProjects = new ListBox();
            projectBindingSource = new BindingSource(components);
            cmProjects = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            manageProjectStatusesToolStripMenuItem = new ToolStripMenuItem();
            exportXMLToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tcProject = new TabControl();
            tpOverview = new TabPage();
            gbProjInfo = new GroupBox();
            labelProjClient = new Label();
            labelProjEnd = new Label();
            labelProjStart = new Label();
            dgTasks = new DataGridView();
            colStatus = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAsignee = new DataGridViewTextBoxColumn();
            colTimeTracked = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewButtonColumn();
            labelProjDesc = new Label();
            labelProjName = new Label();
            tbInsights = new TabPage();
            lvHours = new ListView();
            colTaskNameTH = new ColumnHeader();
            colAsigneeTH = new ColumnHeader();
            colStartTH = new ColumnHeader();
            colEndTH = new ColumnHeader();
            colIntervalTH = new ColumnHeader();
            label4 = new Label();
            chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label2 = new Label();
            chartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAddProj = new Button();
            statusStrip = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            startTrackingToolStripMenuItem = new ToolStripMenuItem();
            stopTrackingToolStripMenuItem = new ToolStripMenuItem();
            tsTimeLabel = new ToolStripStatusLabel();
            tsLabelUser = new ToolStripStatusLabel();
            taskTimer = new System.Windows.Forms.Timer(components);
            printDocument = new System.Drawing.Printing.PrintDocument();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            cmProjects.SuspendLayout();
            tcProject.SuspendLayout();
            tpOverview.SuspendLayout();
            gbProjInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTasks).BeginInit();
            tbInsights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTasks).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, usersToolStripMenuItem, departmentsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { printPreviewToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(180, 22);
            printPreviewToolStripMenuItem.Text = "Print";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, manageUsersToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(147, 22);
            addUserToolStripMenuItem.Text = "Add user";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(147, 22);
            manageUsersToolStripMenuItem.Text = "Manage users";
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, manageDepartmentsToolStripMenuItem });
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(87, 20);
            departmentsToolStripMenuItem.Text = "Departments";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 22);
            toolStripMenuItem1.Text = "Add department";
            // 
            // manageDepartmentsToolStripMenuItem
            // 
            manageDepartmentsToolStripMenuItem.Name = "manageDepartmentsToolStripMenuItem";
            manageDepartmentsToolStripMenuItem.Size = new Size(187, 22);
            manageDepartmentsToolStripMenuItem.Text = "Manage departments";
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
            lbProjects.Size = new Size(175, 364);
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
            cmProjects.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exportXMLToolStripMenuItem, deleteToolStripMenuItem });
            cmProjects.Name = "cmProjects";
            cmProjects.Size = new Size(136, 70);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageProjectStatusesToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(135, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // manageProjectStatusesToolStripMenuItem
            // 
            manageProjectStatusesToolStripMenuItem.Name = "manageProjectStatusesToolStripMenuItem";
            manageProjectStatusesToolStripMenuItem.Size = new Size(202, 22);
            manageProjectStatusesToolStripMenuItem.Text = "Manage project statuses";
            // 
            // exportXMLToolStripMenuItem
            // 
            exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            exportXMLToolStripMenuItem.Size = new Size(135, 22);
            exportXMLToolStripMenuItem.Text = "Export XML";
            exportXMLToolStripMenuItem.Click += exportXMLToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(135, 22);
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
            tcProject.Size = new Size(595, 454);
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
            tpOverview.Size = new Size(587, 426);
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
            dgTasks.Columns.AddRange(new DataGridViewColumn[] { colStatus, colTitle, colAsignee, colTimeTracked, colActions });
            dgTasks.Location = new Point(9, 102);
            dgTasks.Name = "dgTasks";
            dgTasks.ReadOnly = true;
            dgTasks.RowTemplate.Height = 25;
            dgTasks.Size = new Size(572, 318);
            dgTasks.TabIndex = 2;
            dgTasks.Visible = false;
            dgTasks.CellContentClick += dgTasks_CellContentClick;
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
            // colTimeTracked
            // 
            colTimeTracked.HeaderText = "Time Tracked";
            colTimeTracked.Name = "colTimeTracked";
            colTimeTracked.ReadOnly = true;
            // 
            // colActions
            // 
            colActions.HeaderText = "Actions";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Text = "";
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
            tbInsights.Controls.Add(lvHours);
            tbInsights.Controls.Add(label4);
            tbInsights.Controls.Add(chartProgress);
            tbInsights.Controls.Add(label3);
            tbInsights.Controls.Add(label2);
            tbInsights.Controls.Add(chartTasks);
            tbInsights.Location = new Point(4, 24);
            tbInsights.Name = "tbInsights";
            tbInsights.Padding = new Padding(3);
            tbInsights.Size = new Size(587, 426);
            tbInsights.TabIndex = 1;
            tbInsights.Text = "Insights";
            tbInsights.UseVisualStyleBackColor = true;
            // 
            // lvHours
            // 
            lvHours.Columns.AddRange(new ColumnHeader[] { colTaskNameTH, colAsigneeTH, colStartTH, colEndTH, colIntervalTH });
            lvHours.GridLines = true;
            lvHours.Location = new Point(6, 303);
            lvHours.Name = "lvHours";
            lvHours.Size = new Size(567, 117);
            lvHours.TabIndex = 5;
            lvHours.UseCompatibleStateImageBehavior = false;
            lvHours.View = View.Details;
            // 
            // colTaskNameTH
            // 
            colTaskNameTH.Text = "Task name";
            colTaskNameTH.Width = 100;
            // 
            // colAsigneeTH
            // 
            colAsigneeTH.Text = "Tracked by";
            colAsigneeTH.Width = 80;
            // 
            // colStartTH
            // 
            colStartTH.Text = "Start date";
            colStartTH.Width = 80;
            // 
            // colEndTH
            // 
            colEndTH.Text = "End date";
            colEndTH.Width = 80;
            // 
            // colIntervalTH
            // 
            colIntervalTH.Text = "Interval";
            colIntervalTH.Width = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 284);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 4;
            label4.Text = "Hours tracked";
            // 
            // chartProgress
            // 
            chartArea1.Name = "ChartArea1";
            chartProgress.ChartAreas.Add(chartArea1);
            chartProgress.Location = new Point(291, 21);
            chartProgress.Name = "chartProgress";
            chartProgress.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Name = "ProjectProgress";
            chartProgress.Series.Add(series1);
            chartProgress.Size = new Size(282, 260);
            chartProgress.TabIndex = 3;
            chartProgress.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 3);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Progress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Workload";
            // 
            // chartTasks
            // 
            chartArea2.Name = "ChartArea1";
            chartTasks.ChartAreas.Add(chartArea2);
            chartTasks.Location = new Point(3, 21);
            chartTasks.Name = "chartTasks";
            series2.ChartArea = "ChartArea1";
            series2.Name = "TaskFrequency";
            chartTasks.Series.Add(series2);
            chartTasks.Size = new Size(282, 260);
            chartTasks.TabIndex = 0;
            chartTasks.Text = "chart1";
            // 
            // btnAddProj
            // 
            btnAddProj.Location = new Point(12, 454);
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
            statusStrip.Location = new Point(0, 484);
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
            // printDocument
            // 
            printDocument.DocumentName = "PRINT - Task Planner";
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // TaskPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
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
            tbInsights.ResumeLayout(false);
            tbInsights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTasks).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
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
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAsignee;
        private DataGridViewTextBoxColumn colTimeTracked;
        private DataGridViewButtonColumn colActions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTasks;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
        private Label label3;
        private ListView lvHours;
        private ColumnHeader colAsigneeTH;
        private ColumnHeader colStartTH;
        private ColumnHeader colEndTH;
        private ColumnHeader colIntervalTH;
        private Label label4;
        private ColumnHeader colTaskNameTH;
        private ToolStripMenuItem exportXMLToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem manageProjectStatusesToolStripMenuItem;
        private ToolStripMenuItem manageDepartmentsToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}