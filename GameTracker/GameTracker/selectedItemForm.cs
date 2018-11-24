using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class selectedItemForm : Form
    {

        LoadResults LrForm;
        public selectedItemForm(LoadResults incomingForm)
        {
            LrForm = incomingForm;
            InitializeComponent();
        }
       

        private void SelectedGameBtn_Click(object sender, EventArgs e)
        {
           
            
            if (SelectedGameOptions.SelectedIndex == 0) {
                string url = LrForm.urlVar;
                System.Diagnostics.Process.Start(url);
                
               
            }
        }
    }
}
