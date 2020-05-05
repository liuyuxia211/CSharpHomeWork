using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ScrawlForm
{
    public partial class Form1 : Form
    {
        SimpleCrawler simpleCrawler;

        public Form1()
        {
            InitializeComponent();
            simpleCrawler = new SimpleCrawler();

            StartUrltbx.Text = "http://www.cnblogs.com/dstang2000/";
            // simpleCrawler.startUrl = "https://www.cnblogs.com/hohoa/p/";
            //  simpleCrawler.urls.Add(simpleCrawler.startUrl,false);

        }

        private void Crawlbtn_Click(object sender, EventArgs e)
        {
            int d = 0;
            this.Urls.Clear();
            simpleCrawler.urls.Clear();
            if (d < 1)
            {
                simpleCrawler.startUrl = "http://www.cnblogs.com/dstang2000/";
                simpleCrawler.urls.Add(simpleCrawler.startUrl, false);

            }
            StartUrltbx.DataBindings.Add("Text", simpleCrawler, "startUrl");

            new Thread(this.crawl).Start();

        }
        public void crawl()
        {

            if (this.Urls.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { "开始爬行了.... \n" });
            }
            else
            {
                this.Urls.AppendText("开始爬行了.... \n");

            }
            while (simpleCrawler.urls.Count!=0)
            {
                string current = null;
                foreach (string url in simpleCrawler.urls.Keys)
                {
                    if ((bool)simpleCrawler.urls[url]) continue;
                    current = url;
                }

                if (current == null || simpleCrawler.count > 20) break;
                if (this.Urls.InvokeRequired)
                {
                    Action<String> action = this.AddUrl;
                    this.Invoke(action, new object[] { current });
                }
                else
                {
                    this.Urls.AppendText(current);

                }
                string html = simpleCrawler.DownLoad(current); // 下载
                simpleCrawler.urls[current] = true;
                simpleCrawler.count++;
                simpleCrawler.Parse(html);//解析,并加入新的链接
                if (this.Urls.InvokeRequired)
                {
                    Action<String> action = this.AddUrl;
                    this.Invoke(action, new object[] { "\n爬行结束" });
                }
                else
                {
                    this.Urls.AppendText("爬行结束");

                }


            }
        }
        private void AddUrl(string url)
        {
            this.Urls.AppendText(url);
            Urls.AppendText("\n");
        }
    }
}
