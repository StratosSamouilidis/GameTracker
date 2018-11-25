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
        public string username;

         public string gametype;
         Login localForm = new Login();
         public Preferences(Login incomingForm)
         {
             localForm = incomingForm;
             InitializeComponent();

         }
        


        private void Preferences_Load(object sender, EventArgs e)
        {
               // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet1.Type_of_games' table. You can move, or remove it, as needed.
                this.type_of_gamesTableAdapter1.Fill(this.gameTracke_DatabaseDataSet1.Type_of_games);
                preferencesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                

        }

        private void preferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              this.username = localForm.username;
               this.gametype = preferencesDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
               if ((int)user_Type_of_gamesTableAdapter1.CheckDuplicates(this.username, this.gametype) != 0)
                   label1.Text = "Preferce already exists";
               else
               {

                   label1.Text=username + "" + gametype;
                   user_Type_of_gamesTableAdapter1.InsertToPrefs(this.username, this.gametype);
               }
    



        }


    }
}
