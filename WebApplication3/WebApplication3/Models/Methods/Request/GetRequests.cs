using Newtonsoft.Json;
using System.Diagnostics;
using System.Web;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.Collections.Generic;
using System.Collections.Immutable;
using WebApplication3.Models.Structs.CiryInfo.GetAnswerSity;

namespace WebApplication3.Models.Methods.Request
{
    public class GetRequests
    {
        #region GetCityCode
        public static int GetCityCode(string name_city)
        {
            var client = new WebClient();

            string token = AuthorizationRequest.GetElibilityToken();
            client.Headers.Set($"Authorization", "Bearer " + token);

            string city = HttpUtility.UrlEncode(name_city);// Преобразуем кирилицу в URL формат 

            List<CityInformation> result = new List<CityInformation>();

            string country_code = "RU";//Код страны

            string AccessTokenURL = $"https://api.edu.cdek.ru/v2/location/cities?city={city}&country_codes={country_code}";

            try
            {

                var response = client.DownloadData(AccessTokenURL);
                var responseString = Encoding.UTF8.GetString(response);
                result = JsonConvert.DeserializeObject<List<CityInformation>>(responseString);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Process.GetCurrentProcess().Kill();

            }
            return result[0].code;
            
        }
        #endregion
    }
}
