using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace GameTracker
{
    class PageCall
    {
        private string html { get; set; }
        private string url { get; set; }

        public PageCall() { }
        public PageCall(string html,string url)
        {
            html = this.html;
            url = this.url;
        }
        
       public void DownloadPageHttpWebRequest()
        {
             html = string.Empty;
             url = "https://www.youtube.com";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream)) {

                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
        }

    }
}
