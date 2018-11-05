using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;


namespace GameTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("TITLE", typeof(string));
            table.Columns.Add("PRICE", typeof(string));


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
