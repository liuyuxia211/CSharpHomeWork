using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScrawlForm
{

    public class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private Dictionary<string, int> depth = new Dictionary<string, int>();  // record the depth
        public int count = 0;
        public string startUrl { get; set; }

     /*   public void Crawl()
        {

            //Console.WriteLine("开始爬行了.... ");

            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 20) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                // if (ddd < 1)
                //{
                // ddd += 1;
                Parse(html);//解析,并加入新的链接
                            // }
                Console.WriteLine("爬行结束");


            }
        }
*/
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                // Console.WriteLine(count);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {

            string temp = "";
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                temp = startUrl;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (!Regex.IsMatch(strRef, ".html")) continue;
                //if (Regex.IsMatch(strRef, startUrl)) { }
                else if (Regex.IsMatch(strRef, "(http://|https://)")) { }
                else if (Regex.IsMatch(strRef, @"^/\w+")) { strRef = temp.Substring(0, temp.TrimEnd('/').LastIndexOf('/')) + strRef; }
                else if (Regex.IsMatch(strRef, @"^//\w+"))
                {
                    temp.TrimEnd(Regex.Match(temp, @"/\w+/\w+/$").Value.ToCharArray());
                    strRef = temp + strRef;

                }
                if (urls[strRef] == null) { urls[strRef] = false; }// depth[strRef] = num; }

            }
        }
    }


}
