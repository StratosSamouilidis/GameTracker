namespace GameTracker
{
    partial class registerForm
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
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.verificationLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.userTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.UserTableAdapter();
            this.goLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(116, 59);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTxtBox.TabIndex = 0;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(116, 101);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 1;
            // 
            // verificationLabel
            // 
            this.verificationLabel.AutoSize = true;
            this.verificationLabel.Location = new System.Drawing.Point(116, 188);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(35, 13);
            this.verificationLabel.TabIndex = 2;
            this.verificationLabel.Text = "label1";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(116, 149);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // goLoginBtn
            // 
            this.goLoginBtn.Location = new System.Drawing.Point(366, 149);
            this.goLoginBtn.Name = "goLoginBtn";
            this.goLoginBtn.Size = new System.Drawing.Size(130, 23);
            this.goLoginBtn.TabIndex = 4;
            this.goLoginBtn.Text = "Back To login";
            this.goLoginBtn.UseVisualStyleBackColor = true;
            this.goLoginBtn.Click += new System.EventHandler(this.goLoginBtn_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goLoginBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.verificationLabel);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label verificationLabel;
        private System.Windows.Forms.Button registerBtn;
        private GameTracke_DatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.Button goLoginBtn;
    }
}