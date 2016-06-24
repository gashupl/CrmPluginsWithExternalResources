using Foo.Crm.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Foo.Crm.Services.WebApi.Controllers
{
    public class ErrorMessagesController : ApiController
    {
        public string GetErrorMessage(string errorCode)
        {
            return Messages.CannotSaveRecordExceptionMessage; 
        }
    }
}
