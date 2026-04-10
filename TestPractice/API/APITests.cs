using Bogus;
using BusinessLayer.Modules;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V143.Network;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Builder;


namespace TestPractice.API
{
    public class APITests
    {
     /*   // 1. Get the token
        var loginRequest = new RestRequest("/auth/login", Method.Post);
        loginRequest.AddJsonBody(new { username = "user", password = "pass" });

var loginResponse = await client.ExecuteAsync(loginRequest);
    var token = //* extract token from loginResponse.Content, e.g., using JSON parsing 

     2. Use the token in another request
    var apiRequest = new RestRequest("/endpoint", Method.Get);
    apiRequest.AddHeader("Authorization", $"Bearer {token}");

var apiResponse = await client.ExecuteAsync(apiRequest);
    Console.WriteLine(apiResponse.Content);
    */
        private readonly string _url = "https://petstore.swagger.io/v2";
        private RestClient? _restClient;
        private RestRequest? _request;
        RestResponse? response;
        Random random;
        Faker faker=new Faker();
        [Test]
        public void GetMethod()
        {random=new Random();
            int id = 1;
            _restClient = new RestClient(_url);
            _request = new RestRequest($"/pet/{id}", Method.Get);
            _request.AddHeader("Accept", "application/json");
            //_request.AddHeader("Authorization", "Bearer YOUR_ACCESS_TOKEN");
            response = _restClient.Execute(_request);

           
            Assert.IsNotNull(response, "Response should not be null.");
            Assert.IsTrue(response.IsSuccessful, $"Request was not successful. Status: {(int)response.StatusCode} - {response.StatusDescription}");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Expected HTTP 200 OK.");
        }
        [Test]
        public void GetMethodDeserialize()
        {
            random = new Random();
            int id = 1;
            _restClient = new RestClient(_url);
            _request = new RestRequest($"/pet/{id}", Method.Get);
            _request.AddHeader("Accept", "application/json");


          RestResponse<GetPetById> _response = _restClient.Execute<GetPetById>(_request);

            GetPetById R = _response.Data;//one way
           
            GetPetById? deserializeResp = null;
            if (!string.IsNullOrEmpty(_response?.Content))
            {
                deserializeResp = JsonConvert.DeserializeObject<GetPetById>(_response.Content);
            }

            Assert.IsNotNull(_response, "Response should not be null.");
            Assert.IsTrue(_response.IsSuccessful, $"Request was not successful. Status: {(int)_response.StatusCode} - {_response.StatusDescription}");
            Assert.That(_response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Expected HTTP 200 OK.");
            Assert.IsNotNull(deserializeResp, "Deserialized response should not be null.");
        }
        [Test]
        public void postMethod()
        {
            int id = 1;
            string name = "Doggie";
            string status = "available";
            string body = $@"
{{
  ""id"": {id},
  ""category"": {{
    ""id"": {id},
    ""name"": ""{name}""
  }},
  ""name"": ""{name}"",
  ""photoUrls"": [
    ""https://petstore.swagger.io/#/pet/addPet""
  ],
  ""tags"": [
    {{
      ""id"": 5,
      ""name"": ""{name}""
    }}
  ],
  ""status"": ""{status}""
}}";

            var client = new RestClient(_url);
            var request = new RestRequest("/pet", Method.Post);

            request.AddHeader("Accept", "application/json");            
            
            request.AddStringBody(body, DataFormat.Json);               

           
            RestResponse<GetPetById> _response = client.Execute<GetPetById>(request);

          
            GetPetById pet = _response.Data;

           
            Assert.IsNotNull(pet, "Deserialized response should not be null.");
            Assert.AreEqual(1, pet.Id, "Pet ID should be 1.");
           
            Assert.AreEqual(1, pet.Id, "Category ID should be 1.");
            Assert.AreEqual("Doggie", pet.Name, "Category name should be 'Doggie'.");
            Assert.AreEqual("Doggie", pet.Name, "Pet name should be 'Doggie'.");
           
           
        }
        [Test]
        public void putMethod()
        {
            string name = faker.Person.FirstName;
            string status = "available";
            int id = 10;

             _restClient = new RestClient(_url);
             _request = new RestRequest("/pet", Method.Put);

            _request.AddHeader("Accept", "application/json");
            _request.AddHeader("Accept", "application/json");

           
            var body = $@"{{
        ""id"": {id},
        ""category"": {{ ""id"": 1, ""name"": ""Dog"" }},
        ""name"": ""{name}"",
        ""photoUrls"": [""https://example.com/images/{name.ToLower()}.jpg""],
        ""tags"": [
            {{ ""id"": 10, ""name"": ""Friendly"" }},
            {{ ""id"": 11, ""name"": ""Trained"" }}
        ],
        ""status"": ""{status}""
    }}";
            _request.AddStringBody(body, DataFormat.Json);

            RestResponse<GetPetById> response = _restClient.Execute<GetPetById>(_request);

            Assert.IsNotNull(response, "Response should not be null.");
            Assert.IsTrue(response.IsSuccessful, $"Request was not successful. Status: {(int)response.StatusCode} - {response.StatusDescription}");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Expected HTTP 200 OK.");
            Assert.IsNotNull(response.Data, "Deserialized response data should not be null.");
            Assert.AreEqual(id, response.Data.Id, "Pet ID in response does not match the request.");
            Assert.AreEqual(name, response.Data.Name, "Pet name in response does not match the request.");
            Assert.AreEqual(status, response.Data.Status, "Pet status in response does not match the request.");          

        }

        [TearDown]
        public void disposed()
        {            
            _restClient?.Dispose();
            _restClient?.Dispose();
            _request=null;
        }
    }
}
