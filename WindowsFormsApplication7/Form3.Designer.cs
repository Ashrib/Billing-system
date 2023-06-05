namespace WindowsFormsApplication7
{
    partial class AdminLoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(142, 125);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(60, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(142, 177);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(225, 122);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(185, 20);
            this.userNameField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(225, 177);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(185, 20);
            this.passwordField.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(267, 244);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // AdminLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 362);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginPage";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginBtn;
    }
}