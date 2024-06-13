using HiCupon.BC.Constants;
using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.SG;
using Newtonsoft.Json;
using System.Net.Http;

namespace HiCupon.SG.Actions
{
    public class ManageCouponSG : IManageCouponSG
    {
        private readonly HttpClient _httpClient;
        private readonly string COUPON_URL = $"{PHPConstants.BASE_URL}Coupon/";

        public ManageCouponSG(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Coupon>> GetSomeCoupons(string search, string category, int page, int elements)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{COUPON_URL}getSomeCouponsForCustomer&search={search}&category={category}&page={page}&elements={elements}");
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error en {COUPON_URL} al obtener el mensaje");

            return JsonConvert.DeserializeObject<IEnumerable<Coupon>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<IEnumerable<Coupon>> GetSomeCouponsOfCustomer(string coupons, int page, int elements)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{COUPON_URL}getSomeCouponsOfCustomer&coupons={coupons}&page={page}&elements={elements}");
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error en {COUPON_URL} al obtener el mensaje");

            return JsonConvert.DeserializeObject<IEnumerable<Coupon>>(await response.Content.ReadAsStringAsync());
        }
    }
}
