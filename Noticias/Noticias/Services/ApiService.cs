namespace Noticias.Services
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
   
    public class ApiService : IApiService
    {
        public async Task<TModel> GetAsync<TModel>(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(new Uri(url));

                    string json = await responseMessage.Content.ReadAsStringAsync();

                    TModel response = JsonConvert.DeserializeObject<TModel>(json);

                    return response;
                }

            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
