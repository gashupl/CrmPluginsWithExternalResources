using Foo.Crm.External;
using Microsoft.Xrm.Sdk;
using System;

namespace Foo.Crm.Plugins
{
    public class CannotSaveRecordPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            throw new InvalidPluginExecutionException(Messages.CannotSaveRecordExceptionMessage); 
        }
    }
}
