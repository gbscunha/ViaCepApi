using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ViaCepApi
{
    public class Class1
    {
        private readonly HttpClient _httpClient;

        public Class1() 
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> ConsultarCepAsync(string cep) 
        {
            private const string UrlApi = $"https://viacep.com.br/ws/{cep}/json/";
            HttpResponseMessage response = await _httpClient.GetAsync(UrlApi);

            if (response.IsSuccessStatusCode) 
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Erro na consulta: {response.StatusCode}";
            }
        }
    }
}
