using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.Methods.Request;
using WebApplication3.Models.Structs.PaymentPackadge;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SdekServiceController : ControllerBase
    {

        private readonly ILogger<SdekServiceController> _logger;

        public SdekServiceController(ILogger<SdekServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("DeliveryCost")]
        public async Task<string> Get(String CityNameSender, String CityNameResive, int height_current, int weight_current, int length_current, int width_current)
        {
            var tariff = new PaymentsTaiff();
            var result_tarif1 = PostRequests.GetPayment(GetRequests.GetCityCode(CityNameSender), GetRequests.GetCityCode(CityNameResive), height_current, weight_current, length_current, width_current, tariff.tariff1);

            var result_tarif2 = PostRequests.GetPayment(GetRequests.GetCityCode(CityNameSender), GetRequests.GetCityCode(CityNameResive), height_current, weight_current, length_current, width_current, tariff.tariff2);

            return $"Стоимость доставки из точки {CityNameSender} в точку {CityNameResive}. \nДо дверей: "+ result_tarif1.total_sum + "\nДо ПВЗ: "+ result_tarif2.total_sum;

        }

    }
}
