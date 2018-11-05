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
            var ItemList = doc.DocumentNode.SelectSingleNode("//div[@id='search_result_container']");
            //var Items = ItemList.SelectNodes("//a").Contains("responsive_search_name_combined");
            //kappa keepo


            foreach (var item in Items)
            {

                if (item.InnerHtml.Contains("responsive_search_name_combined")) ;
                HtmlResultsBox.Text += item.InnerHtml;

                /*
                    var nameNode = item.SelectSingleNode("//div[@class='responsive_search_name_combined']");
                    var nameDeeperNode = nameNode.SelectSingleNode("//div[@class='col search_name ellipsis']");
                    var nameSpan = nameDeeperNode.SelectSingleNode("//span[@class='title']");
                    var Name = nameSpan.InnerText;
                    HtmlResultsBox.Text += Name;


    */
            }
           
            //Locate Info









        }

    }
}
