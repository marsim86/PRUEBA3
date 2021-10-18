using System;
using System.IO;
using System.Net;
using System.Net.Http;

class Servicio1
{
    public Servicio1()
    {
    }

    public void call1()
    {
        try
        {
            //HttpRequestMessage request = new HttpRequestMessage();
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri("https://reqbin.com/echo/post/json");
            request.Headers.Add("authorization", "Bearer mt0dgHmLJMVQhvjpNXDyA83vA_PxH23Y");
            HttpResponseMessage response = new HttpClient().SendAsync(request).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:" + ex.Message);
        }
    }

    public void call2()
    {
        try
        {
            var url = "https://reqbin.com/echo/post/json";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer mt0dgHmLJMVQhvjpNXDyA83vA_PxH23Y";
            httpRequest.ContentType = "application/json";

            var data = @"{
  ""Id"": 12345,
  ""Customer"": ""John Smith"",
  ""Quantity"": 1,
  ""Price"": 10.00
}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:" + ex.Message);
        }
    }
}
