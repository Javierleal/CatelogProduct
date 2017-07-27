using Newtonsoft.Json;
using ProyectoCatalogo.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCatalogo.Service
{
	public class ServiceCatalog
	{
		public async Task<List<CatalogoProductos>> GetAllCatalogo()
		{
            using (HttpClient client = new HttpClient())
			{
				string url = "http://catalogservice.azurewebsites.net/tables/CatalogoProductos";
				client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
				var result = await client.GetAsync(url);

				string data = await result.Content.ReadAsStringAsync();

				if (result.IsSuccessStatusCode)
				{
					return JsonConvert.DeserializeObject<List<CatalogoProductos>>(data);
				}
				else
					return new List<CatalogoProductos>();
			}
		}

        public async Task<CatalogoProductos> CrearCatalogo(CatalogoProductos newOrder)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://catalogservice.azurewebsites.net/tables/CatalogoProductos";
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");

                string content = JsonConvert.SerializeObject(newOrder);
                StringContent body = new StringContent(content, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, body);

                string data = await result.Content.ReadAsStringAsync();

                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<CatalogoProductos>(data);
                }
                else
                    return null;
            }
        }
    }
}
