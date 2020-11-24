using System;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string getTouristInfo(string zipcode, string startingAddress)
    {
        using (var httpClient = new HttpClient())
        {
            httpClient.BaseAddress = new Uri("https://api.yelp.com/v3/events");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                "nkLSKR09WobqDKQWN-s9fr8vYUoWaLajhvhzdrDVwTAgA9oQUsUE4ouZHUnXGbizt5Sfl3Fncs2l5E7LPPNC99PROR-MLkwjAuQL3QgwbXzvqSuA6X9bF3nLbfKsXXYx");

            var response = httpClient.GetAsync("?location=" + zipcode +"&sort_on" + "popularity");
            response.Wait();
            var result = response.Result;
            result.EnsureSuccessStatusCode();
            string resultingJSON = result.Content.ReadAsStringAsync().Result;

            JavaScriptSerializer js = new JavaScriptSerializer();
            RootObject obj = js.Deserialize<RootObject>(resultingJSON);
            StringBuilder resultstring = new StringBuilder();
           
            using (var httpClient1 = new HttpClient())
            {
                httpClient1.BaseAddress = new Uri("http://open.mapquestapi.com/directions/v2/route");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                string key = "w347VTE3eUyWxXQHw5oZ77I0AZSBQhxG";
                foreach (Event e in obj.events)
                {
                    string address = e.location.address1 + "," + e.location.city;
                    var response1 = httpClient1.GetAsync("?key=" + key + "&from=" + startingAddress + "&to=" + address);
                    response1.Wait();
                    var result1 = response1.Result;
                    result1.EnsureSuccessStatusCode();
                    string jsonParse = result1.Content.ReadAsStringAsync().Result;
                    RouteObject obj1 = js.Deserialize<RouteObject>(jsonParse);
                    resultstring.Append("Location: " +e.name + ", Address: ");
                    resultstring.Append(address + ",Start Time: ");
                    resultstring.Append(e.time_start + ",Time to Destination: ");
                    resultstring.Append(obj1.route.formattedTime + ", Distance: ");
                    resultstring.Append(obj1.route.distance.ToString() + Environment.NewLine);

                }
            }
            
            return resultstring.ToString();          
        }

        
    } 
}

