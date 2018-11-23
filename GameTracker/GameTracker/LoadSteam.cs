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
    public partial class LoadSteam : Form
    {
        public LoadSteam()
        {
            InitializeComponent();




        }
        private string constructUrl() {
            //construct url
            var SteamUrl = "https://store.steampowered.com/search/?term=";
            var SearchTerm = SearchBox.Text + "\n";
            var fullUrl = SteamUrl + SearchTerm;
            HtmlResultsBox.Text = fullUrl;
            if (pageSpinner.Value > 0) {
                fullUrl += "&page=" + pageSpinner.Value;
            }

            return fullUrl;
        }
        private void LoadSteamBtn_Click(object sender, EventArgs e)
         {
            LoadSteamResults();
            
        }
        private void LoadSteamResults() {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var fullUrl = constructUrl();                       
            doc = web.Load(fullUrl);
            var ItemList = doc.DocumentNode.SelectSingleNode("//*[@id='search_result_container']");
            var Items = ItemList.SelectSingleNode("//*[@id='search_result_container']/div[2]");
            if (Items != null)//in case no results are found
            {
                var GameItems = Items.SelectNodes(".//a");
                DataTable GameTable = new DataTable();
                GameTable.Columns.Add("Game Name");
                GameTable.Columns.Add("Game Price");
                
                foreach (HtmlNode item in GameItems)
                {
                    if (item.Name != "a")
                    {
                        HtmlResultsBox.Text = "its node a game \n";

                    }
                    //Scrap game name

                    var nameNode = item.SelectSingleNode(".//div[@class='responsive_search_name_combined']");
                    var nameDeeperNode = nameNode.SelectSingleNode(".//div[@class='col search_name ellipsis']");
                    var nameSpan = nameDeeperNode.SelectSingleNode(".//span[@class='title']");
                    var Name = nameSpan.InnerText;

                    //Scrap game Price
                    var priceDiscountNode = nameNode.SelectSingleNode(".//div[@class='col search_price_discount_combined responsive_secondrow']");
                    var PriceNode = priceDiscountNode.SelectSingleNode(".//div[@class='col search_price  responsive_secondrow']");
                    var Price = "Not available at this point";
                    if (PriceNode != null)
                    {
                        Price = PriceNode.InnerText;
                    }


                    HtmlResultsBox.Text += Name + Price + "\n";
                    GameTable.Rows.Add(Name, Price);
                    Console.WriteLine("");

                }

                gamesDataGridView1.DataSource = GameTable;
                gamesDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//gia na fainetai olo to cell
         
            }
            else
            {
                HtmlResultsBox.Text = "No Results were returned for that query";
            }
        }

        private void pageSpinner_ValueChanged(object sender, EventArgs e)
        {
            if (pageSpinner.Value > 0) {
                LoadSteamResults();

            }
        }
    }
}
