

using CreateQuiz.ViewModels;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CreateQuiz.Helper
{
    public static class GetArticle
    {
        public static List<string> GetALL()
        {
            List<string> LinkList = new List<string>();
            HtmlDocument doc = new HtmlDocument();
            string mainURL = "https://www.wired.com";
            //Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36 OPR/82.0.4227.33

            try
            {
                using (var client = new WebClient() { Encoding=Encoding.UTF8})
                {
                    
                    
                    client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36 OPR/82.0.4227.33";
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    var response = client.DownloadString(mainURL);
                    doc.LoadHtml(response);
                   
                    client.Dispose();
                }
            }
            catch (Exception)
            {

            }
            
            //var a = doc.DocumentNode.SelectSingleNode("//div[@class='BaseWrap-sc-TURhJ ContentHeaderTitleBlockWrapper-jqwWfR eTiIvU fbGudO']//h1").InnerText;
            //summary-item-tracking__hed-link summary-item__hed-link
            var a = doc.DocumentNode.SelectNodes("//a[@class='summary-item-tracking__hed-link summary-item__hed-link']");
            int i = 0;
            List<string> hrefList =new List<string>();
            foreach (var item in a)
            {
                string mainUrl = "https://www.wired.com";
                string href = item.Attributes["href"].Value;
                
                if (href.Contains("/story"))
                {
                    
                    LinkList.Add(mainURL + href);
                }
                else if(href.Contains("story")){
                    LinkList.Add(mainURL + "/"+href);
                } 
                

                
            }
            
            return LinkList.Distinct().Take(5).ToList();
        }
       
        public static List<Article> GetDetails(List<string> LinkList)
        {
            List<Article> articles = new List<Article>();
            HtmlDocument doc = new HtmlDocument();
            int id = 1;

            foreach (var item in LinkList)
            {
                Article article = new Article();
                

                try
                {
                    using (var client = new WebClient() { Encoding = Encoding.UTF8 })
                    {
                        client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36 OPR/82.0.4227.33";
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                        var response = client.DownloadString(item.ToString());
                        doc.LoadHtml(response);

                    }
                }
                catch (Exception)
                {

                }
                

                try
                {
                    var title = doc.DocumentNode.SelectSingleNode("//h1[@class='BaseWrap-sc-TURhJ BaseText-fFzBQt ContentHeaderHed-kpvpFG eTiIvU dFUJIZ kjQZOs']").InnerText;
                    article.ArticleTitle = title;
                }
                catch(Exception)
                {
                    article.ArticleTitle = "Bu ücretli bir yazıdır. Okumak için sisteme üye olmanız gerekmektedir.";
                }
                try
                {
                    var text = doc.DocumentNode.SelectSingleNode("//div[@class='body__inner-container']//p").InnerText;
                    article.ArticleText = text;
                }
                catch(Exception)
                {
                    article.ArticleText = "Okumak için sisteme üye olmanız gerekmektedir.";
                }

                
                articles.Add(article);

            }

            


            return articles.Distinct().ToList();
        }
    }
}
