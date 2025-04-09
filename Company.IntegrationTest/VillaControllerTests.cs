using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Cryptography;

namespace Company.IntegrationTest
{
    public class VillaControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public VillaControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient(); // uses TestServer
        }

        [Fact]
        public async Task Post_Create_RedirectsToIndex_WhenValid()
        {
            // Arrange
            var formData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("Name", "Test Villa"),
        new KeyValuePair<string, string>("Description", "Integration test")
            });

            // Act
            var response = await _client.PostAsync("/Villa/Create", formData);

            // Debugging: Check response content in case of failure
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody); // For debugging purposes

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
            Assert.Equal("/Villa/Index", response.Headers.Location?.ToString());
        }

        [Fact]
        public async Task Get_Create_ReturnsHtmlAndOk()
        {
            // Act
            var response = await _client.GetAsync("/Villa/Create");

            // Debugging: Check response content in case of failure
            var html = await response.Content.ReadAsStringAsync();
            Console.WriteLine(html); // For debugging purposes

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("<form", html); // crude check to see if view rendered
        }

    }
}