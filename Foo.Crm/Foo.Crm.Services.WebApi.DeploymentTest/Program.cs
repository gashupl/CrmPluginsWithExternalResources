using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Crm.Services.WebApi.DeploymentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://foocrmserviceswebapi.azurewebsites.net/");

            HttpResponseMessage response = client.GetAsync("api/ErrorMessages/123").Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("Bloody hell! Something went terribly wrong."); 
            }
        }
    }
}
