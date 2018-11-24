namespace GameTracker
{
    partial class Register
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
            this.UserNameR = new System.Windows.Forms.Label();
            this.PasswordR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordR = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AlreadyUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameR
            // 
            this.UserNameR.AutoSize = true;
            this.UserNameR.Location = new System.Drawing.Point(179, 137);
            this.UserNameR.Name = "UserNameR";
            this.UserNameR.Size = new System.Drawing.Size(74, 16);
            this.UserNameR.TabIndex = 0;
            this.UserNameR.Text = "UserName";
            // 
            // PasswordR
            // 
            this.PasswordR.AutoSize = true;
            this.PasswordR.Location = new System.Drawing.Point(179, 188);
            this.PasswordR.Name = "PasswordR";
            this.PasswordR.Size = new System.Drawing.Size(68, 16);
            this.PasswordR.TabIndex = 1;
            this.PasswordR.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 183);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(304, 270);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 37);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ConfirmPasswordR
            // 
            this.ConfirmPasswordR.AutoSize = true;
            this.ConfirmPasswordR.Location = new System.Drawing.Point(179, 229);
            this.ConfirmPasswordR.Name = "ConfirmPasswordR";
            this.ConfirmPasswordR.Size = new System.Drawing.Size(113, 16);
            this.ConfirmPasswordR.TabIndex = 5;
            this.ConfirmPasswordR.Text = "ConfirmPassword";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 22);
            this.textBox3.TabIndex = 6;
            // 
            // AlreadyUserButton
            // 
            this.AlreadyUserButton.Location = new System.Drawing.Point(635, 407);
            this.AlreadyUserButton.Name = "AlreadyUserButton";
            this.AlreadyUserButton.Size = new System.Drawing.Size(101, 40);
            this.AlreadyUserButton.TabIndex = 7;
            this.AlreadyUserButton.Text = "AlreadyUser";
            this.AlreadyUserButton.UseVisualStyleBackColor = true;
            this.AlreadyUserButton.Click += new System.EventHandler(this.AlreadyUserButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 500);
            this.Controls.Add(this.AlreadyUserButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ConfirmPasswordR);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordR);
            this.Controls.Add(this.UserNameR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.Text = " User Registration";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameR;
        private System.Windows.Forms.Label PasswordR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ConfirmPasswordR;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button AlreadyUserButton;
    }
}