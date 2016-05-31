using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class HttpClientIntegrationTests
        {

            [TestMethod]
            public async Task HttpClient_Should_Get_OKStatus_From_Products_Using_InMemory_Hosting()
            {

                var config = new HttpConfiguration();
                config.MapHttpAttributeRoutes();

                using (var server = new HttpServer(config))
                {

                    var client = new HttpClient(server);

                    string url = "http://localhost/api/product/hello/";

                    var request = new HttpRequestMessage
                    {
                        RequestUri = new Uri(url),
                        Method = HttpMethod.Get
                    };

                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var response = await client.SendAsync(request))
                    {
                        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    }
                }
            }

            [TestMethod]
            public async Task HttpClient_Should_Get_OKStatus_From_Products_Using_InMemory_Hosting_Simplified()
            {
                var config = new HttpConfiguration();
                config.MapHttpAttributeRoutes();

                using (var server = new HttpServer(config))
                {

                    var client = new HttpClient(server);

                    string url = "http://localhost/api/product/hello/";

                    using (var response = await client.GetAsync(url))
                    {
                        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                    }
                }
            }
        }
    }
}
