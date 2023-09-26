using System.Net;
using System.Collections.Specialized;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using WebApplication3.Models.Structs.Autorization;
using WebApplication3.Models.Structs.Autorization.AnswerAuthorizationTokenProperties;

namespace WebApplication3.Models.Methods
{
    public class AuthorizationRequest
    {
        #region  AuthorizationToken
        public static string GetElibilityToken()
        {
          string AccessTokenURL = @"https://api.edu.cdek.ru/v2/oauth/token";

            Credentials credentials = new Credentials();

            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["grant_type"] = credentials.grant_type;
                values["client_id"] = credentials.client_id;
                values["client_secret"] = credentials.client_secret;

                var response = client.UploadValues(AccessTokenURL, values);

                var responseString = Encoding.Default.GetString(response);
                AuthorizationToken authorization_token = JsonConvert.DeserializeObject<AuthorizationToken>(responseString);
                return  authorization_token.access_token;

            }
        }
        #endregion
    }
}
