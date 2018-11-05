using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Data;

namespace GameTracker
{
    class EbayScrapper
    {
      
        private string Id;
        private string title;
        private string price;
        private string url;
        

        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string TITLE
        {
            get { return title; }
            set { title = value; }
        }

        public string PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        public EbayScrapper(string id,string title,string price,string url)
        {
            ID = id;
            TITLE = title;
            PRICE = price;
            URL = url;
        }

        public EbayScrapper()
        {
        }

        private async void GetHtmlAsync(DataTable table)
        {
            var url = "https://www.ebay.com/sch/i.html?_from=R40&_trksid=m570.l1313&_nkw=games&_sacat=0";
            var httpclient = new HttpClient();
            var html = await httpclient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);


            var ProductsHtml = htmlDocument.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("ListViewInner")).ToList();


            var ProductListItems = ProductsHtml[0].Descendants("li")
                .Where(node => node.GetAttributeValue("id", "").Contains("item")).ToList();

            foreach (var item in ProductListItems)
            {
                //id
               Id= item.GetAttributeValue("listingid", "");
                //name
                title=item.Descendants("h3")
                    .Where(node => node.GetAttributeValue("class", "")
                .Equals("lvtitle")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t')
                ;
                //price

               
                 price =  Regex.Match(
                     item.Descendants("li")
                     .Where(node => node.GetAttributeValue("class", "")
                 .Equals("lvprice prc")).FirstOrDefault()
                 .InnerText.Trim('\r', '\n', '\t'), @"\d+.\d+").Value;
                ;

             //   Console.WriteLine('\n');
            }


         //   Console.WriteLine();





        }
    }
}
