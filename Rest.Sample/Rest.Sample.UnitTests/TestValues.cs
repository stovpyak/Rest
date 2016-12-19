using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rest.Sample.UnitTests
{
    [TestClass]
    public class TestValues
    {
        [TestMethod]
        public void TestGet()
        {
            var baseAddress = "http://localhost:8000/";

            using (var server = new Server(baseAddress))
            {
                server.Start();

                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/values").Result;

                Assert.AreEqual("[\"value1\",\"value2\"]", response.Content.ReadAsStringAsync().Result);

                server.Stop();
            }
        }
    }
}
