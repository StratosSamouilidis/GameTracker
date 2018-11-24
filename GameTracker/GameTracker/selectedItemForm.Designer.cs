namespace GameTracker
{
    partial class selectedItemForm
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
            this.SelectedGameOptions = new System.Windows.Forms.ComboBox();
            this.SelectedGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectedGameOptions
            // 
            this.SelectedGameOptions.FormattingEnabled = true;
            this.SelectedGameOptions.Items.AddRange(new object[] {
            "Open in Browser",
            "Add to watchlist"});
            this.SelectedGameOptions.Location = new System.Drawing.Point(95, 71);
            this.SelectedGameOptions.Name = "SelectedGameOptions";
            this.SelectedGameOptions.Size = new System.Drawing.Size(191, 21);
            this.SelectedGameOptions.TabIndex = 0;
            // 
            // SelectedGameBtn
            // 
            this.SelectedGameBtn.Location = new System.Drawing.Point(95, 148);
            this.SelectedGameBtn.Name = "SelectedGameBtn";
            this.SelectedGameBtn.Size = new System.Drawing.Size(191, 23);
            this.SelectedGameBtn.TabIndex = 1;
            this.SelectedGameBtn.Text = "Proceed";
            this.SelectedGameBtn.UseVisualStyleBackColor = true;
            this.SelectedGameBtn.Click += new System.EventHandler(this.SelectedGameBtn_Click);
            // 
            // selectedItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.SelectedGameBtn);
            this.Controls.Add(this.SelectedGameOptions);
            this.Name = "selectedItemForm";
            this.Text = "What To Do?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedGameOptions;
        private System.Windows.Forms.Button SelectedGameBtn;
    }
}