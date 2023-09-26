using Newtonsoft.Json;

namespace WebApplication3.Models.Structs.CiryInfo.GetAnswerSity
{
    public class City
    {
        [JsonProperty()]
        public CityInformation? CityInfo { get; set; }
    }
}
