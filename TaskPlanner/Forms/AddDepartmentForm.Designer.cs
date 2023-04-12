namespace TaskPlanner.Departments
{
    partial class AddDepartmentForm
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
            clbMembers = new CheckedListBox();
            btnAdd = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 1;
            label1.Text = "Add a new department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 68);
            tbName.Name = "tbName";
            tbName.Size = new Size(251, 23);
            tbName.TabIndex = 5;
            // 
            // clbMembers
            // 
            clbMembers.FormattingEnabled = true;
            clbMembers.Location = new Point(12, 115);
            clbMembers.Name = "clbMembers";
            clbMembers.Size = new Size(251, 130);
            clbMembers.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add department";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 97);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Members";
            // 
            // AddDepartmentForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 292);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(clbMembers);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "AddDepartmentForm";
            Text = "Add Department - Task Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private CheckedListBox clbMembers;
        private Button btnAdd;
        private Label label3;
    }
}