namespace GameTracker
{
    partial class LoadSteam
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
            this.gamesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageSpinner = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).BeginInit();
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
            this.HtmlResultsBox.Location = new System.Drawing.Point(168, 203);
            this.HtmlResultsBox.Name = "HtmlResultsBox";
            this.HtmlResultsBox.Size = new System.Drawing.Size(496, 198);
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
            // gamesDataGridView1
            // 
            this.gamesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView1.Location = new System.Drawing.Point(168, 12);
            this.gamesDataGridView1.Name = "gamesDataGridView1";
            this.gamesDataGridView1.Size = new System.Drawing.Size(535, 185);
            this.gamesDataGridView1.TabIndex = 6;
            // 
            // pageSpinner
            // 
            this.pageSpinner.Location = new System.Drawing.Point(3, 92);
            this.pageSpinner.Name = "pageSpinner";
            this.pageSpinner.Size = new System.Drawing.Size(120, 20);
            this.pageSpinner.TabIndex = 7;
            this.pageSpinner.ValueChanged += new System.EventHandler(this.pageSpinner_ValueChanged);
            // 
            // LoadSteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.pageSpinner);
            this.Controls.Add(this.gamesDataGridView1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.HtmlResultsBox);
            this.Controls.Add(this.LoadSteamBtn);
            this.Name = "LoadSteam";
            this.Text = "Steam";
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadSteamBtn;
        private System.Windows.Forms.RichTextBox HtmlResultsBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView gamesDataGridView1;
        private System.Windows.Forms.NumericUpDown pageSpinner;
    }
}

