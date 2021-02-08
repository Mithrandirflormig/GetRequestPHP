namespace GetRequestPHP.WebService
{
    using System.Threading.Tasks;
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ClienteManager
    {
        const string URL = "http://192.168.0.8/WebService/index.php";

        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<Clientes>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Clientes>>(content);
            }

            return Enumerable.Empty<Clientes>();


        }
    }
}
