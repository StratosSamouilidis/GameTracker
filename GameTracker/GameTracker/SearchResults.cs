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
using System.Threading;

namespace GameTracker
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();

            


        }

        private void LoadSteamBtn_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var SteamUrl = "https://store.steampowered.com/search/?term=";
            var SearchTerm = SearchBox.Text;
            var fullUrl = SteamUrl + SearchTerm;
            HtmlResultsBox.Text = fullUrl;
            
         doc = web.Load(fullUrl);
         HtmlTextBox.Text = doc.DocumentNode.OuterHtml;
            var Items = doc.DocumentNode.SelectNodes("//a");
            foreach (var item in Items) {
                //HtmlResultsBox.Text+=item.SelectSingleNode("//")

            }
        //Locate Info
         
     


         
                        

        }

    }
}
