using Eshop.RazorPage.Models.ShippingMethods;

namespace Eshop.RazorPage.Services.ShippingMethods;

public interface IShippingMethodService
{
    Task<List<ShippingMethodDto>> GetShippingMethods();
}