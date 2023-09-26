using Newtonsoft.Json;

namespace WebApplication3.Models.Structs.Autorization.AnswerAuthorizationTokenProperties
{
    public class AuthorizationToken
    {

        [JsonProperty("access_token")]
        public string? access_token { get; set; }
        [JsonProperty("token_type")]
        string? token_type { get; set; }
        [JsonProperty("expires_in")]
        string? expires_in { get; set; }
        [JsonProperty("scope")]
        string? scope { get; set; }
        [JsonProperty("jti")]
        string? jti { get; set; }
    }
}
