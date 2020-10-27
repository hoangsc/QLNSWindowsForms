using DevExpress.Utils.OAuth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Authorization
{
   public class Auth
    {
        private string username = "";
        private string password = "";
        protected HttpClient _client;

        public Auth(string user, string pass)
        {
            username = user;
            password = pass;
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;
        }

        public string GetToken()
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };
            var content = new FormUrlEncodedContent(pairs);
            var _response = _client.PostAsync("oauth/token", content).Result;
            if (_response.IsSuccessStatusCode)
            {
                var data = _response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Token>(data);
                string a = result.ToString();
                string b = result.Value;
                return b;
            }
            return "";
        }
    }
}
