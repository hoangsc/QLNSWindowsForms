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
    public class HocViRepository : IRepository<HocVi>
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HocViRepository()
        {
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;

            //_client.BaseAddress = new Uri("http://localhost:55164");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Add(HocVi item)
        {
            var HocVi = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(HocVi);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PostAsync("api/HocVi", byteContent);
        }

        public void Delete(int id)
        {
            _client.DeleteAsync($"api/HocVi/{id}");
        }

        public async Task<HocVi> Get(int id)
        {
            _response = await _client.GetAsync($"api/HocVi/{id}");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var HocVi = JsonConvert.DeserializeObject<HocVi>(jsonString);
            return HocVi;
        }

        public async Task<List<HocVi>> GetList()
        {
            _response = await _client.GetAsync($"api/HocVi");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var listHocVis = JsonConvert.DeserializeObject<List<HocVi>>(jsonString);
            return listHocVis;
        }
    }
}
