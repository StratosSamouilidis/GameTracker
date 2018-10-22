using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;


namespace EbayScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHtmlAsync();
            Console.ReadLine();
        }
        private static async void GetHtmlAsync()
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

            foreach(var item in ProductListItems)
            {
                //id
                Console.WriteLine(item.GetAttributeValue("listingid","")); 
                //name
                Console.Write(item.Descendants("h3")
                    .Where(node => node.GetAttributeValue("class", "")
                .Equals("lvtitle")).FirstOrDefault().InnerText.Trim('\r','\n','\t')
                );
                //price
                
                Console.Write(" "+
                    Regex.Match(
                    item.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                .Equals("lvprice prc")).FirstOrDefault()
                .InnerText.Trim('\r', '\n', '\t'),@"\d+.\d+")
                );

                Console.WriteLine('\n');
            }


            Console.WriteLine();


           
            

        }
    }
}
