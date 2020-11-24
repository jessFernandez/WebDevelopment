using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Http;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string closestStore(string zipcode, string storeName)
    {
        using (var httpClient = new HttpClient())
        {
            httpClient.BaseAddress = new Uri("https://api.yelp.com/v3/businesses/search");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                "nkLSKR09WobqDKQWN-s9fr8vYUoWaLajhvhzdrDVwTAgA9oQUsUE4ouZHUnXGbizt5Sfl3Fncs2l5E7LPPNC99PROR-MLkwjAuQL3QgwbXzvqSuA6X9bF3nLbfKsXXYx");

            var response = httpClient.GetAsync("?term=" + storeName + "&location=" + zipcode + "&limit=1");
            response.Wait();
            var result = response.Result;
            result.EnsureSuccessStatusCode();
            string resultingJSON = result.Content.ReadAsStringAsync().Result;

            int address = resultingJSON.IndexOf("display_address");
            string substring = resultingJSON.Substring(address + 1);
            int secondBrace = substring.IndexOf(']');
            substring = substring.Substring(0, secondBrace);
            int brace = substring.IndexOf('[');
            substring = substring.Substring(brace + 1);
            substring = substring.Replace("\"", "");
            return substring;
        }
    }
}
