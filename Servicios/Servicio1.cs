using System;
using System.Net;
using System.Net.Http;

class Servicio1{
    public Servicio1(){
        try{
//HttpRequestMessage request = new HttpRequestMessage();
        HttpRequestMessage request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;
        request.RequestUri = new Uri("http:\\prescrivet.com");
        request.Headers.Add("authorization", "Bearer 1234567890");
        HttpResponseMessage response = new HttpClient().SendAsync(request).Result;
        string responseString = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(responseString);
        }catch (Exception ex){
Console.WriteLine("Error:" + ex.Message);
        }
        
    }
}
