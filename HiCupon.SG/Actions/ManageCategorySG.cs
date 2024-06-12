using HiCupon.BC.Constants;
using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.SG;
using Newtonsoft.Json;

namespace HiCupon.SG.Actions
{
    public class ManageCategorySG : IManageCategorySG
    {
        private readonly HttpClient _httpClient;
        private readonly string CATEGORY_URL = $"{PHPConstants.BASE_URL}Category/";

        public ManageCategorySG(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{CATEGORY_URL}getAllCategories");
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error en {CATEGORY_URL} al obtener el mensaje");

            return JsonConvert.DeserializeObject<IEnumerable<Category>>(await response.Content.ReadAsStringAsync());
        }
    }
}
