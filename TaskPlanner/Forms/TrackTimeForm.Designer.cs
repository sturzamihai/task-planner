namespace TaskPlanner.Forms
{
    partial class TrackTimeForm
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
            labelFormName = new Label();
            cbTasks = new ComboBox();
            label1 = new Label();
            gbProjInfo = new GroupBox();
            labelProjClient = new Label();
            labelEnd = new Label();
            labelStart = new Label();
            btnRegister = new Button();
            gbProjInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormName
            // 
            labelFormName.AutoSize = true;
            labelFormName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormName.Location = new Point(12, 9);
            labelFormName.Name = "labelFormName";
            labelFormName.Size = new Size(0, 25);
            labelFormName.TabIndex = 3;
            // 
            // cbTasks
            // 
            cbTasks.FormattingEnabled = true;
            cbTasks.Location = new Point(12, 80);
            cbTasks.Name = "cbTasks";
            cbTasks.Size = new Size(272, 23);
            cbTasks.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // gbProjInfo
            // 
            gbProjInfo.Controls.Add(labelProjClient);
            gbProjInfo.Controls.Add(labelEnd);
            gbProjInfo.Controls.Add(labelStart);
            gbProjInfo.Location = new Point(12, 12);
            gbProjInfo.Name = "gbProjInfo";
            gbProjInfo.Size = new Size(272, 62);
            gbProjInfo.TabIndex = 6;
            gbProjInfo.TabStop = false;
            gbProjInfo.Text = "Tracked time";
            // 
            // labelProjClient
            // 
            labelProjClient.AutoSize = true;
            labelProjClient.Location = new Point(339, 19);
            labelProjClient.Name = "labelProjClient";
            labelProjClient.Size = new Size(0, 15);
            labelProjClient.TabIndex = 2;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(6, 39);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(53, 15);
            labelEnd.TabIndex = 1;
            labelEnd.Text = "End date";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 19);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(57, 15);
            labelStart.TabIndex = 0;
            labelStart.Text = "Start date";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 109);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(272, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register time";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // TrackTimeForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 146);
            Controls.Add(btnRegister);
            Controls.Add(gbProjInfo);
            Controls.Add(label1);
            Controls.Add(cbTasks);
            Controls.Add(labelFormName);
            Name = "TrackTimeForm";
            Text = "Track time - Task Planner";
            FormClosing += TrackTimeForm_FormClosing;
            gbProjInfo.ResumeLayout(false);
            gbProjInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFormName;
        private ComboBox cbTasks;
        private Label label1;
        private GroupBox gbProjInfo;
        private Label labelProjClient;
        private Label labelEnd;
        private Label labelStart;
        private Button btnRegister;
    }
}