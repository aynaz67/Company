using Company.Domain.Entity;
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
        new KeyValuePair<string, string>("Description", "Integration test"),
        new KeyValuePair<string, string>("CreateDate", "Integration test"),
        new KeyValuePair<string, string>("UpdateDate", "Integration test")

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

        [Fact]
        public async Task Post_Edit_Villa_Returns_Redirect()
        {
            // Arrange
            //var villaId = 1003;
            var formData = new Dictionary<string, string>
        {
           // { "Id", villaId.ToString() },
            { "Id", "1003" },
            { "Name", "Updated Villa Name" },
            { "Description", "Updated Description" },
            { "CreateDate", DateTime.UtcNow.ToString("o") }, // ISO 8601 format
            { "UpdateDate", DateTime.UtcNow.ToString("o") }
        };
            var content = new FormUrlEncodedContent(formData);

            // Act
            //   var response = await _client.PostAsync($"/Villa/Update/{villaId}", content);
            var response = await _client.PostAsync("/Villa/Update/1003", content);

            Console.WriteLine($"Redirect Location: {response.Headers.Location}");
            Console.WriteLine($"Response Status Code: {response.StatusCode}");
            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
           // Assert.Equal("/Villa/Index", response.Headers.Location?.ToString());
        }
    }
}