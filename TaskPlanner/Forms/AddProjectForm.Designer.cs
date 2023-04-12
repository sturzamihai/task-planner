namespace TaskPlanner.Projects
{
    partial class AddProjectForm
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
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbDescription = new TextBox();
            clbDepartments = new CheckedListBox();
            label4 = new Label();
            dtStart = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dtEnd = new DateTimePicker();
            cbClient = new ComboBox();
            label7 = new Label();
            btnCreate = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Add a new project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Name *";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 71);
            tbName.Name = "tbName";
            tbName.Size = new Size(249, 23);
            tbName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(12, 124);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(249, 111);
            tbDescription.TabIndex = 7;
            // 
            // clbDepartments
            // 
            clbDepartments.FormattingEnabled = true;
            clbDepartments.Location = new Point(537, 71);
            clbDepartments.Name = "clbDepartments";
            clbDepartments.Size = new Size(193, 166);
            clbDepartments.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 53);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 10;
            label4.Text = "Involved departments *";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(301, 71);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(200, 23);
            dtStart.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 53);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 12;
            label5.Text = "Start date *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 106);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "End date *";
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(301, 124);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(200, 23);
            dtEnd.TabIndex = 13;
            // 
            // cbClient
            // 
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(301, 212);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(200, 23);
            cbClient.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 194);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 16;
            label7.Text = "Client";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(615, 253);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 23);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create Project";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 263);
            label8.Name = "label8";
            label8.Size = new Size(189, 13);
            label8.TabIndex = 18;
            label8.Text = "Fields marked with * are mandatory";
            // 
            // AddProjectForm
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 288);
            Controls.Add(label8);
            Controls.Add(btnCreate);
            Controls.Add(label7);
            Controls.Add(cbClient);
            Controls.Add(label6);
            Controls.Add(dtEnd);
            Controls.Add(label5);
            Controls.Add(dtStart);
            Controls.Add(label4);
            Controls.Add(clbDepartments);
            Controls.Add(label3);
            Controls.Add(tbDescription);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "AddProjectForm";
            Text = "Add project - Task Planner";
            Load += AddProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox tbDescription;
        private CheckedListBox clbDepartments;
        private Label label4;
        private DateTimePicker dtStart;
        private Label label5;
        private Label label6;
        private DateTimePicker dtEnd;
        private ComboBox cbClient;
        private Label label7;
        private Button btnCreate;
        private Label label8;
    }
}