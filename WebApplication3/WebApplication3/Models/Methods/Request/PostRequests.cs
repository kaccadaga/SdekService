using Newtonsoft.Json;
using System.Net;
using WebApplication3.Models.Structs.Autorization.AnswerAuthorizationTokenProperties;
using WebApplication3.Models.Structs.PaymentPackadge;
using WebApplication3.Models.Structs.PaymentPackadge.GetAnswerPayment;
using WebApplication3.Models.Structs.PaymentPackadge.PackadgeParametrs;

namespace WebApplication3.Models.Methods.Request
{
    public class PostRequests
    {
        #region GetPayment
        public static PaymentPackadgeAnswer GetPayment(int CityCodeSender, int CityCodeResieve, int height_current, int weight_current, int length_current, int width_current, string tariff)
        {
            string AccessURL = "https://api.edu.cdek.ru/v2/calculator/tariff";
            string token = AuthorizationRequest.GetElibilityToken();

            

            using (var client = new WebClient())
            {
                client.Headers.Set($"Authorization", "Bearer " + token);
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var payload = new PaymentRequest
                {
                    type = "2", //1- интернет заказы 2 - доставка
                    currency = "1", //1 - рубли 3 - доллары
                    tariff_code = tariff,
                    from_location = new From_Location
                    {
                        code = CityCodeSender
                    },
                    to_location = new To_Location
                    {
                        code = CityCodeResieve
                    },
                    packages = new Package[]
                    {
                        new Package
                        {
                            height=height_current,
                            weight=weight_current,
                            length=length_current,
                            width=width_current
                        }
                    }
                };

                var stringPayload = JsonConvert.SerializeObject(payload);
                var requestResult = client.UploadString(AccessURL, stringPayload);
                PaymentPackadgeAnswer payment = JsonConvert.DeserializeObject<PaymentPackadgeAnswer>(requestResult);

                return payment;

            }
        }
        #endregion
    }
}

