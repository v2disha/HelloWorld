using System;
using System.Net;
using System.Net.Http;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            GetAllEventData();
        }

        static void GetAllEventData() //Get All Events Records  
        {
            using (var client = new HttpClient()) //WebClient  
            {
                //client.DefaultRequestHeaders.Add("Content-Type", "application/json"); //Content-Type  
                for (var i = 1000; i <= 3000; i++)
                {
                    client.GetAsync($"https://api.staging.tree.com/preprime/api/partner/allverticals?apikey=bGhqjj8osusNh9c8aJQwAIf8CFutEn&placement=offers-unmatched&amount={i}&state=AK&productintent=3&employment=8&bankruptcy=9"); //URI  
                    //client.GetAsync($"http://localhost:5000/api/partner/allverticals?apikey=bGhqjj8osusNh9c8aJQwAIf8CFutEn&placement=offers-unmatched&amount={i}&state=AK&productintent=3&employment=8&bankruptcy=9"); //URI  

                    // var response = result.Result.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(Environment.NewLine + i);
                }
            }
        }
    }
}
