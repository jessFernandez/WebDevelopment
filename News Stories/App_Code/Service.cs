using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
public class Service : IService
{
	

    public string getNews(string keyword)
    {
        var newsApiClient = new NewsApiClient("09f77db57ec44cdea52164d405a1bbba");
        var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
        {
            Q = keyword,
            SortBy = SortBys.Popularity,
            Language = Languages.EN,            
        });
        StringBuilder result = new StringBuilder();
        if(articlesResponse.Status == Statuses.Ok)
        {
            foreach (var article in articlesResponse.Articles)
            {
                result.Append("News Title: " +  article.Title);
                result.Append(Environment.NewLine);
                result.Append("URL: " + article.Url + Environment.NewLine);
            }
        }
        return result.ToString();
       
    }
}
