using Newtonsoft.Json;
using RestApiTest.Models.Users;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest.TestFixtures
{
    abstract class TestFixtureBase
    {
        protected T ExecuteGetRequest<T>(string endPoint)
        {
            var client = new RestClient(endPoint);
            var request = new RestRequest();
            request.Method = Method.Get;

            var response = client.Execute(request);
            var responseBody = JsonConvert.DeserializeObject<T>(response.Content);
            return responseBody;
        }
    }
}
