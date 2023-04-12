namespace TaskPlanner.Users
{
    partial class LoginForm
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
            tbEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 199);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 253);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(297, 23);
            tbEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 235);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 289);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 307);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(297, 23);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(297, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.TaskPlannerLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 170);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 392);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Log in - Task Planner";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}