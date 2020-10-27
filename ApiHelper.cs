using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace QLNSWindowsForms
{
    public  class ApiHelper
        //object tracking
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializerClient()    
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("http://hoangchu.somee.com/"); //cũ
            ApiClient.BaseAddress = new Uri("http://localhost:55164/"); //cũ
            //ApiClient.BaseAddress = new Uri("http://192.168.43.217/quanlynhansuCNTT/"); //hiệu
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
