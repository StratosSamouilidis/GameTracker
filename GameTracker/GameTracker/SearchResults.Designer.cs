namespace GameTracker
{
    partial class SearchResults
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
            this.gamesDataView = new System.Windows.Forms.DataGridView();
            this.HtmlTextBox = new System.Windows.Forms.RichTextBox();
            this.HtmlResultsBox = new System.Windows.Forms.RichTextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataView)).BeginInit();
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
            // gamesDataView
            // 
            this.gamesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataView.Location = new System.Drawing.Point(93, 12);
            this.gamesDataView.Name = "gamesDataView";
            this.gamesDataView.Size = new System.Drawing.Size(333, 310);
            this.gamesDataView.TabIndex = 2;
            // 
            // HtmlTextBox
            // 
            this.HtmlTextBox.Location = new System.Drawing.Point(432, 12);
            this.HtmlTextBox.Name = "HtmlTextBox";
            this.HtmlTextBox.Size = new System.Drawing.Size(331, 132);
            this.HtmlTextBox.TabIndex = 3;
            this.HtmlTextBox.Text = "";
            // 
            // HtmlResultsBox
            // 
            this.HtmlResultsBox.Location = new System.Drawing.Point(432, 150);
            this.HtmlResultsBox.Name = "HtmlResultsBox";
            this.HtmlResultsBox.Size = new System.Drawing.Size(496, 251);
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
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.HtmlResultsBox);
            this.Controls.Add(this.HtmlTextBox);
            this.Controls.Add(this.gamesDataView);
            this.Controls.Add(this.LoadSteamBtn);
            this.Name = "SearchResults";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadSteamBtn;
        private System.Windows.Forms.DataGridView gamesDataView;
        private System.Windows.Forms.RichTextBox HtmlTextBox;
        private System.Windows.Forms.RichTextBox HtmlResultsBox;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

