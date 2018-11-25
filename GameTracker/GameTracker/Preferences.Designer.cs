namespace GameTracker
{
    partial class Preferences
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
            this.components = new System.ComponentModel.Container();
            this.preferencesDataGridView = new System.Windows.Forms.DataGridView();
            this.gamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPref = new System.Windows.Forms.DataGridViewButtonColumn();
            this.typeofgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTracke_DatabaseDataSet1 = new GameTracker.GameTracke_DatabaseDataSet();
            this.type_of_gamesTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.Type_of_gamesTableAdapter();
            this.gameTracke_DatabaseDataSet = new GameTracker.GameTracke_DatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesDataGridView
            // 
            this.preferencesDataGridView.AutoGenerateColumns = false;
            this.preferencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preferencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamesDataGridViewTextBoxColumn,
            this.AddPref});
            this.preferencesDataGridView.DataSource = this.typeofgamesBindingSource;
            this.preferencesDataGridView.Location = new System.Drawing.Point(228, 98);
            this.preferencesDataGridView.Name = "preferencesDataGridView";
            this.preferencesDataGridView.Size = new System.Drawing.Size(240, 150);
            this.preferencesDataGridView.TabIndex = 0;
            // 
            // gamesDataGridViewTextBoxColumn
            // 
            this.gamesDataGridViewTextBoxColumn.DataPropertyName = "Games";
            this.gamesDataGridViewTextBoxColumn.HeaderText = "Games";
            this.gamesDataGridViewTextBoxColumn.Name = "gamesDataGridViewTextBoxColumn";
            // 
            // AddPref
            // 
            this.AddPref.DataPropertyName = "Games";
            this.AddPref.HeaderText = "Add";
            this.AddPref.Name = "AddPref";
            // 
            // typeofgamesBindingSource
            // 
            this.typeofgamesBindingSource.DataMember = "Type_of_games";
            this.typeofgamesBindingSource.DataSource = this.gameTracke_DatabaseDataSet1;
            // 
            // gameTracke_DatabaseDataSet1
            // 
            this.gameTracke_DatabaseDataSet1.DataSetName = "GameTracke_DatabaseDataSet";
            this.gameTracke_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_of_gamesTableAdapter1
            // 
            this.type_of_gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // gameTracke_DatabaseDataSet
            // 
            this.gameTracke_DatabaseDataSet.DataSetName = "GameTracke_DatabaseDataSet";
            this.gameTracke_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preferencesDataGridView);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView preferencesDataGridView;
        private GameTracke_DatabaseDataSet gameTracke_DatabaseDataSet;
        private GameTracke_DatabaseDataSetTableAdapters.Type_of_gamesTableAdapter type_of_gamesTableAdapter1;
        private GameTracke_DatabaseDataSet gameTracke_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource typeofgamesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AddPref;
    }
}