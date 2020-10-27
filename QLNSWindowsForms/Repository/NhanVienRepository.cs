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
    public class NhanVienRepository : IRepository<NhanVien>
    {
        public HttpClient _client;  
        public HttpResponseMessage _response;
        
        public NhanVienRepository()
        {
            ApiHelper.InitializerClient();
            _client = ApiHelper.ApiClient;
            
            //_client.BaseAddress = new Uri("http://localhost:55164");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Add(NhanVien item)
        {
            var nhanVien = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(nhanVien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PostAsync("api/nhanvien", byteContent);
        }

        public void Delete(int id)
        {
            _client.DeleteAsync($"api/nhanvien/{id}");

        }

        public async Task<NhanVien> Get(int id)
        {
            _response = await _client.GetAsync($"api/nhanvien/{id}");
            if (_response.IsSuccessStatusCode)
            {
                var a = _response.RequestMessage;
                var b = _response.Content.ReadAsStringAsync().Result;
                var ab = _response.StatusCode.ToString();
                var c = _response.Content.ReadAsStringAsync().Exception;
            }
            var jsonString = await _response.Content.ReadAsStringAsync();
            var nhanVien = JsonConvert.DeserializeObject<NhanVien>(jsonString);
            return nhanVien;
        }

        public async Task<List<NhanVien>> GetList()
        {
            _response = await _client.GetAsync($"api/nhanvien");
            var jsonString = await _response.Content.ReadAsStringAsync();
            var listNhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(jsonString);
            return listNhanViens;
        }

        public void Edit(NhanVien item, int id)
        {
            var nhanVien = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(nhanVien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = _client.PutAsync($"api/nhanvien/{id}", byteContent);
        }
    }
}
