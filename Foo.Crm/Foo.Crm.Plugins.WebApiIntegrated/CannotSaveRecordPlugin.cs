
using Microsoft.Xrm.Sdk;
using System;
using System.Net.Http;

namespace Foo.Crm.Plugins
{
    public class CannotSaveRecordPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        { 
            throw new InvalidPluginExecutionException(this.GetErrorMessage("myErrorCode")); 
        }

        private string GetErrorMessage(string errorCode)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://foocrmserviceswebapi.azurewebsites.net/");

            HttpResponseMessage response = client.GetAsync("api/ErrorMessages/" + errorCode).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new InvalidPluginExecutionException("Not able to communicate with external web service");
            }
        }
    }
}
