namespace LTSMerchWebApp.Models;

public class ShippingViewModel
{
    public required Order Order { get; set; }
    public required Cart Cart { get; set; }
}