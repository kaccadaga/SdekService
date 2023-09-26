using WebApplication3.Models.Structs.PaymentPackadge.PackadgeParametrs;

namespace WebApplication3.Models.Structs.PaymentPackadge
{
    public class PaymentRequest
    {
        public string? type { get; set; }
        public string? currency { get; set; }
        public string? tariff_code { get; set; }
        public From_Location? from_location { get; set; }
        public To_Location? to_location { get; set; }
        public Package[]? packages { get; set; }
    }

}
