namespace TaskPlanner.Users
{
    partial class AddUserForm
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
            tbName = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            cbRole = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Add a new user";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 127);
            tbName.Name = "tbName";
            tbName.Size = new Size(249, 23);
            tbName.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 182);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(249, 23);
            tbEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 109);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 164);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(249, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add user";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbRole
            // 
            cbRole.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Employee", "Manager", "Client" });
            cbRole.Location = new Point(12, 71);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(249, 23);
            cbRole.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 53);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // AddUserForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 266);
            Controls.Add(label4);
            Controls.Add(cbRole);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "AddUserForm";
            Text = "Add User - Task Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private TextBox tbEmail;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private ComboBox cbRole;
        private Label label4;
    }
}