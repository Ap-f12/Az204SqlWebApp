using Az204SqlWebApp.Models;

namespace Az204SqlWebApp.Services
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        Task<bool> IsBeta();
    }
}