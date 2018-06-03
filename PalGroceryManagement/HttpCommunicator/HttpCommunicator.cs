using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PalGroceryManagement.HttpCommunication
{
    public class HttpCommunicator
    {
        private const int Timeout = 30000; //millisec

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var address = string.Format("{0}{1}", Constants.BaseUrl, url);
                response =  await client.GetAsync(address);
            }
            return response;
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var address = string.Format("{0}{1}", Constants.BaseUrl, url);
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
                var address = string.Format("{0}{1}", Constants.BaseUrl, url);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync(address, content);
            }
            return response;
        }

        public async Task<HttpResponseMessage> DeleteAsync<T>(string url, string id)
        {
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                var address = string.Format("{0}{1}", Constants.BaseUrl, url);
                response = await client.DeleteAsync(new Uri("{Constant.BaseUrl}{id}"));
            }
            return response;
        }

    }
}
