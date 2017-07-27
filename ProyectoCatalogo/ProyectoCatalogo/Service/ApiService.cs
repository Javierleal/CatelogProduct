using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace ProyectoCatalogo.Service
{
    public class ApiService
    {
        public async Task<List<Order>> GetAllOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://ninjatips.azurewebsites.net/tables/Orders";
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                var result = await client.GetAsync(url);

                string data = await result.Content.ReadAsStringAsync();

                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<Order>>(data);
                }
                else
                    return new List<Order>();
            }
        }

        public async Task<Order> CrearCatalogo(Order newOrder)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://ninjatips.azurewebsites.net/tables/Orders";
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");

                string content = JsonConvert.SerializeObject(newOrder);
                StringContent body = new StringContent(content, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, body);

                string data = await result.Content.ReadAsStringAsync();

                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Order>(data);
                }
                else
                    return null;
            }
        }
    }
}
