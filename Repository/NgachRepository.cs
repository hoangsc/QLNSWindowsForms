using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QLNSWindowsForms.IRepository;
using QLNSWindowsForms.Models;

namespace QLNSWindowsForms.Repository
{
    public class NgachRepository : IRepository<Ngach>
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public NgachRepository()
        {
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;

            //_client.BaseAddress = new Uri("http://localhost:55164");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Add(Ngach item)
        {

            var Ngach = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(Ngach);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PostAsync("api/Ngach", byteContent);
        }

        public void Delete(int id)
        {
            _client.DeleteAsync($"api/Ngach/{id}");

        }

        public async Task<Ngach> Get(int id)
        {
            _response = await _client.GetAsync($"api/Ngach/{id}");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var Ngach = JsonConvert.DeserializeObject<Ngach>(jsonString);
            return Ngach;
        }

        public async Task<List<Ngach>> GetList()
        {
            _response = await _client.GetAsync($"api/Ngach");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var listNgachs = JsonConvert.DeserializeObject<List<Ngach>>(jsonString);
            return listNgachs;
        }
    }
}
