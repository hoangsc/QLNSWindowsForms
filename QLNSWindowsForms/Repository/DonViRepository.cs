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
    public class DonViRepository : IRepository<DonVi>
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public DonViRepository()
        {
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;

            //_client.BaseAddress = new Uri("http://localhost:55164");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Add(DonVi item)
        {

            var DonVi = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(DonVi);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PostAsync("api/DonVi", byteContent);
            
        }

        public void Delete(int id)
        {
            _client.DeleteAsync($"api/DonVi/{id}");
        }

        public async Task<DonVi> Get(int id)
        {
            _response = await _client.GetAsync($"api/DonVi/{id}");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var DonVi = JsonConvert.DeserializeObject<DonVi>(jsonString);
            return DonVi;
        }

        public async Task<List<DonVi>> GetList()
        {
            _response = await _client.GetAsync($"api/DonVi");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var listDonVis = JsonConvert.DeserializeObject<List<DonVi>>(jsonString);
            return listDonVis;
        }
    }
}
