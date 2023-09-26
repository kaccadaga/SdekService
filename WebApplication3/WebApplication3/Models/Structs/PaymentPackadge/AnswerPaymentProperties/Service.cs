using Newtonsoft.Json;

namespace WebApplication3.Models.Structs.PaymentPackadge.GetAnswerPayment
{
    #region Service
    public class Service
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("sum")]
        public float sum { get; set; }
        [JsonProperty("total_sum")]
        public float total_sum { get; set; }
        [JsonProperty("discount_percent")]
        public int discount_percent { get; set; }
        [JsonProperty("discount_sum")]
        public float discount_sum { get; set; }
        [JsonProperty("vat_rate")]
        public int vat_rate { get; set; }
        [JsonProperty("vat_sum")]
        public float vat_sum { get; set; }
    }
    #endregion
}
