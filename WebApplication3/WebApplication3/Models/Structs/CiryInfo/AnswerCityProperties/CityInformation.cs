using Newtonsoft.Json;

namespace WebApplication3.Models.Structs.CiryInfo.GetAnswerSity
{
    
    #region CityInformation
    public class CityInformation
    {

        [JsonProperty("code")]
        public int code { set; get; } //Код населенного пункта СДЭК	

        [JsonProperty("city_uuid")]
        public Guid FiasId { set; get; } //Идентификатор города получателя

        [JsonProperty("city")]
        public string? city { set; get; } //Название населенного пункта.

        [JsonProperty("kladr_code")]
        public string? kladr_code { set; get; } //Код КЛАДР населенного пункта

        [JsonProperty("country_code")]
        public string? country_code { set; get; } //Код страны населенного пункта в формате  ISO_3166-1_alpha-2

        [JsonProperty("country")]
        public string? country { set; get; } //Название страны населенного пункта

        [JsonProperty("region")]
        public string? region { set; get; } //Название региона населенного пункта	

        [JsonProperty("region_code")]
        public int region_code { set; get; } //Код региона СДЭК	

        [JsonProperty("longitude")]
        public float longitude { set; get; } //Долгота центра населенного пункта

        [JsonProperty("latitude")]
        public float latitude { set; get; } //	Широта центра населенного пункта

        [JsonProperty("time_zone")]
        public string? time_zone { set; get; } //Часовой пояс населенного пункта
        [JsonProperty("payment_limit")]
        public float payment_limit { set; get; } //Ограничение на сумму наложенного платежа в населенном пункте
    }
    #endregion
}
