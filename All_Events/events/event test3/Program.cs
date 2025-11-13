using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test3
{
    internal class Program
    {
        public class NewsArticle {

            public string _Title;
            public string _Content;

            public NewsArticle(string title, string content) {
            
                this._Title = title;
               this._Content = content;
            }

        }

        public class NewsPublisher
        {
            public event EventHandler<NewsArticle> NewsArticle;

           public void PublisherNews(string Title, string Content)
            {
                var Article = new NewsArticle(Title, Content);
                OnNewNewsPublished(Article);
            }

            protected virtual void OnNewNewsPublished(NewsArticle obj)
            {
                NewsArticle?.Invoke(this,obj);
            }
        }

        public class NewsSubscriber
        {
            string _Name;
          public  NewsSubscriber(string name)
            {
                _Name = name;
            }

            public void Subscriber(NewsPublisher obj) {

                obj.NewsArticle += HandleNewNews;
            }
            public void UnSubscriber(NewsPublisher obj)
            {

                obj.NewsArticle -=HandleNewNews;
            }

            private void HandleNewNews(object sander,NewsArticle obj) {

                Console.WriteLine($"{_Name} received a new news article:");
                Console.WriteLine($"Title : {obj._Title} .");
                Console.WriteLine($"Content : {obj._Content} .\n\n\n\n");



            }
        }
        static void Main(string[] args)
        {

            NewsPublisher publisher = new NewsPublisher();
            NewsSubscriber subscriber1 = new NewsSubscriber("subscriber1");

            subscriber1.Subscriber( publisher );

            publisher.PublisherNews("Breaking News", "A significant event just happened!");

            NewsSubscriber subscriber2 = new NewsSubscriber("subscriber2");
            subscriber2.Subscriber(publisher);
            publisher.PublisherNews("Tech Update ", "New gadgets are hitting  the market !");

            subscriber1.UnSubscriber(publisher);
            publisher.PublisherNews("Weather Forecast ", "Expect Sunny Weather for the weekend !");





        }
    }
}
