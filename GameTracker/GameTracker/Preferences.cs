using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet1.Type_of_games' table. You can move, or remove it, as needed.
            this.type_of_gamesTableAdapter1.Fill(this.gameTracke_DatabaseDataSet1.Type_of_games);
            preferencesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


        }
    }
}
