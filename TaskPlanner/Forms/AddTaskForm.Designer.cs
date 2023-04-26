namespace TaskPlanner.Forms
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label4 = new Label();
            cbProject = new ComboBox();
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            cbStatus = new ComboBox();
            label5 = new Label();
            tbDescription = new TextBox();
            label6 = new Label();
            cbAsignee = new ComboBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 2;
            label1.Text = "Add a new task";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 44);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Project *";
            // 
            // cbProject
            // 
            cbProject.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbProject.FormattingEnabled = true;
            cbProject.Location = new Point(12, 62);
            cbProject.Name = "cbProject";
            cbProject.Size = new Size(220, 23);
            cbProject.TabIndex = 9;
            cbProject.SelectedIndexChanged += cbProject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 149);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Title *";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 167);
            tbName.Name = "tbName";
            tbName.Size = new Size(363, 23);
            tbName.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 44);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "Status *";
            // 
            // cbStatus
            // 
            cbStatus.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(238, 62);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(137, 23);
            cbStatus.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 207);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 16;
            label5.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(12, 225);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(363, 115);
            tbDescription.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 94);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 18;
            label6.Text = "Assignee *";
            // 
            // cbAsignee
            // 
            cbAsignee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbAsignee.FormattingEnabled = true;
            cbAsignee.Location = new Point(12, 112);
            cbAsignee.Name = "cbAsignee";
            cbAsignee.Size = new Size(363, 23);
            cbAsignee.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(363, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddTaskForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 392);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(cbAsignee);
            Controls.Add(label5);
            Controls.Add(tbDescription);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(cbProject);
            Controls.Add(label1);
            Name = "AddTaskForm";
            Text = "Add Task - Task Planner";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private ComboBox cbProject;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private ComboBox cbStatus;
        private Label label5;
        private TextBox tbDescription;
        private Label label6;
        private ComboBox cbAsignee;
        private Button btnAdd;
    }
}