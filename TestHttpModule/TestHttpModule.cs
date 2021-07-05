using System;
using System.Management.Automation;
using System.Net.Http;

namespace TestHttpModule
{
    [Cmdlet("Test", "HttpModule")]
    public class TestHttpModuleCommand : Cmdlet
    {
        protected override void EndProcessing()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://google.com");
            var result = client.SendAsync(request).Result;
            WriteWarning(result.RequestMessage.ToString());
        }
    }
}
