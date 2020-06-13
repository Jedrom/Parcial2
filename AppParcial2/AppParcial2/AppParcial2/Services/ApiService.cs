namespace AppParcial2.Services
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class ApiService
    {
        public async Task<List<T>> Get<T>(
            string urlBase,
            string servicePrefix,
            string controller
            )
        {
            try
            {
                var client = new HttpClient();
                /*client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    tokenType, accessToken);*/
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}", servicePrefix, controller);
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch
            {
                return null;
            }
        }



    }
}
