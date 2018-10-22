using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using HtmlAgilityPack;


namespace GameTracker
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }
        private void initTable()
        {
            table = new DataTable("gameOffersTable");
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(double));
            
            gameOffersData.DataSource = table;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            initTable();
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();          
            var doc=await Task.Factory.StartNew(()=> web.Load("https://www.gamerankings.com/browse.html")) ;


            doc.DocumentNode.SelectNodes("//*[@id=\"main_col\"]/div[1]/div[2]/table/tbody/tr[5]/td[1]/a");

        }


    }
}
