using Newtonsoft.Json;

namespace WebApplication3.Models.Structs.PaymentPackadge.GetAnswerPayment
{
    #region PaymentPackadgeAnswer
    public class PaymentPackadgeAnswer
    {
        [JsonProperty("delivery_sum")]
        public float delivery_sum { get; set; }
        [JsonProperty("period_min")]
        public int period_min { get; set; }
        [JsonProperty("period_max")]
        public int period_max { get; set; }
        [JsonProperty("calendar_min")]
        public int calendar_min { get; set; }
        [JsonProperty("calendar_max")]
        public int calendar_max { get; set; }
        [JsonProperty("weight_calc")]
        public int weight_calc { get; set; }
        [JsonProperty("services")]
        public Service[] services { get; set; }
        [JsonProperty("total_sum")]
        public float total_sum { get; set; }
        [JsonProperty("currency")]
        public string currency { get; set; }
        
    }
    #endregion
}
