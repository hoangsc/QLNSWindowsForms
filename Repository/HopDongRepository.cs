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
    public class HopDongRepository 
    //public class HopDongRepository : IRepository<HopDong>
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HopDongRepository()
        {
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;

            //_client.BaseAddress = new Uri("http://localhost:55164");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HopDong> Add(HopDong item)
        {
            var HopDongIn = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(HopDongIn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("api/HopDong", byteContent);
            var jsonString = await _response.Content.ReadAsStringAsync();
            var hopDong = JsonConvert.DeserializeObject<HopDong>(jsonString);
            return hopDong;
            
        }

        public void Delete(int id)
        {
            _client.DeleteAsync($"api/HopDong/{id}");

        }

        public async Task<HopDong> Get(int id)
        {
            _response = await _client.GetAsync($"api/HopDong/{id}");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var HopDong = JsonConvert.DeserializeObject<HopDong>(jsonString);
            return HopDong;
        }

        public async Task<List<HopDong>> GetList()
        {
            _response = await _client.GetAsync($"api/HopDong");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var listHopDongs = JsonConvert.DeserializeObject<List<HopDong>>(jsonString);
            return listHopDongs;
        }
        public void Edit(HopDong item, int id)
        {
            var HopDong = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(HopDong);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PutAsync($"api/HopDong/{id}", byteContent);
        }
    }
}
