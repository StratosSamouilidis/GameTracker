namespace GameTracker
{
    partial class LoadResults
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
            this.LoadSteamBtn = new System.Windows.Forms.Button();
            this.HtmlResultsBox = new System.Windows.Forms.RichTextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SteamGamesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageSpinner = new System.Windows.Forms.NumericUpDown();
            this.LoadIGbtn = new System.Windows.Forms.Button();
            this.igDataGridView = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.GoToPreferencesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SteamGamesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadSteamBtn
            // 
            this.LoadSteamBtn.Location = new System.Drawing.Point(3, 12);
            this.LoadSteamBtn.Name = "LoadSteamBtn";
            this.LoadSteamBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadSteamBtn.TabIndex = 1;
            this.LoadSteamBtn.Text = "Load Steam";
            this.LoadSteamBtn.UseVisualStyleBackColor = true;
            this.LoadSteamBtn.Click += new System.EventHandler(this.LoadSteamBtn_Click);
            // 
            // HtmlResultsBox
            // 
            this.HtmlResultsBox.Location = new System.Drawing.Point(168, 314);
            this.HtmlResultsBox.Name = "HtmlResultsBox";
            this.HtmlResultsBox.Size = new System.Drawing.Size(367, 198);
            this.HtmlResultsBox.TabIndex = 4;
            this.HtmlResultsBox.Text = "";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(3, 66);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(84, 20);
            this.SearchBox.TabIndex = 5;
            // 
            // SteamGamesDataGridView1
            // 
            this.SteamGamesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SteamGamesDataGridView1.Location = new System.Drawing.Point(168, 0);
            this.SteamGamesDataGridView1.Name = "SteamGamesDataGridView1";
            this.SteamGamesDataGridView1.Size = new System.Drawing.Size(376, 260);
            this.SteamGamesDataGridView1.TabIndex = 6;
            this.SteamGamesDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SteamGamesDataGridView1_CellDoubleClick);
            // 
            // pageSpinner
            // 
            this.pageSpinner.Location = new System.Drawing.Point(3, 92);
            this.pageSpinner.Name = "pageSpinner";
            this.pageSpinner.Size = new System.Drawing.Size(120, 20);
            this.pageSpinner.TabIndex = 7;
            this.pageSpinner.ValueChanged += new System.EventHandler(this.pageSpinner_ValueChanged);
            // 
            // LoadIGbtn
            // 
            this.LoadIGbtn.Location = new System.Drawing.Point(3, 42);
            this.LoadIGbtn.Name = "LoadIGbtn";
            this.LoadIGbtn.Size = new System.Drawing.Size(75, 23);
            this.LoadIGbtn.TabIndex = 8;
            this.LoadIGbtn.Text = "Load IG";
            this.LoadIGbtn.UseVisualStyleBackColor = true;
            this.LoadIGbtn.Click += new System.EventHandler(this.LoadIGbtn_Click);
            // 
            // igDataGridView
            // 
            this.igDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.igDataGridView.Location = new System.Drawing.Point(550, 0);
            this.igDataGridView.Name = "igDataGridView";
            this.igDataGridView.Size = new System.Drawing.Size(386, 260);
            this.igDataGridView.TabIndex = 9;
            this.igDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.igDataGridView_CellDoubleClick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 149);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "label1";
            // 
            // GoToPreferencesButton
            // 
            this.GoToPreferencesButton.Location = new System.Drawing.Point(791, 463);
            this.GoToPreferencesButton.Name = "GoToPreferencesButton";
            this.GoToPreferencesButton.Size = new System.Drawing.Size(118, 40);
            this.GoToPreferencesButton.TabIndex = 11;
            this.GoToPreferencesButton.Text = "GoToPreferences";
            this.GoToPreferencesButton.UseVisualStyleBackColor = true;
            this.GoToPreferencesButton.Click += new System.EventHandler(this.GoToPreferencesButton_Click);
            // 
            // LoadResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.GoToPreferencesButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.igDataGridView);
            this.Controls.Add(this.LoadIGbtn);
            this.Controls.Add(this.pageSpinner);
            this.Controls.Add(this.SteamGamesDataGridView1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.HtmlResultsBox);
            this.Controls.Add(this.LoadSteamBtn);
            this.Name = "LoadResults";
            this.Text = "Track Games";
            ((System.ComponentModel.ISupportInitialize)(this.SteamGamesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadSteamBtn;
        private System.Windows.Forms.RichTextBox HtmlResultsBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView SteamGamesDataGridView1;
        private System.Windows.Forms.NumericUpDown pageSpinner;
        private System.Windows.Forms.Button LoadIGbtn;
        private System.Windows.Forms.DataGridView igDataGridView;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button GoToPreferencesButton;
    }
}

