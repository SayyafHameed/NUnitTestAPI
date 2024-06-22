using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestApiTest.Models.Users;
using RestApiTest.Models.Users.Create;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest.TestFixtures
{
	internal class UsersTests : TestFixtureBase
	{
		[Test]
		public void GetUsers()
		{
			var endpoint = "https://reqres.in/api/users";

			var responseBody = ExecuteGetRequest<UsersResponse>(endpoint);

			responseBody.page.Should().Be(1);
			responseBody.data.Should().NotBeNullOrEmpty();
		}

        [Test]
        public void CreateUsers()
        {
            var endpoint = "https://reqres.in/api/users";

            var client = new RestClient(endpoint);
            var request = new RestRequest();
            request.Method = Method.Post;

			var payload = new UserCreateRequest
			{
				name = "Sayyaf",
				job = "Engineer"
			};

			request.AddJsonBody(payload);

            var response = client.Execute(request);
            var responseBody = JsonConvert.DeserializeObject<UserCreateResponse>(response.Content);

            // verify
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);

			responseBody.id.Should().NotBeNullOrEmpty();
        }
    }
}
