using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace PalGroceryManagement.HttpCommunicator
{
    public class HttpCommunicator
    {

        private const string BaseUrl = "";

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            using (var client = new HttpClient())
            {              
                var address = string.Format("{0}{1}", BaseUrl, url);
                return await client.GetAsync(address);
            }
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {                
                var address = string.Format("{0}{1}", BaseUrl, url);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync(address, content);
            }
            return response;
        }


        public async Task<HttpResponseMessage> PutAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                var address = string.Format("{0}{1}", BaseUrl, url);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync(address, content);
            }
            return response;
        }
    }
}
