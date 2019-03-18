using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client.Library.PublicAPI.External.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriggerNotificationController : ControllerBase
    {
        private IConfiguration _configuration;

        public TriggerNotificationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<ActionResult>  Post()
        {
            var priorAuthNowEndpoint = 
                new Uri(_configuration["UrlForPriorAuthNowTestEndpoint"]);

            using (HttpClient client = new HttpClient())
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, priorAuthNowEndpoint);
                var content = GetJsonMessage(_configuration["UrlForWebhook"]);
                requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();
            }
            return Ok();

        }

        string GetJsonMessage(string target)
        {
            return JsonConvert.SerializeObject(JObject.Parse(@"
                {
                    ""urlForPostback"":"""+target+@"""
                }
            "));
        }
        public class JsonContent : StringContent
        {
            public JsonContent(object obj) :
                base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
            { }
        }
    }
}
